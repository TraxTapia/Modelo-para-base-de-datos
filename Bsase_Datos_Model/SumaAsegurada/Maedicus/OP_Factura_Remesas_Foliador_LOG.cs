namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_Factura_Remesas_Foliador_LOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodEmp { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Año { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Contador { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string Remesa { get; set; }

        [Key]
        [Column(Order = 5, TypeName = "date")]
        public DateTime F_Proceso { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [StringLength(20)]
        public string Cve_prov { get; set; }

        public string Localidad { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Estatus { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FECHAPROCESO { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string UsrProceso { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(57)]
        public string observaciones { get; set; }
    }
}
