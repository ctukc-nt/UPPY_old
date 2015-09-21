using UPPY.Desktop.Classes;
using UPPY.DIE.Import.Siemens;
using Utils.Common;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface ISiemensDataImportController
    {
        void SaveDrawingsToDataBase(TempDrawingsStorage storage);
        SiemensProject LoadStructureSiemens(string pathFolder, ILogging logging);
        TempDrawingsStorage ConvertSiemensToDrawings(SiemensProject project, ILogging logger);
    }
}