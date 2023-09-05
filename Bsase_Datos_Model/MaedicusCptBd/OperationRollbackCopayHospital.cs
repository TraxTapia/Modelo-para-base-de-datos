namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationRollbackCopayHospital")]
    public partial class OperationRollbackCopayHospital
    {
        public int Id { get; set; }

        public int CopayApplied_Id { get; set; }

        public int Operation_Id { get; set; }

        public decimal Importe { get; set; }

        public decimal IVA { get; set; }

        public decimal ISR { get; set; }

        public decimal Retiva { get; set; }

        public decimal ImpCedular { get; set; }

        public decimal Total { get; set; }

        public bool Active { get; set; }

        public decimal ImporteCopago { get; set; }

        public decimal ImporteAntesCopago { get; set; }

        public decimal ImporteDespuesCopago { get; set; }

        public virtual CopayApplied CopayApplied { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
