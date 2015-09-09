namespace UPPY.Desktop.Interfaces.Common
{
    public interface IFieldsNormalizer
    {
        string RemoveUnUseInfoAboutMarkSteal(string markSteal);
        string NormalizePositionNumber(string numberBySpec);
    }
}