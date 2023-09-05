namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogProcedimientos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOperacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConfigTraceProcedimientos_ID { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaOcurrido { get; set; }
    }
}
