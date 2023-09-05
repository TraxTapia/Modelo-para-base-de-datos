namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMI_Tarjetas_Producto
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string codProducto { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Campos { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(250)]
        public string titulo { get; set; }

        [Key]
        [Column(Order = 4)]
        public string PFilas { get; set; }

        public string PColumnas { get; set; }

        public bool? visible { get; set; }

        public virtual EMI_Tarjetas_Catalogo EMI_Tarjetas_Catalogo { get; set; }
    }
}
