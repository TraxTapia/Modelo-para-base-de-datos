namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RelacionCartaMP")]
    public partial class RelacionCartaMP
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string producto { get; set; }

        [StringLength(40)]
        public string poliza { get; set; }

        [StringLength(200)]
        public string carta { get; set; }

        [StringLength(200)]
        public string talon { get; set; }

        public byte? activo { get; set; }

        public DateTime? Fecha { get; set; }
    }
}
