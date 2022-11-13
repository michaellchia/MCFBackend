using MCFBackend.Models;
using MCFBackend.Services;
using System.Web.Http;

namespace MCFBackend.Controllers
{
    public class AgreementController : ApiController
    {
        AgreementService Service = new AgreementService();

        [HttpPost]
        [Route("agreement/create")]
        public IHttpActionResult Create([FromBody]PostAgreementRequest request)
        {
            var result = this.Service.Create(request).Result;
            if(result.IsSuccess)
            {
                return Ok(new ResponseBase
                {
                    Code = 200,
                    Message = result.MessageText
                });
            }

            return BadRequest(result.MessageText);
        }
    }
}
