namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIS_CTLF_EstatusFolios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SIS_CTLF_EstatusFolios()
        {
            SIS_CTLF_Folios = new HashSet<SIS_CTLF_Folios>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int estatus { get; set; }

        [Required]
        [StringLength(70)]
        public string descripcion { get; set; }

        [StringLength(255)]
        public string observaciones { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SIS_CTLF_Folios> SIS_CTLF_Folios { get; set; }
    }
}
