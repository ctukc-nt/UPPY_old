namespace UPPY.Desktop.Interfaces.Common
{
    public interface IDataImportToolsFactory
    {
        IMaterialParser GetMaterialParser();
        IProjectExcluder GetProjectExcluder();
        INameMaterialSearch GetNameMaterialSearch();
        IFieldsNormalizer GetFieldsNormalizer();

    }
}