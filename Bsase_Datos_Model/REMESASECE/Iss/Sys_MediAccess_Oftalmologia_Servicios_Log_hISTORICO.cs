namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO
    {
        [StringLength(20)]
        public string codAfiliado { get; set; }

        public int? codEmpresa { get; set; }

        public int? idConcepto { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        public DateTime? FechaServicio { get; set; }

        public bool? CrecimientoOseo { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Monto { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FechaMovimiento { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(62)]
        public string Observaciones { get; set; }
    }
}
