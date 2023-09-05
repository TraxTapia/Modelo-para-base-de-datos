namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoUbicacion")]
    public partial class TipoUbicacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoUbicacion()
        {
            UbicacionAfiliado = new HashSet<UbicacionAfiliado>();
            UbicacionEmpresa = new HashSet<UbicacionEmpresa>();
            UbicacionProveedor = new HashSet<UbicacionProveedor>();
            UbicacionVendedor = new HashSet<UbicacionVendedor>();
        }

        [Key]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [Column("TipoUbicacion")]
        [Required]
        [StringLength(50)]
        public string TipoUbicacion1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionAfiliado> UbicacionAfiliado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionEmpresa> UbicacionEmpresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionProveedor> UbicacionProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionVendedor> UbicacionVendedor { get; set; }
    }
}
