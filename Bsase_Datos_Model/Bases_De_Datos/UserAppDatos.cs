namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserAppDatos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Afiliado { get; set; }

        [Required]
        [StringLength(70)]
        public string Calle { get; set; }

        [Required]
        [StringLength(10)]
        public string NoExt { get; set; }

        [Required]
        [StringLength(10)]
        public string NoInt { get; set; }

        [Required]
        [StringLength(30)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        [Required]
        [StringLength(80)]
        public string Municipio { get; set; }

        [Required]
        [StringLength(80)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(17)]
        public string NoCelular { get; set; }

        [Required]
        [StringLength(25)]
        public string NoFijo { get; set; }

        [Required]
        [StringLength(30)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [StringLength(30)]
        public string UsuCambio { get; set; }

        public DateTime? FechaCambio { get; set; }
    }
}
