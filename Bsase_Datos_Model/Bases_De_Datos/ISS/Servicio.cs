namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Servicio")]
    public partial class Servicio
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Servicio()
        {
            Autorizaciones = new HashSet<Autorizaciones>();
        }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoLlamada { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CodServicio { get; set; }

        [Column("Servicio")]
        [Required]
        [StringLength(25)]
        public string Servicio1 { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusServicio { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Autorizaciones> Autorizaciones { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual MotivoLlamada MotivoLlamada { get; set; }
    }
}
