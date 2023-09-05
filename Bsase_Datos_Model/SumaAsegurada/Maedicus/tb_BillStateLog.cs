namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TransfB.tb_BillStateLog")]
    public partial class tb_BillStateLog
    {
        public int Id { get; set; }

        public int tb_BillFile_Id { get; set; }

        public int tb_BillState_Id { get; set; }

        public int tb_BillState_NewId { get; set; }

        [Required]
        [StringLength(100)]
        public string User { get; set; }

        public DateTime Date { get; set; }

        public virtual tb_BillFile tb_BillFile { get; set; }

        public virtual tb_BillState tb_BillState { get; set; }

        public virtual tb_BillState tb_BillState1 { get; set; }
    }
}
