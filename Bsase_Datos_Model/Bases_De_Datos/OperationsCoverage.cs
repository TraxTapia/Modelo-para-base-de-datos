namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationsCoverage")]
    public partial class OperationsCoverage
    {
        public int Id { get; set; }

        public int Operation_Id { get; set; }

        public int Cobertura_Id { get; set; }

        public int? TipoCopago { get; set; }

        [StringLength(100)]
        public string Cobertura { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
