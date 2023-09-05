namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_Factura_Remesas_Foliador
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

        [Required]
        [StringLength(30)]
        public string Remesa { get; set; }

        [Column(TypeName = "date")]
        public DateTime F_Proceso { get; set; }

        [Required]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [StringLength(20)]
        public string Cve_prov { get; set; }

        public string Localidad { get; set; }

        public bool Estatus { get; set; }
    }
}
