namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CaptureChangeLog")]
    public partial class CaptureChangeLog
    {
        public int Id { get; set; }

        public int MacSequenceReturned { get; set; }

        public int MacSequenceCapture { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public int Rows { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual Facturas Facturas1 { get; set; }
    }
}
