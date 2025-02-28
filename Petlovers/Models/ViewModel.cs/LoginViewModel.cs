using System.ComponentModel.DataAnnotations;

namespace Petlovers.Models.ViewModel.cs
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Documento")]
        public required string Doc { get; set; }

        [Required]
        [Display(Name = "Contraseña")]
        public required string Clave { get; set; }


    }
}
