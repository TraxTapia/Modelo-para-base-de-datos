namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UbicacionVendedor")]
    public partial class UbicacionVendedor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodVendedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodUbicacion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Required]
        [StringLength(4)]
        public string CodEstado { get; set; }

        public int CodPoblacion { get; set; }

        public int CodColonia { get; set; }

        [Required]
        [StringLength(5)]
        public string CP { get; set; }

        public virtual Colonia Colonia { get; set; }

        public virtual TipoUbicacion TipoUbicacion { get; set; }

        public virtual Vendedor Vendedor { get; set; }
    }
}
