namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaseEspecialistaSegundo")]
    public partial class PaseEspecialistaSegundo
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodBandeja { get; set; }

        public DateTime? FechaLlamada { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Codempresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string CodAfiliado { get; set; }

        public int? correlativo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Secuencia { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string PaseEspecialista { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCuenta { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clinica { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string codEspecialidad { get; set; }
    }
}
