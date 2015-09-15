using System.Collections.Generic;
using System.IO;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class SimpleFilesLoaderToRepository : IFilesLoaderToRepository
    {
        private readonly IFilesRepository _filesRepository;

        public SimpleFilesLoaderToRepository(IFilesRepository filesRepository)
        {
            _filesRepository = filesRepository;
        }

        public void LoadFilesFromDrawingsAndConvertPath(Drawing drawing, bool drawingIsParent)
        {
            foreach (var uppyFileInfo in drawing.Files)
            {
                if (File.Exists(uppyFileInfo.FileName))
                {
                    // rename file name
                    var fileInfo = _filesRepository.PutFile(uppyFileInfo.FileName);
                    uppyFileInfo.FileName = fileInfo.FileName;
                }
            }
        }

        public void LoadFilesFromDrawingsAndConvertPath(IEnumerable<Drawing> drawings)
        {
            var enumDraws = drawings as IList<Drawing> ?? drawings.ToList();

            foreach (var drawing in enumDraws)
            {
                LoadFilesFromDrawingsAndConvertPath(drawing, enumDraws.Any(x => x.ParentId == drawing.Id));
            }
        }

    }
}