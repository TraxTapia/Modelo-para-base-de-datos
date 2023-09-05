namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RepEmailLog_TB
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdRep { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Adjunto { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Excel { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Envio { get; set; }

        public string Mensaje { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime Ifecha { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime Ffecha { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool EstatusRep { get; set; }
    }
}
