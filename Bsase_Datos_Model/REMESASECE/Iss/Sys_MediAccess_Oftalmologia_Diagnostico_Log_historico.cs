namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico
    {
        [StringLength(20)]
        public string codAfiliado { get; set; }

        public int? codEmpresa { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(5)]
        public string MioIzq { get; set; }

        [StringLength(5)]
        public string MioDer { get; set; }

        [StringLength(5)]
        public string Hipizq { get; set; }

        [StringLength(5)]
        public string HipDer { get; set; }

        [StringLength(5)]
        public string AstIz { get; set; }

        [StringLength(5)]
        public string AstDer { get; set; }

        [StringLength(5)]
        public string EjeIzq { get; set; }

        [StringLength(5)]
        public string EjeDer { get; set; }

        [StringLength(5)]
        public string AdiIzq { get; set; }

        [StringLength(5)]
        public string AdiDer { get; set; }

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
