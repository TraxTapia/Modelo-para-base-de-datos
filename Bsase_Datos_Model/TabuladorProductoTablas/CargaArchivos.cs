namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CargaArchivos
    {
        [Key]
        [StringLength(100)]
        public string NombreArchivo { get; set; }

        public DateTime FechaCargaArchivo { get; set; }

        [Required]
        [StringLength(100)]
        public string SegLogin { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusArchivo { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual EstatusArchivo EstatusArchivo { get; set; }

        public virtual Login Login { get; set; }
    }
}
