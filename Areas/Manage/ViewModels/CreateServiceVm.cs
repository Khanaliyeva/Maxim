using System.ComponentModel.DataAnnotations;

namespace Maxim.Areas.Manage.ViewModels
{
    public class CreateServiceVm
    {
        [Required]
        [MinLength(8)]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(40)]
        public string Description { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(40)]
        public string Icon { get; set; }
    }
}
