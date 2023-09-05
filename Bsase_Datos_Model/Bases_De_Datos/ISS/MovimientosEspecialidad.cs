namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MovimientosEspecialidad")]
    public partial class MovimientosEspecialidad
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string CodigoEspecialidad { get; set; }

        public DateTime Fecha { get; set; }

        public int TipoMovimiento_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual EspecialidadNegocio EspecialidadNegocio { get; set; }

        public virtual TipoMovimientoEspecialidad TipoMovimientoEspecialidad { get; set; }
    }
}
