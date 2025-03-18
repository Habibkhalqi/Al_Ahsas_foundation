using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Al_Ahsas_Foundation.Models
{
    public class Cause
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter Icon")]
        public string Icon { get; set; }

        [NotMapped]
        public IFormFile UploadICON { get; set; }

        [Required(ErrorMessage = "Please enter CauseName")]
        public string CauseName { get; set; }

        [Required(ErrorMessage = "Please enter description")]
        public string  Description { get; set; }

        [Required(ErrorMessage = "Please enter slug")]
        public string Slug { get; set; }

        public ICollection<Case> Cases { get; set; }

    }
}
