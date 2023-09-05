namespace Bsase_Datos_Model.Medikit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedikitFtpFileDetail")]
    public partial class MedikitFtpFileDetail
    {
        public int Id { get; set; }

        public int IdFile { get; set; }

        [Required]
        [StringLength(200)]
        public string Nur { get; set; }

        [Required]
        [StringLength(200)]
        public string Paciente { get; set; }

        [Required]
        [StringLength(200)]
        public string Doctor { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Dispensacion_de_medicamentos { get; set; }

        public DateTime? Fecha_de_creacion { get; set; }

        [Required]
        [StringLength(200)]
        public string Creado_por { get; set; }

        public DateTime? Ultima_modificacion { get; set; }

        [Required]
        [StringLength(200)]
        public string Ultima_modificacion_por { get; set; }

        [Required]
        [StringLength(200)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre_Medicacion { get; set; }

        [Required]
        [StringLength(200)]
        public string Receta_relacionada { get; set; }

        public int Cantidad { get; set; }

        public DateTime? Fecha_Dispensada { get; set; }

        public int Ticket { get; set; }

        public decimal Precio_Venta_Unitario_AC { get; set; }

        public decimal DescuentoPorcentaje { get; set; }

        public decimal Descuento_Monto_Unitario { get; set; }

        public decimal Descuento_Monto_por_cantidad_de_piezas_surtidas { get; set; }

        public decimal Precio_MAC_Unitario { get; set; }

        public decimal Precio_MAC_Total { get; set; }

        public decimal IVAPorcentaje { get; set; }

        public decimal IVA_identificador_por_medicamento { get; set; }

        public decimal CopagoPorcentaje { get; set; }

        public decimal Monto_Copago_Unitario { get; set; }

        public decimal Monto_Copago_Total { get; set; }

        public decimal Importe_Despues_Copago_Unitario { get; set; }

        public decimal Importe_Despues_Copago_Total { get; set; }

        public decimal Monto_Unitario_IVA { get; set; }

        public decimal Monto_Total_IVA { get; set; }

        public decimal Total { get; set; }

        public int Numero_de_Sucursal { get; set; }

        [Required]
        [StringLength(200)]
        public string EAN { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre_de_Sucursal { get; set; }

        public decimal Precio_Bruto_Unitario_POS { get; set; }

        public decimal Precio_Bruto_POS { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre_de_la_cuenta_del_dispensador { get; set; }

        public virtual MedikitFTPFile MedikitFTPFile { get; set; }
    }
}
