namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Colonia")]
    public partial class Colonia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Colonia()
        {
            UbicacionEmpresa = new HashSet<UbicacionEmpresa>();
            UbicacionProveedor = new HashSet<UbicacionProveedor>();
            UbicacionVendedor = new HashSet<UbicacionVendedor>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPoblacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodColonia { get; set; }

        [Column("Colonia")]
        [Required]
        [StringLength(100)]
        public string Colonia1 { get; set; }

        [Required]
        [StringLength(5)]
        public string CP { get; set; }

        [Required]
        [StringLength(5)]
        public string CPOficina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionEmpresa> UbicacionEmpresa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionProveedor> UbicacionProveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UbicacionVendedor> UbicacionVendedor { get; set; }
    }
}
