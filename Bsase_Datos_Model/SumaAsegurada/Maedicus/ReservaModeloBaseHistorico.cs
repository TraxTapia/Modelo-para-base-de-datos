namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ReservaModeloBaseHistorico")]
    public partial class ReservaModeloBaseHistorico
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string CodigoServicio { get; set; }

        public int IdCuadroMedicamento { get; set; }

        public int IdTipoCatalogo { get; set; }

        [Column(TypeName = "date")]
        public DateTime dia { get; set; }

        public int IdTipoCalculo { get; set; }

        public decimal Monto { get; set; }
    }
}
