namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Transferencias_TB_Cargo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Cuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string cve_empresa { get; set; }

        public bool estatus { get; set; }
    }
}
