namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Direccion")]
    public partial class Direccion
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string EstadoId { get; set; }

        [Required]
        [StringLength(10)]
        public string MunicipioId { get; set; }

        [Required]
        [StringLength(10)]
        public string LocalidadId { get; set; }

        [Required]
        [StringLength(255)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(5)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(500)]
        public string Calle { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroExterior { get; set; }

        [Required]
        [StringLength(100)]
        public string NumeroInterior { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        public decimal Altitud { get; set; }

        [Required]
        [StringLength(500)]
        public string Observaciones { get; set; }

        public bool Validado { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        [Required]
        [StringLength(255)]
        public string TextoUbicacion { get; set; }
    }
}
