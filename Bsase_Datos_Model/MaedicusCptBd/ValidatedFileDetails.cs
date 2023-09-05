namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ValidatedFileDetails
    {
        public int Id { get; set; }

        public int? ValidatedFile_Id { get; set; }

        public int ReasonRejectedFolio_Id { get; set; }

        [Required]
        [StringLength(20)]
        public string folio { get; set; }

        public DateTime f_ocurrido { get; set; }

        [StringLength(50)]
        public string Nomina { get; set; }

        public int Numbenef { get; set; }

        [Required]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [Required]
        [StringLength(20)]
        public string cve_proc { get; set; }

        public double importe { get; set; }

        public double iva { get; set; }

        public double total { get; set; }

        public int cantidad { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        public double? ImporteDescuento { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }

        public bool Validated { get; set; }

        [StringLength(300)]
        public string Observation { get; set; }

        public int OrderValidation { get; set; }

        public decimal Copago { get; set; }

        public decimal CopagoEn { get; set; }

        public virtual ReasonRejectedFolio ReasonRejectedFolio { get; set; }

        public virtual ValidatedFiles ValidatedFiles { get; set; }
    }
}
