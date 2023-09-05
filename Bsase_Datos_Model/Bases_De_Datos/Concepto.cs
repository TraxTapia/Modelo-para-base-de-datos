namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Concepto")]
    public partial class Concepto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Concepto()
        {
            ReglasStatusProcesoConcepto = new HashSet<ReglasStatusProcesoConcepto>();
            ReglasStatusProcesoConcepto1 = new HashSet<ReglasStatusProcesoConcepto>();
            StatusProcesoConcepto = new HashSet<StatusProcesoConcepto>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodConcepto { get; set; }

        [Column("Concepto")]
        [StringLength(600)]
        public string Concepto1 { get; set; }

        public byte? activo { get; set; }

        public byte? catdevolucion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReglasStatusProcesoConcepto> ReglasStatusProcesoConcepto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReglasStatusProcesoConcepto> ReglasStatusProcesoConcepto1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StatusProcesoConcepto> StatusProcesoConcepto { get; set; }
    }
}
