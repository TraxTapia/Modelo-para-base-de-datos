namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelacionDireccion")]
    public partial class RelacionDireccion
    {
        public int Id { get; set; }

        public int DireccionId { get; set; }

        [Required]
        [StringLength(100)]
        public string Clave { get; set; }

        [Required]
        [StringLength(100)]
        public string Modulo { get; set; }

        [Required]
        [StringLength(100)]
        public string Tipo { get; set; }

        [Required]
        [StringLength(100)]
        public string Aux1 { get; set; }

        [Required]
        [StringLength(100)]
        public string Aux2 { get; set; }

        [Required]
        [StringLength(100)]
        public string Aux3 { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }
    }
}
