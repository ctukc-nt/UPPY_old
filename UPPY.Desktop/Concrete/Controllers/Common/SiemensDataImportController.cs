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
using Utils.Common;

namespace UPPY.Desktop.Concrete.Controllers.Common
{
    public class SiemensDataImportController : ISiemensDataImportController, IUppyDataImport
    {
        protected readonly IClassDataManager<Drawing> DrawingsDataManager;
        private readonly IDataImportToolsFactory _dataImportToolsFactory;
        protected readonly int? ParentId;

        public SiemensDataImportController(IClassDataManager<Drawing> drawingsDataManager, IDataImportToolsFactory dataImportToolsFactory)
        {
            DrawingsDataManager = drawingsDataManager;
            _dataImportToolsFactory = dataImportToolsFactory;
        }

        public SiemensDataImportController(IClassDataManager<Drawing> drawingsDataManager, IDataImportToolsFactory dataImportToolsFactory,  int? parentId)
        {
            DrawingsDataManager = drawingsDataManager;
            _dataImportToolsFactory = dataImportToolsFactory;
            ParentId = parentId;
        }

        public virtual void SaveDrawingsToDataBase(TempDrawingsStorage storage)
        {
            storage.Drawings.Where(x => x.ParentId == null).Map(x => x.ParentId = ParentId);

            foreach (var drawing in storage.Drawings.OrderBy(x => x.Id))
            {
                var oldId = drawing.Id;
                drawing.Id = null;
                DrawingsDataManager.Insert(drawing);
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
            var parser = _dataImportToolsFactory.GetMaterialParser();
            var excluder = _dataImportToolsFactory.GetProjectExcluder();
            var searcher = _dataImportToolsFactory.GetNameMaterialSearch();
            var normalizer = _dataImportToolsFactory.GetFieldsNormalizer();
            converter.ExcluderProject = excluder;
            converter.Log = logger;
            converter.MaterialParser = parser;
            converter.NameMaterialSearch = searcher;
            converter.Normalizer = normalizer;

            return converter.ConvertSiemensProjectToDomainModel(project);
        }


        public bool ShowDialog()
        {
            ImportDrawingsForm form = new ImportDrawingsForm(this);
            return form.ShowDialog() == DialogResult.OK;
        }
    }
}