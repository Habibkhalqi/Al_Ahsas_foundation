using System.ComponentModel.DataAnnotations;

namespace Al_Ahsas_Foundation.Models
{
    public class Req_For_Donation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Your Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please Enter Your Message")]
        public string Message { get; set; }

    }

}
