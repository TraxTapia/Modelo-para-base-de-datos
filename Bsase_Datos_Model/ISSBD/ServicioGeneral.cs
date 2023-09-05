namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicioGeneral")]
    public partial class ServicioGeneral
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ServicioGeneral()
        {
            PaseEspecialista = new HashSet<PaseEspecialista>();
            ServicioReferido = new HashSet<ServicioReferido>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodServicioGeneral { get; set; }

        [Required]
        [StringLength(8)]
        public string Folio { get; set; }

        public int CodProveedor { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public int Correlativo { get; set; }

        public DateTime FechaConsulta { get; set; }

        public int TipoConsulta { get; set; }

        public int MotivoConsulta { get; set; }

        public double? Peso { get; set; }

        public double? Estatura { get; set; }

        [StringLength(9)]
        public string Presion { get; set; }

        [Required]
        [StringLength(20)]
        public string CodProcedimiento1 { get; set; }

        [StringLength(20)]
        public string CodProcedimiento2 { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PaseEspecialista> PaseEspecialista { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ServicioReferido> ServicioReferido { get; set; }
    }
}
