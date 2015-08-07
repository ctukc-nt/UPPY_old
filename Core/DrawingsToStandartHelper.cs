using System.Collections.Generic;
using System.Linq;
using Core.DomainModel;
using Core.Interfaces;

namespace Core
{
    public class DrawingsToStandartHelper
    {

        private double _density = 7.85;

        /// <summary>
        /// Плотность
        /// </summary>
        public double Density
        {
            get { return _density; }
            set { _density = value; }
        }

        public bool CreateStandartByDrawing(Drawing headDrawing, IHierClassDataManager<Drawing> dataManager )
        {
            var allChildrens = dataManager.GetListAllChildrens(headDrawing.Id);
            var allParentId = allChildrens.Select(x => x.ParentId);
            var allDetails = allChildrens.Where(x => allParentId.Any(y => y.HasValue && y.Value == x.Id));

        }

        //public bool CreateStandartByDrawing(Drawing headDrawing, List<Drawing> drawings)
        //{

        //}
    }
}