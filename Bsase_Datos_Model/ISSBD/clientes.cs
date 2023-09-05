namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.clientes")]
    public partial class clientes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clientes()
        {
            ventasSistemaCartera = new HashSet<ventasSistemaCartera>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCliente { get; set; }

        [StringLength(50)]
        public string razonSocial { get; set; }

        [StringLength(50)]
        public string nombreComercial { get; set; }

        public int? codEmpresa { get; set; }

        public int? codPymeColectivodad { get; set; }

        [StringLength(50)]
        public string RFC { get; set; }

        [StringLength(300)]
        public string direccionFacturar { get; set; }

        [StringLength(300)]
        public string direccionEntrega { get; set; }

        [StringLength(50)]
        public string nombreContacto { get; set; }

        [StringLength(50)]
        public string ladaTelcontacto { get; set; }

        [StringLength(50)]
        public string telContacto { get; set; }

        [StringLength(50)]
        public string celContacto { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        public int? codcanalBroker { get; set; }

        public int? mesesFacturacion { get; set; }

        public DateTime? fechaCorte { get; set; }

        public int? diasFechaCorte { get; set; }

        public int? codCorporativo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ventasSistemaCartera> ventasSistemaCartera { get; set; }
    }
}
