using System.Collections.Generic; 
using Microsoft.AspNetCore.Mvc; 

namespace SimpleDevOpsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ValuesController : ControllerBase
    { 

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {"Value1", "Value2"};
        }

        [HttpGet]
        public string Get(int id)
        {
            return "Tariq Iqbal";
        }
    }
}
