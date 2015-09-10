using System;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Common;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Views.Drawings;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.Desktop.Concrete.Controllers.Common
{
    public class SiemensDataImportController : ISiemensDataImportController
    {
        public void SaveDrawingsToDataBase(TempDrawingsStorage storage)
        {
            throw new System.NotImplementedException();
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
                return String.Empty;
            }
        }

    }
}