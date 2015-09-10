using System;
using System.Linq;
using System.Windows.Forms;
using Core.DomainModel;
using Core.Interfaces;
using Ninject.Infrastructure.Language;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Common;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Views.Drawings;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.Desktop.Concrete.Controllers.Common
{
    public class SiemensDataImportController : ISiemensDataImportController, IUppyDataImport
    {
        private readonly IClassDataManager<Drawing> _drawingsDataManager;
        private readonly int? _parentId;

        public SiemensDataImportController(IClassDataManager<Drawing> drawingsDataManager)
        {
            _drawingsDataManager = drawingsDataManager;
        }

        public SiemensDataImportController(IClassDataManager<Drawing> drawingsDataManager, int? parentId)
        {
            _drawingsDataManager = drawingsDataManager;
            _parentId = parentId;
        }

        public void SaveDrawingsToDataBase(TempDrawingsStorage storage)
        {
            storage.Drawings.Where(x => x.ParentId == null).Map(x => x.ParentId = _parentId);

            foreach (var drawing in storage.Drawings.OrderBy(x => x.Id).AsParallel())
            {
                var oldId = drawing.Id;
                drawing.Id = null;
                _drawingsDataManager.Insert(drawing);
                storage.Drawings.Where(x => x.ParentId == oldId).Map(x => x.ParentId = drawing.Id);
            }
        }

        public SiemensProject LoadStructureSiemens(string pathFolder, ILogging logging)
        {
            var filesNameGetter = new SiemensXmlDataFilesNameGetter { LocationDirectory = pathFolder };

            var docFilesGetter = new SiemensDocsFilesNameGetter { LocationDirectory = pathFolder };

            var filesArticlesFactory = new FilesArticlesFactory(filesNameGetter);
            var siemensProjectLoader = new SiemensProjectLoader(filesArticlesFactory, logging, docFilesGetter);

            return siemensProjectLoader.LoadStructureProject();
        }

        public TempDrawingsStorage ConvertSiemensToDrawings(SiemensProject project, ILogging logger)
        {
            var converter = new ConverterSiemensProject(logger);
            MaterialParser parser = new MaterialParser();
            ProjectExcluder excluder = new ProjectExcluder();
            NameMatSearcherStubber searcher = new NameMatSearcherStubber();
            FieldsNormalizer normalizer = new FieldsNormalizer();
            converter.ExcluderProject = excluder;
            converter.Log = logger;
            converter.MaterialParser = parser;
            converter.NameMaterialSearch = searcher;
            converter.Normalizer = normalizer;

            return converter.ConvertSiemensProjectToDomainModel(project);
        }


        private class NameMatSearcherStubber : INameMaterialSearch
        {
            public string GetNameMaterialByGost(string gost)
            {
                return string.Empty;
            }
        }

        public bool ShowDialog()
        {
            ImportDrawingsForm form = new ImportDrawingsForm(this);
            return form.ShowDialog() == DialogResult.OK;
        }
    }
}