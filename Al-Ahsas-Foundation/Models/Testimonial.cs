using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Al_Ahsas_Foundation.Models
{
    public class Testimonial
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Profession")]
        public string Profession { get; set; }

        [Required(ErrorMessage = "Please Enter Your Comment")]
        public string Comment { get; set; }

        [Required(ErrorMessage = "Please Enter Your Profile")]
        public string Profile { get; set; }

        [NotMapped]
        public IFormFile ProfileImage { get; set; }

    }
}
