using Microsoft.AspNetCore.Mvc;
using UserAPI.Entities;

namespace UserAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
        {
             public static IWebHostEnvironment _webHostEnvironment;
        public ImageController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;

        }



        [HttpPost]
        public async Task<string> Post([FromForm] Image data)
        {
            try
            {
                if (data.files.Length > 0)
                {
                    string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    using (FileStream fileStream = System.IO.File.Create(path + data.files.FileName))
                    {


                        data.files.CopyTo(fileStream);
                        fileStream.Flush();
                        return (path + data.files.FileName);
                    }

                }
                else
                {
                    return "failed.";
                }





            }
            catch (Exception ex)
            {

                return ex.Message;
            }


        }
        [HttpGet("{fileName}")]
        public async Task<IActionResult> Get([FromRoute] string fileName)
        {
            string path = _webHostEnvironment.WebRootPath + "\\uploads\\";
            var filePath = path + fileName + ".jpg";
            if (System.IO.File.Exists(filePath))
            {
                byte[] b = System.IO.File.ReadAllBytes(filePath);
                return File(b, "image/jpg");
            }
            return null;
        }
    }
    }

