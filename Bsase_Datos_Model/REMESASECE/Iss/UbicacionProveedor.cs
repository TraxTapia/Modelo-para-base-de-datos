namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UbicacionProveedor")]
    public partial class UbicacionProveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UbicacionProveedor()
        {
            ContactoProveedor = new HashSet<ContactoProveedor>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodUbicacion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Required]
        [StringLength(4)]
        public string CodEstado { get; set; }

        public int CodPoblacion { get; set; }

        public int CodColonia { get; set; }

        [Required]
        [StringLength(10)]
        public string CP { get; set; }

        [Required]
        [StringLength(100)]
        public string Domicilio { get; set; }

        [Required]
        [StringLength(50)]
        public string HorarioAtencion { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Observacion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [StringLength(1)]
        public string CodEstatusUbicacion { get; set; }

        [Required]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public virtual Colonia Colonia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ContactoProveedor> ContactoProveedor { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual TipoUbicacion TipoUbicacion { get; set; }
    }
}
