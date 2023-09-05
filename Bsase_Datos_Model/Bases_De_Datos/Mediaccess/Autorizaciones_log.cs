namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Autorizaciones_log
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodAutorizacion { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAutorizacion { get; set; }

        [StringLength(100)]
        public string UsrInsert { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime fechaInsert { get; set; }

        public string observaciones { get; set; }
    }
}
