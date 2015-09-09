using System.Linq;
using Core.DomainModel;
using Core.Interfaces;
using UPPY.Desktop.Interfaces.Common;

namespace UPPY.Desktop.Classes
{
    public class NameMaterialSearch : INameMaterialSearch
    {
        private readonly IClassDataManager<Gost> _gostDataManager;

        public NameMaterialSearch(IClassDataManager<Gost> gostDataManager)
        {
            _gostDataManager = gostDataManager;
        }

        public string GetNameMaterialByGost(string gost)
        {
            var material =
                _gostDataManager.GetListCollection(x=>x.Name.ToLower().Trim() == gost.ToLower().Trim()).FirstOrDefault();

            return material != null ? material.Profile : string.Empty;
        }
    }
}