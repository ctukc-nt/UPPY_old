using UPPY.Desktop.Classes;
using UPPY.Desktop.Views.Drawings;
using UPPY.DIE.Import.Siemens;
using UPPY.DIE.Import.Siemens.Interfaces;

namespace UPPY.Desktop.Interfaces.Controllers.Common
{
    public interface ISiemensDataImportController
    {
        void SaveDrawingsToDataBase(TempDrawingsStorage storage);
        SiemensProject LoadStructureSiemens(string pathFolder, ILogging logging);
        TempDrawingsStorage ConvertSiemensToDrawings(SiemensProject project, ILogging logger);
    }
}