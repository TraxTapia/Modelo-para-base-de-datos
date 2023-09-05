namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tblServiceAutDetails
    {
        public long Id { get; set; }

        public long tblServiceAut_ID { get; set; }

        [StringLength(50)]
        public string FolioDet { get; set; }

        [Required]
        [StringLength(50)]
        public string Cpt { get; set; }

        [StringLength(50)]
        public string codAut { get; set; }

        [StringLength(50)]
        public string Autorizacion { get; set; }

        [StringLength(10)]
        public string CodTabulador { get; set; }

        public int? Cantidad { get; set; }

        public double? PrecioUnitario { get; set; }

        public double? Total { get; set; }

        [StringLength(10)]
        public string CopagoEn { get; set; }

        public int? Copago { get; set; }

        public string Indicaciones { get; set; }

        public string Descripcion { get; set; }

        public bool? IsFacturado { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProcessedDate { get; set; }

        public virtual tblServiceAut tblServiceAut { get; set; }
    }
}
