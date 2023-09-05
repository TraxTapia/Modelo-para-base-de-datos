namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CartasWellnessExterno")]
    public partial class CartasWellnessExterno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CartasWellnessExterno()
        {
            CartasWellnessInterno = new HashSet<CartasWellnessInterno>();
        }

        [Key]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime FechaFin { get; set; }

        [Required]
        [StringLength(2)]
        public string Genero { get; set; }

        [Required]
        [StringLength(50)]
        public string Estado { get; set; }

        public int Fase { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartasWellnessInterno> CartasWellnessInterno { get; set; }
    }
}
