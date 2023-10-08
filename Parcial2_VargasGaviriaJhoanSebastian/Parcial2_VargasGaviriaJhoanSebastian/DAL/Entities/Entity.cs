﻿using System.ComponentModel.DataAnnotations;

namespace Parcial2_VargasGaviriaJhoanSebastian.DAL.Entities
{
    public class Entity
    {
        #region
        [Key]
        public virtual Guid id { get; set; }
        public virtual DateTime? CreatedDate { get; set; }
        public virtual DateTime? ModifiedDate { get; set; }
        #endregion

    }
}