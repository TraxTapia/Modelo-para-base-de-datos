namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SAE_Padron_
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(50)]
        public string Movimientos { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codempresa { get; set; }

        [StringLength(50)]
        public string No { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Mandato { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string NEmpleado { get; set; }

        [StringLength(255)]
        public string Apaterno { get; set; }

        [StringLength(255)]
        public string Amaterno { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Edad { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string Parentesco { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FNacimiento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FAlta { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FBaja { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FFinServicio { get; set; }

        [StringLength(255)]
        public string Codestado { get; set; }

        [StringLength(255)]
        public string Codpoblacion { get; set; }
    }
}
