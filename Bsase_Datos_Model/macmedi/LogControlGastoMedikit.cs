namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogControlGastoMedikit")]
    public partial class LogControlGastoMedikit
    {
        [Key]
        public int IdLog { get; set; }

        public int IdCGD { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        [Required]
        [StringLength(20)]
        public string CodProcedimientoInicial { get; set; }

        public decimal ImporteInicial { get; set; }

        public decimal TotalInicial { get; set; }

        public int CantidadInicial { get; set; }

        [Required]
        [StringLength(20)]
        public string CodProcedimientoFinal { get; set; }

        public decimal ImporteFinal { get; set; }

        public decimal TotalFinal { get; set; }

        public int CantidadFinal { get; set; }

        public DateTime Fecha { get; set; }
    }
}
