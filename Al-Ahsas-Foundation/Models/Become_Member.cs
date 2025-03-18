using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace Al_Ahsas_Foundation.Models
{
    public class Become_Member
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Please enter Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter Father Name")]
        public string FatherName { get; set; }

        [Required(ErrorMessage = "Please enter Gender")]
        public string  Gender { get; set; }

        [Required(ErrorMessage = "Please enter DOB")]
        public string DOB { get; set; }

        [Required(ErrorMessage = "Please enter CNIC")]
        public string  CNIC { get; set; }

        [Required(ErrorMessage = "Please enter Image")]
        public string  ImageName { get; set; }

        [NotMapped]
        public IFormFile UploadedPicture { get; set; }

        [Required(ErrorMessage = "Please enter Phone Number")]
        public string PhoneNumber  { get; set; }

        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter Address")]
        public string  Address { get; set; }

        [Required(ErrorMessage = "Please enter Postal Code")]
        public string  MembershipType { get; set; }

        [Required(ErrorMessage = "Please enter Join Date")]
        public string JoinDate { get; set; }

        [Required(ErrorMessage = "Please enter Membership Type")]
        public string VolueeterArea { get; set; }
    }
}
