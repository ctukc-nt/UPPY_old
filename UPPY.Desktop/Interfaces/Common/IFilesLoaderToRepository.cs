using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Common
{
    public interface IFilesLoaderToRepository
    {
        void LoadFilesFromDrawingsAndConvertPath(Drawing drawing, bool drawingIsParent);
    }
}