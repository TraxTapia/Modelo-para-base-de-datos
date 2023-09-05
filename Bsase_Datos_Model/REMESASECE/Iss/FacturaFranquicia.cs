namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaFranquicia")]
    public partial class FacturaFranquicia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FacturaFranquicia()
        {
            Recibo = new HashSet<Recibo>();
        }

        [Key]
        [StringLength(20)]
        public string NoFactura { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaFactura { get; set; }

        public int CodTipoContribuyente { get; set; }

        public double Subtotal { get; set; }

        public double IVA { get; set; }

        public double Total { get; set; }

        [Required]
        [StringLength(1)]
        public string EstatusPago { get; set; }

        public virtual EstatusPago EstatusPago1 { get; set; }

        public virtual TipoContribuyente TipoContribuyente { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recibo> Recibo { get; set; }
    }
}
