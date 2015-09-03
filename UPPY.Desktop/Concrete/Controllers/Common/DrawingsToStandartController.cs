using Core;
using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Interfaces.DataManagers;

namespace UPPY.Desktop.Concrete.Controllers.Common
{
    public class DrawingsToStandartController : IDrawingsToStandartController
    {
        private readonly IUppyDataManagersFactory _dataManagersFactory;

        public DrawingsToStandartController(IUppyDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }

        public Standart CreateAndGroupPositionsStandartByDrawing(Drawing drawing)
        {
            var helper = new DrawingsToStandartHelper();
            var hierDataManager = _dataManagersFactory.GetDrawingsHierClassDataManager();
            var gmGost = _dataManagersFactory.GetDataManager<Gost>();
            var standart = helper.CreateStandartByDrawing(drawing, hierDataManager, gmGost.GetListCollection());
            standart = helper.GroupAndSumPositionsStandart(standart);
            return standart;
        }

        public Standart CreateStandartByDrawing(Drawing drawing)
        {
            var helper = new DrawingsToStandartHelper();
            var hierDataManager = _dataManagersFactory.GetDrawingsHierClassDataManager();
            var gmGost = _dataManagersFactory.GetDataManager<Gost>();
            var standart = helper.CreateStandartByDrawing(drawing, hierDataManager, gmGost.GetListCollection());
            return standart;
        }

        public Standart GroupPositionsStandart(Standart standart)
        {
            var helper = new DrawingsToStandartHelper();
            standart = helper.GroupAndSumPositionsStandart(standart);
            return standart;
        }

        public void Save(Standart standart)
        {
            _dataManagersFactory.GetDataManager<Standart>().InsertOrUpdate(standart);
        }
    }
}