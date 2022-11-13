using MCFBackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MCFBackend.Services
{
    public class StorageLocationService
    {
        public async Task<List<StorageLocationModel>> GetAll()
        {
            var context = new MCFDbContext();
            List<StorageLocationModel> result = new List<StorageLocationModel>();
            var datas = context.ms_storage_location.ToList();
            if (datas != null && datas.Count > 0)
            {
                foreach (var data in datas)
                {
                    StorageLocationModel newSL = new StorageLocationModel()
                    {
                        LocationId = data.location_id,
                        LocationName = data.location_name
                    };

                    result.Add(newSL);
                }
            }
            return result;
        }
    }
}