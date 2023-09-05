namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class concepto_WSFacturaXML
    {
        [Key]
        public int conceptoID { get; set; }

        public int factura_ID { get; set; }

        public int cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string unidad { get; set; }

        [StringLength(50)]
        public string noIdentificacion { get; set; }

        [Column(TypeName = "text")]
        public string descripcion { get; set; }

        public double valorUnitario { get; set; }

        public double importe { get; set; }

        public virtual WSFacturaXML WSFacturaXML { get; set; }
    }
}
