namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wsTransaccionLogBK")]
    public partial class wsTransaccionLogBK
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idTransaccion { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FechaSolicitud { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "xml")]
        public string XmlEntrada { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Error { get; set; }

        [Column(TypeName = "xml")]
        public string Resultado { get; set; }

        public DateTime? FechaRespuesta { get; set; }
    }
}
