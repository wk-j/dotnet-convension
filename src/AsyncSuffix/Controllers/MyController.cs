using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AsyncSubffix.Controllers {
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MyController : ControllerBase {

        [HttpGet]
        public async Task<ActionResult<string>> GetDataAsync() {
            var data = await Task.FromResult("Hello, world!");
            return Ok(data);
        }

        [HttpGet]
        public string A() {
            return "A";
        }
    }
}