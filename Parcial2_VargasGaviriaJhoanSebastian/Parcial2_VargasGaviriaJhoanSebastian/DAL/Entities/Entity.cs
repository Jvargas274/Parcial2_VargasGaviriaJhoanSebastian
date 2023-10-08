using System.ComponentModel.DataAnnotations;

namespace Parcial2_VargasGaviriaJhoanSebastian.DAL.Entities
{
    public class Entity
    {
        #region
        [Key]
        public virtual Guid id { get; set; }

        [Display(Name = "Fecha de creacion")]
        public virtual DateTime? CreatedDate { get; set; }
        
        [Display(Name = "Ultima modificacion")]
        public virtual DateTime? ModifiedDate { get; set; }
        #endregion
    }
}