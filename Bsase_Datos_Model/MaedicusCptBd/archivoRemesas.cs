namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class archivoRemesas
    {
        [Key]
        public int codMovimiento { get; set; }

        [StringLength(50)]
        public string remesa { get; set; }

        [StringLength(50)]
        public string cve_empresa { get; set; }

        public DateTime? fechaEnvioPago { get; set; }

        public double? importe { get; set; }

        public double? iva { get; set; }

        public double? isr { get; set; }

        public double? retIva { get; set; }

        public double? impCedular { get; set; }

        public double? total { get; set; }

        public int? facturas { get; set; }

        [StringLength(50)]
        public string usr { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string ubicacion { get; set; }

        [StringLength(50)]
        public string caja { get; set; }

        [StringLength(255)]
        public string observaciones { get; set; }
    }
}
