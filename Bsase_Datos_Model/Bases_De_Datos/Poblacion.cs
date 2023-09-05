namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Poblacion")]
    public partial class Poblacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Poblacion()
        {
            Recursos_Medicos = new HashSet<Recursos_Medicos>();
        }

        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPoblacion { get; set; }

        [Column("Poblacion")]
        [Required]
        [StringLength(100)]
        public string Poblacion1 { get; set; }

        public int CodZona { get; set; }

        public int? codCritica { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recursos_Medicos> Recursos_Medicos { get; set; }
    }
}
