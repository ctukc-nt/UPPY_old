using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IDrawingsToStandartController
    {

        Drawing Drawing { get; set; }

        Standart CreateAndGroupPositionsStandartByDrawing();

        Standart CreateStandartByDrawing();

        Standart GroupPositionsStandart(Standart standart);

        void Save(Standart standart);
    }
}