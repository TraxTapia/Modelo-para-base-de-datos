namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("procedimientOdontologico")]
    public partial class procedimientOdontologico
    {
        [Key]
        public int procedimientoID { get; set; }

        [Required]
        [StringLength(50)]
        public string folio { get; set; }

        [Required]
        [StringLength(20)]
        public string CPT { get; set; }

        public int numero { get; set; }

        public virtual bandejaDentalCuadrante bandejaDentalCuadrante { get; set; }

        public virtual CPT CPT1 { get; set; }
    }
}
