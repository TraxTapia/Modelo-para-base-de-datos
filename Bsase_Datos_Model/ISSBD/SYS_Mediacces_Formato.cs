namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SYS_Mediacces_Formato
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Formato { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Columnas { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Tabla { get; set; }

        public string Sqlcmd { get; set; }

        public string Parametros { get; set; }
    }
}
