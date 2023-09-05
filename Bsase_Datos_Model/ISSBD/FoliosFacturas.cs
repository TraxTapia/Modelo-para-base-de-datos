namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FoliosFacturas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FoliosFacturas()
        {
            FoliosFacturas1 = new HashSet<FoliosFacturas>();
        }

        public int CodTipoResponsable { get; set; }

        [Key]
        [StringLength(25)]
        public string Referencia { get; set; }

        [Required]
        [StringLength(2)]
        public string CodTipoFormato { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusFolio { get; set; }

        [Required]
        [StringLength(50)]
        public string FolioInicial { get; set; }

        [Required]
        [StringLength(10)]
        public string FolioFinal { get; set; }

        public DateTime FechaEntrega { get; set; }

        public DateTime? FechaActivacion { get; set; }

        [StringLength(25)]
        public string ReferenciaEntrega { get; set; }

        public virtual EstatusFolio EstatusFolio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FoliosFacturas> FoliosFacturas1 { get; set; }

        public virtual FoliosFacturas FoliosFacturas2 { get; set; }

        public virtual TipoFormato TipoFormato { get; set; }

        public virtual TipoResponsable TipoResponsable { get; set; }
    }
}
