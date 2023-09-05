namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.Recursos_Medicos")]
    public partial class Recursos_Medicos1
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string RecursoMedico { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string Carga { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string HayIVA { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string HayISR { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string HayRetIva { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(1)]
        public string Status { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(100)]
        public string Direccion { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(17)]
        public string telefono { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(20)]
        public string e_mail { get; set; }

        [StringLength(20)]
        public string horario { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(10)]
        public string cve_usuario { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(30)]
        public string Plaza { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(10)]
        public string CodEstado { get; set; }

        [StringLength(5)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 15)]
        public double PORCIVA { get; set; }

        [Key]
        [Column(Order = 16)]
        public double PORCISR { get; set; }

        [Key]
        [Column(Order = 17)]
        public double PORCRETIVA { get; set; }

        [StringLength(15)]
        public string Cuenta { get; set; }

        [StringLength(5)]
        public string Sucursal { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(10)]
        public string CodPoblacion { get; set; }
    }
}
