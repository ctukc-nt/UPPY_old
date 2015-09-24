using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Factorys
{
    public class ToolsFactory:IDataImportToolsFactory
    {
        private readonly IDataManagersFactory _dataManagersFactory;

        public ToolsFactory(IDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }

        public IMaterialParser GetMaterialParser()
        {
            return new MaterialParser();
        }

        public IProjectExcluder GetProjectExcluder()
        {
            return new ProjectExcluder();
        }

        public INameMaterialSearch GetNameMaterialSearch()
        {
            return new NameMaterialSearch(_dataManagersFactory.GetDataManager<Gost>());
        }

        public IFieldsNormalizer GetFieldsNormalizer()
        {
            return new FieldsNormalizer();
        }
    }
}