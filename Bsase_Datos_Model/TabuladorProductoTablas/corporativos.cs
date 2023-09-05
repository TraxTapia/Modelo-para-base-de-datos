namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.corporativos")]
    public partial class corporativos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public corporativos()
        {
            ventasSistemaCartera = new HashSet<ventasSistemaCartera>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCorporativo { get; set; }

        [StringLength(50)]
        public string Corporativo { get; set; }

        [StringLength(10)]
        public string RFC { get; set; }

        [StringLength(50)]
        public string tel1 { get; set; }

        [StringLength(50)]
        public string tel2 { get; set; }

        [StringLength(50)]
        public string email1 { get; set; }

        [StringLength(50)]
        public string email2 { get; set; }

        [StringLength(200)]
        public string direccion { get; set; }

        public int? codContacto { get; set; }

        [StringLength(10)]
        public string codEstado { get; set; }

        public int? codPoblacion { get; set; }

        [StringLength(200)]
        public string nomFiscal { get; set; }

        [StringLength(200)]
        public string direccionFiscal { get; set; }

        [StringLength(50)]
        public string colonia { get; set; }

        [StringLength(50)]
        public string ciudad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventasSistemaCartera> ventasSistemaCartera { get; set; }
    }
}
