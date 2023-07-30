using System.ComponentModel.DataAnnotations;

namespace BindingandValidation.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Your FullName is Required")]
        public string FullName { get; set; }


        [Required(ErrorMessage = "Your FullName is Required")]
        public string Address { get; set; }

       
        [StringLength(10)]
        public int PhoneNumber { get; set; }

        [StringLength(12)]
        public int CitizenshipNo { get; set; }

    }
}
