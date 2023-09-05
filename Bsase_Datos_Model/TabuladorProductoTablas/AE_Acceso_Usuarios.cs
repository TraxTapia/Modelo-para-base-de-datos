namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AE_Acceso_Usuarios
    {
        [Key]
        [StringLength(50)]
        public string CodLogin { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Pass { get; set; }

        public int CodClinica { get; set; }

        public int CodPerfil { get; set; }

        public int Subperfil { get; set; }

        [Required]
        [StringLength(1)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario_I { get; set; }

        public DateTime Fecha_I { get; set; }

        [StringLength(50)]
        public string Usuario_U { get; set; }

        public DateTime? Fecha_U { get; set; }
    }
}
