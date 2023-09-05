namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIS_CTLF_Stock
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIS_CTLF_Stock()
        {
            SIS_CTLF_Folios = new HashSet<SIS_CTLF_Folios>();
        }

        [Key]
        [StringLength(25)]
        public string folio { get; set; }

        [Required]
        [StringLength(25)]
        public string archivo { get; set; }

        [Required]
        [StringLength(20)]
        public string usr_cargo { get; set; }

        public DateTime fecha_carga { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIS_CTLF_Folios> SIS_CTLF_Folios { get; set; }
    }
}
