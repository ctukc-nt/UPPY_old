using Core.DomainModel;
using Utils.Common;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IDrawingsToStandartController
    {
        Drawing Drawing { get; set; }

        Standart CreateAndGroupPositionsStandartByDrawing();

        Standart CreateStandartByDrawing();

        Standart CreateStandartByDrawing(ILogging log);

        Standart GroupPositionsStandart(Standart standart);

        void Save(Standart standart);
    }
}