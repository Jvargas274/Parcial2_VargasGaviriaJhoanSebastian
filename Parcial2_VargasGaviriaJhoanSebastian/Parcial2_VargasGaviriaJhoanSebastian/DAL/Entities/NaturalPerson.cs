using System.ComponentModel.DataAnnotations;

namespace Parcial2_VargasGaviriaJhoanSebastian.DAL.Entities
{
    public class NaturalPerson : Entity
    {
        #region
        [Display(Name = "Nombre Completo")]
        [Required(ErrorMessage = "El campo {0} es requerido!")]
        public string FullName { get; set; }

        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El campo {0} es requerido!")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Año de Nacimiento")]
        [Required(ErrorMessage = "El campo {0} es requerido!")]
        public int BirthYear { get; set; }

        [Display(Name = "Edad")]
        public int Age { get; set; }
        #endregion
    }
}
