namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EspecialidadxProducto")]
    public partial class EspecialidadxProducto
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodigoEspecialidad { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        public int? idNivel { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public bool Activo { get; set; }

        public virtual EspecialidadNegocio EspecialidadNegocio { get; set; }

        public virtual NivelEspecialidad NivelEspecialidad { get; set; }
    }
}
