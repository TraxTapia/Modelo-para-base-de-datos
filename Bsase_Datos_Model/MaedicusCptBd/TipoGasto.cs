namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipoGasto")]
    public partial class TipoGasto
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipoGasto()
        {
            Especialidad = new HashSet<Especialidad>();
            ExcludedProceduresByTipoGasto = new HashSet<ExcludedProceduresByTipoGasto>();
            TipoGastoListaPrecios = new HashSet<TipoGastoListaPrecios>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoGasto { get; set; }

        [Column("TipoGasto")]
        [Required]
        [StringLength(50)]
        public string TipoGasto1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Especialidad> Especialidad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExcludedProceduresByTipoGasto> ExcludedProceduresByTipoGasto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TipoGastoListaPrecios> TipoGastoListaPrecios { get; set; }
    }
}
