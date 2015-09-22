using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.DomainModel;
using Core.Interfaces;
using Ninject.Infrastructure.Language;
using UPPY.Desktop.Classes;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Concrete.Controllers.Common
{
    public class SiemensDataAndFilesImportController : SiemensDataImportController
    {
        private readonly IFilesLoaderToRepository _loaderToRepository;
        private TaskFactory _factory = new TaskFactory();

        public SiemensDataAndFilesImportController(IClassDataManager<Drawing> drawingsDataManager, IFilesLoaderToRepository loaderToRepository) : base(drawingsDataManager)
        {
            _loaderToRepository = loaderToRepository;
        }

        public SiemensDataAndFilesImportController(IClassDataManager<Drawing> drawingsDataManager, IFilesLoaderToRepository loaderToRepository, int? parentId) : base(drawingsDataManager, parentId)
        {
            _loaderToRepository = loaderToRepository;
        }


        public override void SaveDrawingsToDataBase(TempDrawingsStorage storage)
        {
            storage.Drawings.Where(x => x.ParentId == null).Map(x => x.ParentId = ParentId);
            var drawingsList = storage.Drawings.ToList();
            var taskList = new List<Task>();

            foreach (var drawing in storage.Drawings.OrderBy(x => x.Id))
            {
                var oldId = drawing.Id;
                drawing.Id = null;
                DrawingsDataManager.Insert(drawing);

                storage.Drawings.Where(x => x.ParentId == oldId).Map(x => x.ParentId = drawing.Id);
                //taskList.Add(_factory.StartNew(() =>
                //{
                LoadFiles(drawing, drawingsList);
                DrawingsDataManager.Update(drawing);
                //}));
            }

            //Task.WaitAll(taskList.ToArray());
        }

        private void LoadFiles(Drawing drawing, List<Drawing> drawings)
        {
            if (_loaderToRepository != null)
            {
                _loaderToRepository.LoadFilesFromDrawingsAndConvertPath(drawing, drawings.Any(x => x.ParentId == drawing.Id));
            }
        }


    }
}