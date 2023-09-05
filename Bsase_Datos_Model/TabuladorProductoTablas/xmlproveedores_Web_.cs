namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("xmlproveedores_Web#")]
    public partial class xmlproveedores_Web_
    {
        [Key]
        public int ident { get; set; }

        [Required]
        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [Required]
        [StringLength(10)]
        public string Serie { get; set; }

        [Required]
        [StringLength(150)]
        public string Folio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime Fecha { get; set; }

        [Required]
        public string Procedimiento { get; set; }

        public int Cantidad { get; set; }

        [Required]
        [StringLength(20)]
        public string Proveedor { get; set; }

        [Required]
        public string Uuid { get; set; }

        [Required]
        [StringLength(10)]
        public string importe { get; set; }

        [Required]
        public string afiliado { get; set; }

        [Required]
        [StringLength(10)]
        public string Subtotal { get; set; }

        [Required]
        [StringLength(10)]
        public string IVA { get; set; }

        [Required]
        [StringLength(10)]
        public string ISR { get; set; }

        [Required]
        [StringLength(10)]
        public string RetIva { get; set; }

        [Required]
        [StringLength(10)]
        public string cedular { get; set; }

        [Required]
        [StringLength(10)]
        public string Total { get; set; }

        public string diagnostico { get; set; }

        [StringLength(20)]
        public string Coddiagnostico { get; set; }

        [StringLength(20)]
        public string CodProcedimiento { get; set; }

        [StringLength(20)]
        public string codafiliado { get; set; }

        [StringLength(5)]
        public string codparentesco { get; set; }
    }
}
