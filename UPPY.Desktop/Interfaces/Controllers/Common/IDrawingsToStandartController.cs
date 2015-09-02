using Core.DomainModel;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface IDrawingsToStandartController
    {
        Standart CreateStandartByDrawing(Drawing drawing);

        void Save(Standart standart);
    }
}