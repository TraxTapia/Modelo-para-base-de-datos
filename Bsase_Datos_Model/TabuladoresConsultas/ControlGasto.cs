namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ControlGasto")]
    public partial class ControlGasto
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(20)]
        public string Folio { get; set; }

        public DateTime FechaOcurrido { get; set; }

        [Required]
        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [Required]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        public int CodTipoCuenta { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int IdTipoCopago { get; set; }

        public decimal Copago { get; set; }

        public decimal Monto_Copago { get; set; }

        public int Cantidad { get; set; }

        [Required]
        [StringLength(20)]
        public string Cve_proc { get; set; }

        [Required]
        [StringLength(4)]
        public string Cve_espec { get; set; }

        [Required]
        [StringLength(5)]
        public string Cve_cie { get; set; }

        public int? CodEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int Correlativo { get; set; }

        [Required]
        [StringLength(50)]
        public string CodProducto { get; set; }

        public decimal Importe { get; set; }

        public int IdTipoPago { get; set; }

        public int IdTipoCobertura { get; set; }

        [Required]
        [StringLength(100)]
        public string Usuario { get; set; }

        public DateTime? CreadoEn { get; set; }

        public DateTime? ActualizadoEn { get; set; }

        public bool Activo { get; set; }

        public virtual TipoCobertura TipoCobertura { get; set; }
    }
}
