using System.ComponentModel.DataAnnotations;

namespace Maxim.ViewModels.Account
{
    public class LoginVM
    {
        [Required]
        [MinLength(8)]
        [MaxLength(30)]
        public string UserNameOrEmail { get; set; }


        [Required]
        [MinLength(6)]
        [MaxLength(15)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
