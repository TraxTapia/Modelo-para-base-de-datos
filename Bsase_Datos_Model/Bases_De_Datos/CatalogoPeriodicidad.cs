namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatalogoPeriodicidad")]
    public partial class CatalogoPeriodicidad
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(25)]
        public string Intervalo { get; set; }

        public short Multiplicador { get; set; }
    }
}
