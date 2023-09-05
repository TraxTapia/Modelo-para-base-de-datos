namespace Bsase_Datos_Model.MaedicusCPTTabuladores
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorProveedorPreciosRechazos
    {
        public int Id { get; set; }

        public int IdFileRechazo { get; set; }

        public int CveProv { get; set; }

        [Required]
        [StringLength(300)]
        public string Descripcion { get; set; }

        public decimal PrecioPublico { get; set; }

        public decimal PrecioPublicoAnterior { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoGasto { get; set; }

        public DateTime FechaCreacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public virtual FilePreciosRechazos FilePreciosRechazos { get; set; }
    }
}
