namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CopagoECEvsPurchaserplan")]
    public partial class CopagoECEvsPurchaserplan
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Descripcion { get; set; }

        public int? Copago { get; set; }

        [StringLength(45)]
        public string Purchaserplan { get; set; }
    }
}
