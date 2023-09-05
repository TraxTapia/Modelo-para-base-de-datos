namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_OP_TPClasi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codempresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        public string NombreFiscal { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Especialidad_orig { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string tipogasto { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string cve_proc { get; set; }

        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(3)]
        public string clasificacion { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(100)]
        public string especialidad { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string TipoProv { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string TipoProv_DSC { get; set; }
    }
}
