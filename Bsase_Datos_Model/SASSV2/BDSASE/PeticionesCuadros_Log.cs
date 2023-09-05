namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PeticionesCuadros_Log
    {
        [StringLength(255)]
        public string EAN { get; set; }

        [Column("NOMBRE COMERCIAL")]
        [StringLength(255)]
        public string NOMBRE_COMERCIAL { get; set; }

        [StringLength(255)]
        public string Laboratorio { get; set; }

        [Column("Principio(s) Activo(s)")]
        [StringLength(255)]
        public string Principio_s__Activo_s_ { get; set; }

        [Column("Forma Farmacéutica")]
        [StringLength(255)]
        public string Forma_Farmacéutica { get; set; }

        [Column("Vía de Admon")]
        [StringLength(255)]
        public string Vía_de_Admon { get; set; }

        [StringLength(255)]
        public string Unidad { get; set; }

        [Column("Piezas por Unidad")]
        [StringLength(255)]
        public string Piezas_por_Unidad { get; set; }

        [StringLength(255)]
        public string Concentración { get; set; }

        [StringLength(255)]
        public string UDM { get; set; }

        [Column(TypeName = "money")]
        public decimal? PMP { get; set; }

        [StringLength(255)]
        public string OXXO { get; set; }

        [StringLength(255)]
        public string KENWORTH { get; set; }

        [StringLength(255)]
        public string MAC { get; set; }

        [StringLength(255)]
        public string PAM { get; set; }

        [StringLength(255)]
        public string cveoxxo { get; set; }

        [StringLength(255)]
        public string cveKENWORTH { get; set; }

        [StringLength(255)]
        public string cveMac { get; set; }

        [StringLength(255)]
        public string cveGoodrich { get; set; }

        [StringLength(255)]
        public string cvePam { get; set; }

        [Key]
        [Column(Order = 0)]
        public DateTime FECHAPETICION { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FECHAPROCESO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(22)]
        public string NOMBREARCHIVO { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(56)]
        public string Tablapaso { get; set; }
    }
}
