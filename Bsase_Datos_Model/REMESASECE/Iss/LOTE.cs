namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOTE")]
    public partial class LOTE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOTE()
        {
            SSR = new HashSet<SSR>();
        }

        [Key]
        [StringLength(8)]
        public string NoLote { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime FechaPresentacion { get; set; }

        public int CodOperacionBancaria { get; set; }

        public int CodBanco { get; set; }

        [Required]
        [StringLength(1)]
        public string CodSentido { get; set; }

        public int CodDivisa { get; set; }

        public int CodMotivoDevolucion { get; set; }

        public virtual Banco Banco { get; set; }

        public virtual Divisa Divisa { get; set; }

        public virtual MotivoDevolucion MotivoDevolucion { get; set; }

        public virtual OperacionBancaria OperacionBancaria { get; set; }

        public virtual Sentido Sentido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SSR> SSR { get; set; }
    }
}
