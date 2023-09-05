namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AIG")]
    public partial class AIG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodEmpresa { get; set; }

        [StringLength(25)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        [StringLength(50)]
        public string CodCalle { get; set; }

        [StringLength(5)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstatus { get; set; }

        [StringLength(25)]
        public string Nombres { get; set; }

        [StringLength(25)]
        public string ApellidoPaterno { get; set; }

        [StringLength(25)]
        public string ApellidoMaterno { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        public DateTime? FechaInicioServicio { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        public DateTime? FechaCargaMediaccess { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(25)]
        public string Telefonos { get; set; }
    }
}
