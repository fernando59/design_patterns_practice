using Design_Patterns.AdapterExample;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Design_Patterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdapterController : ControllerBase
    {

        [HttpGet]
        public IActionResult AdapterPattern()
        {
            Adapter converter = new Adapter();

            converter.enterPesetas(1000);
            converter.enterPesetas(1000);
            converter.enterPesetas(1000);



            string text = $"Total Euros : {converter.getBalance()}";
            return Ok(text);

        }
    }
}
