namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class producto_tabulador
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTabulador { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string codProducto { get; set; }

        [StringLength(250)]
        public string Descripcion { get; set; }

        public virtual TabuladorClinicas TabuladorClinicas { get; set; }
    }
}
