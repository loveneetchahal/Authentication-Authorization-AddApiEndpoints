using Authentication_Authorization_AddApiEndpoints.Dtos;
using Authentication_Authorization_AddApiEndpoints.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Authentication_Authorization_AddApiEndpoints.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        public ValuesController()
        {
        }
        [HttpGet]
        [Authorize]
        public IActionResult GetValues()
        {
            try
            {
                var timeZones = CommonFunctions.GetTimeZoneList();
                return Ok(new ResultDto { status = false, StatusCode = StatusCodes.Status200OK, Message = "Timezone list found successfully", data = timeZones });
            }
            catch (Exception ex)
            {
                return Ok(new ResultDto { status = false, StatusCode = StatusCodes.Status500InternalServerError, Message = "Something went wrong while adding learner to path. " + ex.Message, data = null });
            }
        }
    }
}
