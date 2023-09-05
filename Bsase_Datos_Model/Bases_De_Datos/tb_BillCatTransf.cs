namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillCatTransf")]
    public partial class tb_BillCatTransf
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string BankName { get; set; }

        public int? BankKey { get; set; }

        [StringLength(10)]
        public string Giro { get; set; }

        [StringLength(6)]
        public string TransferKey { get; set; }

        [StringLength(255)]
        public string Inst_Part { get; set; }
    }
}
