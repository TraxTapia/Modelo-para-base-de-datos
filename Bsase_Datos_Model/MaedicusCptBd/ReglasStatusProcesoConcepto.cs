namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReglasStatusProcesoConcepto")]
    public partial class ReglasStatusProcesoConcepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReglasStatusProcesoConcepto()
        {
            RolReglasStatusProcesoConcepto = new HashSet<RolReglasStatusProcesoConcepto>();
        }

        public int id { get; set; }

        [Required]
        [StringLength(2)]
        public string codEstatusFactura { get; set; }

        [Required]
        [StringLength(10)]
        public string codConceptoOrigen { get; set; }

        [Required]
        [StringLength(10)]
        public string codConceptoDestino { get; set; }

        public short orden { get; set; }

        public virtual Concepto Concepto { get; set; }

        public virtual Concepto Concepto1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RolReglasStatusProcesoConcepto> RolReglasStatusProcesoConcepto { get; set; }
    }
}
