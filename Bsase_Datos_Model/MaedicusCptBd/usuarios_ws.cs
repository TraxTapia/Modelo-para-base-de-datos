namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuarios_ws
    {
        public int id { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        [StringLength(100)]
        public string password { get; set; }

        [StringLength(1)]
        public string sistema { get; set; }

        public DateTime? fecha_alta { get; set; }

        public byte? activo { get; set; }
    }
}
