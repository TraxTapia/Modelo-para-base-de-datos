namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.bandejaPrueba")]
    public partial class bandejaPrueba
    {
        [Key]
        public int codbandeja { get; set; }

        [StringLength(50)]
        public string datos { get; set; }
    }
}
