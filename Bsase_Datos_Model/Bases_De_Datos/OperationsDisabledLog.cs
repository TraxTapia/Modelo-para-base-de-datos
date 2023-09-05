namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationsDisabledLog")]
    public partial class OperationsDisabledLog
    {
        public int Id { get; set; }

        public int Operation_Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(256)]
        public string User { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
