namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CuadroBasico")]
    public partial class CuadroBasico
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CuadroBasico()
        {
            Procedimiento = new HashSet<Procedimiento>();
        }

        [Key]
        [StringLength(20)]
        public string CodCuadroBasico { get; set; }

        [Required]
        [StringLength(20)]
        public string CodigoEAN { get; set; }

        [Required]
        [StringLength(50)]
        public string Medicamento { get; set; }

        [StringLength(50)]
        public string SubstanciaActiva { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Procedimiento> Procedimiento { get; set; }
    }
}
