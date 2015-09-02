using System.Linq;
using Core.DomainModel;
using Core.Interfaces;

namespace Core
{
    public class DrawingsCalculateHelper
    {
        public void RecalculateProjectByWeight(Drawing drawing, IClassDataManager<Drawing> drawDataManager)
        {
            var childrens = drawDataManager.GetListCollection(x => x.ParentId == drawing.Id);
            if (childrens.Any())
            {
                var sum = childrens.Sum(x => x.WeightAll);
                drawing.WeightAll = sum;
                drawing.Weight = drawing.CountAll != 0 ? drawing.WeightAll / drawing.CountAll : 0;
            }
            else
            {
                drawing.RecalculateWeightAll();
            }

            drawDataManager.Update(drawing);

            if (drawing.ParentId != null)
            {
                var parentDrawing = drawDataManager.GetDocument(drawing.ParentId);
                if (parentDrawing != null)
                    RecalculateProjectByWeight(parentDrawing, drawDataManager);
            }
        }

        public void RecalculateProjectByCount(Drawing drawing, IClassDataManager<Drawing> drawDataManager)
        {
            var parentDraw = drawDataManager.GetDocument(drawing.ParentId);

            drawing.CountAll = drawing.Count * parentDraw?.CountAll ?? drawing.Count;

            var childrens = drawDataManager.GetListCollection(x => x.ParentId == drawing.Id);
            if (childrens.Any())
            {
                var sumWeight = 0.0;
                foreach (var children in childrens)
                {
                    RecalculateProjectByCount(children, drawDataManager);
                    sumWeight += children.WeightAll;
                }

                drawing.WeightAll = sumWeight;
                drawing.Weight = drawing.CountAll > 0 ? drawing.WeightAll / drawing.CountAll : 0;
            }
            else
            {
                RecalculateProjectByWeight(drawing, drawDataManager);
            }

            drawDataManager.Update(drawing);
        }
    }
}