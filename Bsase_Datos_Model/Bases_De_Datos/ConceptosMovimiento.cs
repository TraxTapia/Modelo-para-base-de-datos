namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConceptosMovimiento")]
    public partial class ConceptosMovimiento
    {
        public int Id { get; set; }

        public int Movimiento_Id { get; set; }

        public int Operation_Id { get; set; }

        public int? SubmotivosDevoluciones_Id { get; set; }

        public virtual movimientosFacturas movimientosFacturas { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
