namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Bandeja
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Estatus_Bandeja()
        {
            BandejaEntradaLog = new HashSet<BandejaEntradaLog>();
        }

        [Key]
        [StringLength(10)]
        public string CodEstatusBandeja { get; set; }

        [StringLength(50)]
        public string EstatusBandeja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BandejaEntradaLog> BandejaEntradaLog { get; set; }
    }
}
