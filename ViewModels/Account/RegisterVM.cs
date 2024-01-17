using System.ComponentModel.DataAnnotations;

namespace Maxim.ViewModels.Account
{
    public class RegisterVM
    {
        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }


        [Required]
        [MinLength(6)]
        [MaxLength(25)]
        public string Surname { get; set; }


        [Required]
        [MinLength(8)]
        [MaxLength(20)]
        public string UserName { get; set; }


        [Required]
        [MinLength(10)]
        [MaxLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPssword { get; set; }

    }
}
