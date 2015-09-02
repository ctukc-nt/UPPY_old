using Core;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.DataManagers;

namespace UPPY.Desktop.Classes
{
    public class DrawingBulkChangesHelper : IDrawingBulkChangesHelper
    {
        private readonly IUppyDataManagersFactory _dataDataManagersFactory;

        public DrawingBulkChangesHelper(IUppyDataManagersFactory dataDataManagersFactory)
        {
            _dataDataManagersFactory = dataDataManagersFactory;
        }

        public void RecalculateProjectByWeight(Drawing drawing)
        {
            DrawingsCalculateHelper drawingsCalculateHelper = new DrawingsCalculateHelper();
            drawingsCalculateHelper.RecalculateProjectByWeight(drawing, _dataDataManagersFactory.GetDataManager<Drawing>());
        }

        public void RecalculateProjectByCount(Drawing drawing)
        {
            DrawingsCalculateHelper drawingsCalculateHelper = new DrawingsCalculateHelper();
            drawingsCalculateHelper.RecalculateProjectByCount(drawing, _dataDataManagersFactory.GetDataManager<Drawing>());
        }
    }
}