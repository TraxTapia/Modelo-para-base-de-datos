namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicinePreventiveInfonavit")]
    public partial class MedicinePreventiveInfonavit
    {
        public int Id { get; set; }

        public int GenericCodeProvider { get; set; }

        public int CodeProvider { get; set; }

        public bool Active { get; set; }

        [StringLength(50)]
        public string User { get; set; }

        [StringLength(50)]
        public string UserDisabled { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateDisabled { get; set; }

        public virtual Cuenta Cuenta { get; set; }

        public virtual Cuenta Cuenta1 { get; set; }
    }
}
