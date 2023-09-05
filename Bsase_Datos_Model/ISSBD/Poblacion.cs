namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Poblacion")]
    public partial class Poblacion
    {
        [Required]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Required]
        [StringLength(4)]
        public string CodEstado { get; set; }

        public int CodPoblacion { get; set; }

        [Column("Poblacion")]
        [Required]
        [StringLength(100)]
        public string Poblacion1 { get; set; }

        public int CodZona { get; set; }

        public int Id { get; set; }

        public virtual Estado Estado { get; set; }

        public virtual Zona Zona { get; set; }
    }
}
