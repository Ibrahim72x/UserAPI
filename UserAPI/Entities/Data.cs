using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserAPI.Entities
{
    public class Data
    {
        [Key]
        public int Id { get; set; }
        public int Phone { get; set; }
        public int NationalId { get; set; }
        public int Password { get; set; }
        public int IsActive { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Gender { get; set; }
        public string Path { get; set; }









    }
}
