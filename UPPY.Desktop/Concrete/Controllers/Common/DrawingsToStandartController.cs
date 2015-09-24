using Core;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Controllers.Common;
using UPPY.Desktop.Views.Standarts;
using Utils.Common;

namespace UPPY.Desktop.Concrete.Controllers.Common
{
    public class DrawingsToStandartController : IDrawingsToStandartController, IDrawingsToStandartShower
    {
        private readonly IUppyDataManagersFactory _dataManagersFactory;
        private Drawing _drawing;

        public DrawingsToStandartController(IUppyDataManagersFactory dataManagersFactory, Drawing drawing)
        {
            _dataManagersFactory = dataManagersFactory;
            _drawing = drawing;
        }

        public DrawingsToStandartController(IUppyDataManagersFactory dataManagersFactory)
        {
            _dataManagersFactory = dataManagersFactory;
        }

        public Standart CreateAndGroupPositionsStandartByDrawing()
        {
            var helper = new DrawingsToStandartHelper();
            var hierDataManager = _dataManagersFactory.GetDrawingsHierClassDataManager();
            var gmGost = _dataManagersFactory.GetDataManager<Gost>();
            var standart = helper.CreateStandartByDrawing(_drawing, hierDataManager, gmGost.GetListCollection());
            standart = helper.GroupAndSumPositionsStandart(standart);
            return standart;
        }

        public Standart CreateStandartByDrawing()
        {
            return CreateStandartByDrawing(null);
        }

        public Standart CreateStandartByDrawing(ILogging log)
        {
            var helper = new DrawingsToStandartHelper();
            var hierDataManager = _dataManagersFactory.GetDrawingsHierClassDataManager();
            var gmGost = _dataManagersFactory.GetDataManager<Gost>();
            helper.Log = log;
            var standart = helper.CreateStandartByDrawing(_drawing, hierDataManager, gmGost.GetListCollection());
            return standart;
        }

        public Drawing Drawing { get { return _drawing; } set { _drawing = value; } }

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

        public void ShowView(Drawing drawing)
        {
            _drawing = drawing;
            var form = new DrawingToStandartForm(this);
            form.ShowDialog();
        }
    }
}