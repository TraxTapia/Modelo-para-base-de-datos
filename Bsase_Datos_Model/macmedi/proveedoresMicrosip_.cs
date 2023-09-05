namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.proveedoresMicrosip#")]
    public partial class proveedoresMicrosip_
    {
        [StringLength(25)]
        public string ClavePrincipal { get; set; }

        [StringLength(22)]
        public string ClaveAlterna { get; set; }

        [StringLength(102)]
        public string NombreCompleto { get; set; }

        [StringLength(102)]
        public string Contacto1 { get; set; }

        [StringLength(102)]
        public string Contacto2 { get; set; }

        [StringLength(20)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(3)]
        public string limiteCredito { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string ClaveMoneda { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(7)]
        public string ClaveCondicionPago { get; set; }

        [StringLength(12)]
        public string ClaveTipoProveedor { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(3)]
        public string ClaveConceptoBancario { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(3)]
        public string cobrarImpuestos { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(3)]
        public string retenerImpuestos { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(3)]
        public string ProveedorExtrangero { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(3)]
        public string Vacio { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(3)]
        public string CuentaDeCuentasPorCobrar { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(2)]
        public string CuentaAnticipos { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(3)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(3)]
        public string CausaSuspencion { get; set; }

        [StringLength(102)]
        public string NombreCalle { get; set; }

        [StringLength(102)]
        public string NumExterior { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string NumInterior { get; set; }

        [StringLength(102)]
        public string Colonia { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(3)]
        public string referencia { get; set; }

        [StringLength(12)]
        public string codestado { get; set; }

        [StringLength(12)]
        public string codPoblacion { get; set; }

        [StringLength(52)]
        public string codigoPostal { get; set; }

        [StringLength(102)]
        public string Telefono1 { get; set; }

        [StringLength(102)]
        public string Telefono2 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(22)]
        public string Fax { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(52)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(3)]
        public string claveViaEmbarque { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(3)]
        public string Notas { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(3)]
        public string fechaSuspension { get; set; }

        [StringLength(52)]
        public string banco { get; set; }

        [StringLength(52)]
        public string cuentaBancaria { get; set; }

        [StringLength(52)]
        public string clabe { get; set; }
    }
}
