namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NotFounded_UUID
    {
        public int Id { get; set; }

        [Required]
        [StringLength(36)]
        public string UUID { get; set; }

        [Required]
        [StringLength(50)]
        public string TransmitterRFC { get; set; }

        public DateTime DateBill { get; set; }

        public decimal Subtotal { get; set; }

        public decimal IVA { get; set; }

        public decimal Total { get; set; }

        public decimal Discount { get; set; }

        [StringLength(50)]
        public string Serie { get; set; }

        [StringLength(50)]
        public string BillNumber { get; set; }

        public DateTime DateStamped { get; set; }
    }
}
