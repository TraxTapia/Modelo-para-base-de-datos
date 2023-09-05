namespace Bsase_Datos_Model.REMESASECE.Mediaccess
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

        public virtual Cuenta Cuenta { get; set; }

        public virtual Cuenta Cuenta1 { get; set; }
    }
}
