namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Xmlcadena")]
    public partial class Xmlcadena
    {
        public int ID { get; set; }

        [Column(TypeName = "xml")]
        public string cadena { get; set; }

        [StringLength(20)]
        public string proceso { get; set; }
    }
}
