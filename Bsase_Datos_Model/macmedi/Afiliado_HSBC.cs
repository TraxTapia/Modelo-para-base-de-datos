namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Afiliado_HSBC
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodEmpresa { get; set; }

        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        [StringLength(30)]
        public string CodParentesco { get; set; }

        public int? CodEstatus { get; set; }

        [StringLength(30)]
        public string Nombres { get; set; }

        [StringLength(30)]
        public string ApellidoPaterno { get; set; }

        [StringLength(30)]
        public string ApellidoMaterno { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FechaNacimiento { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime FechaInicioServicio { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaCargaMediaccess { get; set; }

        [StringLength(30)]
        public string CodEstado { get; set; }

        [StringLength(255)]
        public string Municipio { get; set; }
    }
}
