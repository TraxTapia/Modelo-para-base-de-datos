namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AFQualitas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodEmpresa { get; set; }

        [StringLength(255)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string CodCalle { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstatus { get; set; }

        [StringLength(255)]
        public string Nombres { get; set; }

        [StringLength(255)]
        public string ApellidoPaterno { get; set; }

        [StringLength(255)]
        public string ApellidoMaterno { get; set; }

        [StringLength(255)]
        public string Sexo { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaInicioServicio { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaCargaMediaccess { get; set; }
    }
}
