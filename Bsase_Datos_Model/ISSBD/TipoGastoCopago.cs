namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoGastoCopago")]
    public partial class TipoGastoCopago
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoGastoCopago()
        {
            Ficha_Tecnica = new HashSet<Ficha_Tecnica>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string DescripcionGasto { get; set; }

        public bool Activo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ficha_Tecnica> Ficha_Tecnica { get; set; }
    }
}
