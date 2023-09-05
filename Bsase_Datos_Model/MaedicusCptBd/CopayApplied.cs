namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CopayApplied")]
    public partial class CopayApplied
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CopayApplied()
        {
            HospitalCopayLog = new HashSet<HospitalCopayLog>();
            OperationRollbackCopayHospital = new HashSet<OperationRollbackCopayHospital>();
        }

        public int Id { get; set; }

        public int SecuenciaMAC { get; set; }

        public int HospitalCopayStatus_Id { get; set; }

        public decimal AmountCopayByQuantity { get; set; }

        public int? Cobertura_Id { get; set; }

        [StringLength(100)]
        public string Cobertura { get; set; }

        public int? Cantidad { get; set; }

        public virtual HospitalCopayStatus HospitalCopayStatus { get; set; }

        public virtual Facturas Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HospitalCopayLog> HospitalCopayLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationRollbackCopayHospital> OperationRollbackCopayHospital { get; set; }
    }
}
