using MCFBackend.Models;
using MCFBackend.Services;
using System.Collections.Generic;
using System.Web.Http;

namespace MCFBackend.Controllers
{
    public class StorageLocationController : ApiController
    {
        StorageLocationService Service = new StorageLocationService();

        [HttpGet]
        [Route("storagelocation/get-all")]
        public IHttpActionResult GetAll()
        {
            var result = this.Service.GetAll();
            return Ok(result);
        }
    }
}
