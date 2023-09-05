namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Agrupacion_Productos_log
    {
        [Key]
        [Column(Order = 0)]
        public int IdAgrupacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string codProducto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codGrupo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codRed { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool IsEspecialidad { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(2)]
        public string UsrInsert { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaInsert { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(168)]
        public string observaciones { get; set; }
    }
}
