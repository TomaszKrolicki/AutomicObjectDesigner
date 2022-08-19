using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AutomicObjectDesignerBack.Controllers.ObjectContollers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SapSimpleController : ControllerBase
    {
        [HttpGet]
        //GET https://localhost:7017/api/SapSimple
        // pobranie danych uzytkownika + validacja
        public IActionResult GetSapSimple()
        {
            var SapSimple = DataService.Current.SapSimple;

            return Ok(SapSimple);


        }
    }
}
