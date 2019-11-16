using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TheCodeCamp.Data;

namespace TheCodeCamp.Controllers
{
    [Serializable]
    public class CampsController: ApiController
    {
        private readonly ICampRepository campRepository;

        public CampsController(ICampRepository campRepository)
        {
            this.campRepository = campRepository;
        }
        public async Task<IHttpActionResult>  Get()
        {
            try
            {
                //string s = Url.ToString();
                //return BadRequest("It wasn't really bad, I made it bad");
                //return Ok(new { Fname = "A", LName = "B", MName = "C"});
                var result = await campRepository.GetAllCampsAsync();
                return Ok(result);  
            }
            catch(Exception ex)
            {
                return InternalServerError();
            }
 
        }
    }
}
