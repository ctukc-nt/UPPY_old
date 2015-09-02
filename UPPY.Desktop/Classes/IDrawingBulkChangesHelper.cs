using Core.DomainModel;

namespace UPPY.Desktop.Classes
{
    public interface IDrawingBulkChangesHelper
    {
        void RecalculateProjectByWeight(Drawing drawing);
        void RecalculateProjectByCount(Drawing drawing);
    }
}