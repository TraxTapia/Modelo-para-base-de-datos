namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sepomex")]
    public partial class sepomex
    {
        public int id { get; set; }

        [StringLength(10)]
        public string codigopostal { get; set; }

        [StringLength(150)]
        public string nombre { get; set; }

        [StringLength(100)]
        public string tipo { get; set; }

        [StringLength(250)]
        public string municipio { get; set; }

        [StringLength(250)]
        public string estado { get; set; }

        public DateTime? fecha_alta { get; set; }

        public byte? activo { get; set; }
    }
}
