namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaseEspecialista")]
    public partial class PaseEspecialista
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodServicioGeneral { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPaseEspecialista { get; set; }

        [Required]
        [StringLength(8)]
        public string Folio { get; set; }

        public DateTime FechaPase { get; set; }

        [Required]
        [StringLength(500)]
        public string MotivoReferencia { get; set; }

        [Required]
        [StringLength(10)]
        public string CodEspecialidadReferida { get; set; }

        public int? CodProveedorReferido { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatus { get; set; }

        public virtual ServicioGeneral ServicioGeneral { get; set; }
    }
}
