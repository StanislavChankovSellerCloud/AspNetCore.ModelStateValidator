using AspNetCore.ModelStateValidator.WebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.ModelStateValidator.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroesController : ControllerBase
    {
        // Regardless of the HttpVerb - HttpPost, HttpPut, HttpPatch we are encountering the same behavior.

        [HttpPost]
        public IActionResult Request([FromBody] HeroRequest request)
        {
            // http://localhost:5000/heroes
            // request = { };
            // "MainWeapon" - Valid - Unexpected
            return Ok();
        }

        [HttpPost("1")]
        public IActionResult Request1([FromBody] HeroRequest1 request)
        {
            // http://localhost:5000/heroes/1
            // request = { "SpecificEquipment": { "Name": "" } };
            // "SpecificEquipment" - "Valid"    -   Expected
            // "MainWeapon"        - "Invalid"  -   Unexpected
            // "MainEquipment"     - "Invalid"  -   Unexpected
            return Ok(ModelState.Values);
        }

        [HttpPost("2")]
        public IActionResult Request2([FromBody] HeroRequest2 request)
        {
            // http://localhost:5000/heroes/2
            // request = { "SpecificEquipment": { "Name": "" } };
            // "MainWeapon"         - "Valid"    -  Unexpected
            // "Accessory"          - "Invalid"  -  Expected
            return Ok(ModelState.Values);
        }

        // 
        [HttpPost("3")]
        public IActionResult Request3([FromBody] HeroRequest3 request)
        {
            // http://localhost:5000/heroes/3
            // request = { "SpecificEquipment": { "Name": "" } };
            // "MainWeapon"         - "Invalid"    -    Expected
            // "Accessory"          - "Valid"       -   Expected
            // BUT...
            // Removing "Accessory" property will cause to "MainWeapon" property to NOT be validated.
            // Having "Accessory" property will cause "MainWeapon" to be validated
            return Ok(ModelState.Values);
        }
    }
}
