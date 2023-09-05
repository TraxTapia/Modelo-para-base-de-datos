namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("wsTransaccionLog")]
    public partial class wsTransaccionLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long idTransaccion { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime FechaSolicitud { get; set; }

        [Column(TypeName = "xml")]
        [Required]
        public string XmlEntrada { get; set; }

        public bool Error { get; set; }

        [Column(TypeName = "xml")]
        public string Resultado { get; set; }

        public DateTime? FechaRespuesta { get; set; }
    }
}
