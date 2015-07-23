using System;
using System.Threading.Tasks;
using Core;
using MongoDB.Driver;

namespace MongoWork
{
    /// <summary>
    /// Класс отвечающий за простые атомарные операции
    /// </summary>
    public class DrawingDataManager : MongoDbDataManager<Drawing>
    {
        public DrawingDataManager(IMongoDatabase db)
            : base(db)
        {
        }

        public async Task<TechRoute> GetRouteAsync(Drawing drawing)
        {
            if (drawing == null)
                throw new ArgumentNullException();

            if (drawing.TechRouteId == null)
                return null;

            var dataManager = new MongoDbDataManager<TechRoute>(_mongoDb);
            var wait = dataManager.GetDocumentAsync(drawing.TechRouteId);
            await wait;

            return wait.Result;
        }

        public Drawing GetParentDrawing(Drawing drawing)
        {
            return drawing == null ? null : GetDrawing(drawing.Id);
        }

        public async Task<Drawing> GetDrawingAsync(int? drawingId)
        {
            var wait = GetDocumentAsync(drawingId);
            await wait;

            return wait.Result;
        }

        public Drawing GetDrawing(int? drawingId)
        {
            var res = GetDrawingAsync(drawingId);
            res.Wait();

            return res.Result;
        }
    }
}