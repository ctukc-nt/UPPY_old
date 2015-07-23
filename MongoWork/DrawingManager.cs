using Core;
using MongoDB.Driver;

namespace MongoWork
{
    /// <summary>
    ///     Менеджер логики чертежей
    /// </summary>
    public class DrawingManager
    {
        private readonly DrawingDataManager _data;

        public DrawingManager(DrawingDataManager dataManager)
        {
            _data = dataManager;
        }

        public Drawing CreateDrawing()
        {
            return new Drawing();
        }

        public Drawing CreateDrawingWithId()
        {
            var drawing = new Drawing();
            _data.InsertOrUpdate(drawing);

            return drawing;
        }

        public Drawing SaveDrawing(Drawing drawing)
        {
            _data.InsertOrUpdate(drawing);
            return drawing;
        }

        public void DeleteDrawing(Drawing drawing)
        {
            _data.Delete(drawing);
        }

        public void DeleteDrawingWithChildren(Drawing drawing)
        {
            if (drawing == null || drawing.Id == null)
                return;

            var list = _data.GetCollection();
            var childrens = list.Find(x => x.ParentId == drawing.Id).ToListAsync().Result;
            if (childrens != null && childrens.Count > 0)
            {
                foreach (var children in childrens)
                {
                    DeleteDrawingWithChildren(children);
                }
            }

            _data.Delete(drawing);
        }
    }
}