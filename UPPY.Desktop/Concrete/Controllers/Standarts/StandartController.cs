using Core.DomainModel;
using UPPY.Desktop.Interfaces.Controllers.Standarts;

namespace UPPY.Desktop.Concrete.Controllers.Standarts
{
    public class StandartController : IStandartController
    {
        public Standart Standart { get; set; }
    }
}