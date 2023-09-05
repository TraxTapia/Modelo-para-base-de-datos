namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HospitalCopayLog")]
    public partial class HospitalCopayLog
    {
        public int Id { get; set; }

        public int CopayApplied_Id { get; set; }

        public int HospitalCopayStatus_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public DateTime Date { get; set; }

        public virtual CopayApplied CopayApplied { get; set; }

        public virtual HospitalCopayStatus HospitalCopayStatus { get; set; }
    }
}
