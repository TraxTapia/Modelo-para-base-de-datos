namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Restitucion")]
    public partial class Restitucion
    {
        public int Id { get; set; }

        public DateTime FechaRestitucion { get; set; }

        public int CantidadInicial { get; set; }

        public decimal MontoUnitarioInicial { get; set; }

        public decimal MontoTotalInicial { get; set; }

        [Required]
        [StringLength(50)]
        public string CPTInicial { get; set; }

        public int CantidadFinal { get; set; }

        public decimal MontoUnitarioFinal { get; set; }

        public decimal MontoTotalFinal { get; set; }

        [Required]
        [StringLength(50)]
        public string CPTFinal { get; set; }

        public int IdGCD { get; set; }

        [Required]
        [StringLength(50)]
        public string Folio { get; set; }

        [Required]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Elegibilidad { get; set; }
    }
}
