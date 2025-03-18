using System.Reflection.Metadata.Ecma335;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Al_Ahsas_Foundation.Models
{
    public class Case_Donation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter the name ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the PhoneNumber")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter the CNIC")]
        public string CNIC { get; set; }

        [Required(ErrorMessage = "Please enter the Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter the CaseNumber")]
        public string CaseNumber { get; set; }

        [Required(ErrorMessage = "Please enter Recipt")]
        public string Recipt { get; set; }

        [NotMapped]
        public IFormFile UploadRecipt { get; set; }
    }
}
