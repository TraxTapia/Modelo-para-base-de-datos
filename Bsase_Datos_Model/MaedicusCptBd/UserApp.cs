namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserApp")]
    public partial class UserApp
    {
        public int Id { get; set; }

        [StringLength(60)]
        public string Afiliado { get; set; }

        [StringLength(90)]
        public string Password { get; set; }

        [StringLength(35)]
        public string Email { get; set; }

        public int? Referencia { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime? FechaCambio { get; set; }

        [Required]
        [StringLength(35)]
        public string UsuAlta { get; set; }

        [StringLength(35)]
        public string UsuCambio { get; set; }

        [StringLength(90)]
        public string Managedkey { get; set; }

        [StringLength(90)]
        public string ManagedIV { get; set; }

        public bool? TerminosyCondiciones { get; set; }

        [Required]
        [StringLength(250)]
        public string NombreCompleto { get; set; }

        public DateTime? FechaNacimiento { get; set; }
    }
}
