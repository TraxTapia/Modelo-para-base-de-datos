namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_SAE_PadronJ_
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

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Mandato { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string NEmpleado { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clasificacion { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [StringLength(255)]
        public string Apaterno { get; set; }

        [StringLength(255)]
        public string Amaterno { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Edad { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(50)]
        public string Parentesco { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FNacimiento { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FAlta { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [StringLength(255)]
        public string Ciudad { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FBaja { get; set; }

        [Column(TypeName = "date")]
        public DateTime? FFinServicio { get; set; }

        [StringLength(255)]
        public string Codestado { get; set; }

        [StringLength(255)]
        public string Codpoblacion { get; set; }

        [StringLength(255)]
        public string pyme { get; set; }
    }
}
