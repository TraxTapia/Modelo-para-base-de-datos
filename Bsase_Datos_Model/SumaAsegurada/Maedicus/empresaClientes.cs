namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class empresaClientes
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codcliente { get; set; }

        [StringLength(50)]
        public string Cliente { get; set; }
    }
}
