namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstatusFactura")]
    public partial class EstatusFactura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public EstatusFactura()
        {
            Facturas = new HashSet<Facturas>();
        }

        [Key]
        [StringLength(2)]
        public string CodEstatusFactura { get; set; }

        [Column("EstatusFactura")]
        [Required]
        [StringLength(50)]
        public string EstatusFactura1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
