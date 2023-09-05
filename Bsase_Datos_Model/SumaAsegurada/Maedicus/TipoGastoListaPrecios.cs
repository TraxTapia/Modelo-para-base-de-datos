namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TipoGastoListaPrecios
    {
        public int Id { get; set; }

        public int TipoGastoID { get; set; }

        public decimal Porcentaje { get; set; }

        [Required]
        [StringLength(5)]
        public string TipoCaracter { get; set; }

        [Required]
        [StringLength(250)]
        public string Usuario { get; set; }

        public DateTime FechaAlta { get; set; }

        public DateTime? FechaBaja { get; set; }

        [Required]
        [StringLength(300)]
        public string Justificacion { get; set; }

        public bool Activo { get; set; }

        public virtual TipoGasto TipoGasto { get; set; }
    }
}
