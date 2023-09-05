namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Procedimiento")]
    public partial class Procedimiento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Procedimiento()
        {
            ProcedimientoEspecialidad = new HashSet<ProcedimientoEspecialidad>();
        }

        [Key]
        [StringLength(20)]
        public string CodProcedimiento { get; set; }

        [Column("Procedimiento")]
        [Required]
        [StringLength(255)]
        public string Procedimiento1 { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(3)]
        public string CodTipoTabulador { get; set; }

        [StringLength(20)]
        public string CodCuadroBasico { get; set; }

        public virtual CuadroBasico CuadroBasico { get; set; }

        public virtual TipoTabulador TipoTabulador { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedimientoEspecialidad> ProcedimientoEspecialidad { get; set; }
    }
}
