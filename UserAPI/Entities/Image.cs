using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAPI.Entities
{
    public class Image
    {

        [NotMapped] public IFormFile files { get; set; }
        


        

    }
}
