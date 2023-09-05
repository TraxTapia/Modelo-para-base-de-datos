namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.consultaElectronica#")]
    public partial class consultaElectronica_
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codcuenta { get; set; }

        [StringLength(20)]
        public string rfc { get; set; }

        [StringLength(255)]
        public string nombrecompleto { get; set; }

        public int? codempresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string nombreempresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string rfcafacturar { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(500)]
        public string producto { get; set; }

        public int? idproducto { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string autorizacion { get; set; }

        [StringLength(20)]
        public string folio { get; set; }

        public DateTime? fechaServicio { get; set; }

        [StringLength(255)]
        public string codespecialidad { get; set; }

        public int? idmedicotratante { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int coddetalle { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(50)]
        public string cpt { get; set; }

        [StringLength(511)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(10)]
        public string codtabulador { get; set; }

        [StringLength(5)]
        public string Copagoen { get; set; }

        public double? Copago { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int cantidad { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(1)]
        public string IVA { get; set; }

        [Key]
        [Column(Order = 11)]
        public double PU { get; set; }

        [Key]
        [Column(Order = 12)]
        public double Total { get; set; }

        public bool? PagadoFacturado { get; set; }

        public int? codEstatusFacturacion { get; set; }

        [StringLength(50)]
        public string factura { get; set; }

        public DateTime? fechaFactura { get; set; }
    }
}
