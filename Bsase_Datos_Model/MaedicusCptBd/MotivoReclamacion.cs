namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MotivoReclamacion")]
    public partial class MotivoReclamacion
    {
        public int Id { get; set; }

        public int ProcesoId { get; set; }

        [Required]
        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
