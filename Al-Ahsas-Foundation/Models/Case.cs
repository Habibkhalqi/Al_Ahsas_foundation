using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace Al_Ahsas_Foundation.Models
{
    public class Case
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the title of the case")]
        public string  Title { get; set; }

        [Required(ErrorMessage = "Please enter the description of the case")]
        public string  Description { get; set; }

        [Required(ErrorMessage = "Please enter the amount of the case")]
        public string Amount { get; set; }

        [Required(ErrorMessage = "Please enter the category of the case")]
        public string Category { get; set; }

        [Required(ErrorMessage = "Please enter the details of the case")]
        public string Details { get; set; }

        [Required(ErrorMessage = "Please enter the image of the case")]
        public string  Vedio { get; set; }

        [Required(ErrorMessage = "Please enter the image of the case")]
        public Cause Cause { get; set; }

    }
}
