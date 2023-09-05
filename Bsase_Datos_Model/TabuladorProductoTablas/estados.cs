namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class estados
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(4)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string Estado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodSICAS { get; set; }

        [StringLength(10)]
        public string CodHSBC { get; set; }

        public bool? SN_Activo { get; set; }
    }
}
