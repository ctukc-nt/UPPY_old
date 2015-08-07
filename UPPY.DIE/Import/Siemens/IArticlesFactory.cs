namespace UPPY.DIE.Import.Siemens
{
    /// <summary>
    /// Фабрика получения классов Article
    /// </summary>
    public interface IArticlesFactory
    {
        Article GetArticle(string drawingName);
        Article GetFirstArticle();
    }
}
