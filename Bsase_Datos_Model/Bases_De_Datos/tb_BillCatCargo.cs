namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillCatCargo")]
    public partial class tb_BillCatCargo
    {
        public int Id { get; set; }

        public int tb_BillAccount_id { get; set; }

        [Required]
        [StringLength(50)]
        public string CompanyKey { get; set; }

        public bool State { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public DateTime ProcessDate { get; set; }

        public string Message { get; set; }

        public virtual tb_BillAccount tb_BillAccount { get; set; }
    }
}
