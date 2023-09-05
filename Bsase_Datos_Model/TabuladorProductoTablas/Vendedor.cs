namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vendedor")]
    public partial class Vendedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendedor()
        {
            ContactoVendedor = new HashSet<ContactoVendedor>();
            FolioMembresia = new HashSet<FolioMembresia>();
            UbicacionVendedor = new HashSet<UbicacionVendedor>();
            Vendedor1 = new HashSet<Vendedor>();
        }

        [Key]
        [StringLength(20)]
        public string CodVendedor { get; set; }

        public int CodEmpresa { get; set; }

        public int CodTipoVendedor { get; set; }

        [Required]
        [StringLength(100)]
        public string NombreVendedor { get; set; }

        [StringLength(20)]
        public string CodVendedorSuperior { get; set; }

        [Required]
        [StringLength(20)]
        public string SGLogin { get; set; }

        [Required]
        [StringLength(150)]
        public string SGClave { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoVendedor> ContactoVendedor { get; set; }

        public virtual Empresa Empresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FolioMembresia> FolioMembresia { get; set; }

        public virtual TipoVendedor TipoVendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionVendedor> UbicacionVendedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vendedor> Vendedor1 { get; set; }

        public virtual Vendedor Vendedor2 { get; set; }
    }
}
