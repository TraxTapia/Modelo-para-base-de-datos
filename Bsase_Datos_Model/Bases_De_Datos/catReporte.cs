namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("catReporte")]
    public partial class catReporte
    {
        [Key]
        public int idReporte { get; set; }

        [StringLength(150)]
        public string nombreReporte { get; set; }

        [StringLength(100)]
        public string contructorReporte { get; set; }
    }
}
