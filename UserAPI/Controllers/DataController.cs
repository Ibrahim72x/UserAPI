using Microsoft.AspNetCore.Mvc;
using Microsoft.Web.Helpers;
using Microsoft.AspNetCore.Hosting;
using UserAPI.Entities;
using System.Security.Cryptography.X509Certificates;
using UserAPI.DB;

namespace UserAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class DataController : ControllerBase
    {
        private readonly UserDbContext _db;
        public DataController(UserDbContext db)
        {
            _db = db;
        }
        [HttpPost]
        public IActionResult Post([FromBody] Data data)
        {

            
            if (data == null)
            {
                return BadRequest();
            }
            _db.datas.Add(data);
            try
            {
                _db.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.ToString());
            }
        }
        [HttpGet]
        public IActionResult GetbyId([FromQuery] int id)
        {
            if (id == null) { return BadRequest(); }
            var school = _db.datas.Find(id);
            if (school == null) { return NotFound(); }
            return Ok(school);
        }



    }

}
