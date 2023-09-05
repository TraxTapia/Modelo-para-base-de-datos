namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogControlGastoManual")]
    public partial class LogControlGastoManual
    {
        [Key]
        public int IdLog { get; set; }

        public int IdCGD { get; set; }

        [Required]
        [StringLength(50)]
        public string Autorizacion { get; set; }

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
