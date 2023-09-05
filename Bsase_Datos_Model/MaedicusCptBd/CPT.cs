namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPT")]
    public partial class CPT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CPT()
        {
            OP_TBL_COSTOS = new HashSet<OP_TBL_COSTOS>();
            procedimientOdontologico = new HashSet<procedimientOdontologico>();
            TabuladorCPT = new HashSet<TabuladorCPT>();
        }

        [Key]
        [Column("CPT")]
        [StringLength(20)]
        public string CPT1 { get; set; }

        [Required]
        [StringLength(255)]
        public string DescripcionCorta { get; set; }

        [Required]
        [StringLength(500)]
        public string DescripcionLarga { get; set; }

        public double? Porcentaje { get; set; }

        [Required]
        [StringLength(2)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string Lugar { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OP_TBL_COSTOS> OP_TBL_COSTOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<procedimientOdontologico> procedimientOdontologico { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TabuladorCPT> TabuladorCPT { get; set; }
    }
}
