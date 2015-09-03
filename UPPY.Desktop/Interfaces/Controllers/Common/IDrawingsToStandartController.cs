using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IDrawingsToStandartController
    {
        Standart CreateAndGroupPositionsStandartByDrawing(Drawing drawing);

        Standart CreateStandartByDrawing(Drawing drawing);

        Standart GroupPositionsStandart(Standart standart);

        void Save(Standart standart);
    }
}