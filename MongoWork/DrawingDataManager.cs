using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;
using MongoDB.Driver;

namespace MongoWork
{
    class DrawingDataManager : MongoDbDataManager<Drawing>
    {
        public DrawingDataManager(IMongoDatabase db)
            : base(db)
        {

        }

        public async Task<TechRoute> GetRouteAsync(Drawing drawing)
        {
            
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
