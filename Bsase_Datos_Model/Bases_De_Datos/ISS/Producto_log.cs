namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Producto_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(500)]
        public string Producto { get; set; }

        [StringLength(500)]
        public string descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        [StringLength(1)]
        public string Estatus { get; set; }

        public int? idProducto { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string xusrInsert { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime xDateInsert { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(75)]
        public string Evento { get; set; }
    }
}
