namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operations_Error_Log
    {
        public int Id { get; set; }

        public int Operation_Id { get; set; }

        public int Validation_Id { get; set; }

        public bool Active { get; set; }

        public DateTime CorrectionDate { get; set; }

        [StringLength(100)]
        public string CorrectionUser { get; set; }

        public bool ManuallyCorrected { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
