namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.canalBroker")]
    public partial class canalBroker
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public canalBroker()
        {
            ventasSistemaCartera = new HashSet<ventasSistemaCartera>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCanalBroker { get; set; }

        [StringLength(100)]
        public string razonSocial { get; set; }

        [StringLength(100)]
        public string nombreComercial { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [StringLength(300)]
        public string direccionFacturar { get; set; }

        [StringLength(300)]
        public string direccionEntrega { get; set; }

        public DateTime? fechaAlta { get; set; }

        [StringLength(50)]
        public string xusrAlta { get; set; }

        public int? codEstatus { get; set; }

        [StringLength(10)]
        public string ladaTelContacto { get; set; }

        [StringLength(50)]
        public string telContacto { get; set; }

        [StringLength(50)]
        public string celContacto { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? mesesCorte { get; set; }

        public DateTime? fechaCorte { get; set; }

        public int? diasCorte { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventasSistemaCartera> ventasSistemaCartera { get; set; }
    }
}
