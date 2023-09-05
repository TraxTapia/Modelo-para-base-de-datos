namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Especialidad")]
    public partial class Especialidad
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Especialidad()
        {
            Recursos_Medicos = new HashSet<Recursos_Medicos>();
        }

        [Key]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Column("Especialidad")]
        [Required]
        [StringLength(100)]
        public string Especialidad1 { get; set; }

        public int CodTipoGasto { get; set; }

        [StringLength(10)]
        public string Articulo_con_Retencion { get; set; }

        [StringLength(50)]
        public string Articulo_sin_Retencion { get; set; }

        public virtual TipoGasto TipoGasto { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recursos_Medicos> Recursos_Medicos { get; set; }
    }
}
