namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ExcludedProceduresByTipoGasto")]
    public partial class ExcludedProceduresByTipoGasto
    {
        public int Id { get; set; }

        [StringLength(20)]
        public string Code { get; set; }

        public int CodeExpenseType { get; set; }

        public bool Active { get; set; }

        [StringLength(60)]
        public string Description { get; set; }

        public virtual TipoGasto TipoGasto { get; set; }
    }
}
