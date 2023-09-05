namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CopagoValidador")]
    public partial class CopagoValidador
    {
        public int Id { get; set; }

        public int ValidateDetails_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FolioMed { get; set; }

        [Required]
        [StringLength(50)]
        public string AutorizacionMed { get; set; }

        [Required]
        [StringLength(500)]
        public string Descripcion_med { get; set; }

        public decimal ImporteLP { get; set; }

        public decimal ImporteDespuesCopago { get; set; }

        public decimal ImporteAntesCopago { get; set; }

        public decimal ImporteDescuentoFarmacia { get; set; }

        public decimal ImporteDespuesDescuento { get; set; }

        public decimal ImporteAntesCopagoPorCantidad { get; set; }
    }
}
