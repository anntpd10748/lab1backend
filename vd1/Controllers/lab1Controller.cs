using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vd1.Models;

namespace vd1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class lab1Controller : ControllerBase
    {
        public IActionResult Get()
        {
            Game106Model game106 = new Game106Model
            {
                CourseName = "Back-End Game Programming",
                CourseCode = "gam106",
                Name = "nguyen thanh an",
                StudentCode = "pd10748",
                ClassName = "GA19301"
            };
            int status = 1;
            string mesaage = "Get data sucess!";
            var data = new {status, mesaage, game106};
            return new JsonResult(data);
        }
    }
}
