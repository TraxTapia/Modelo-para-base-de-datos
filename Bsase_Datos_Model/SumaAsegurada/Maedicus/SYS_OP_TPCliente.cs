namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_OP_TPCliente
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codempresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoGasto { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string TipoProveedor { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public int? Rubro { get; set; }
    }
}
