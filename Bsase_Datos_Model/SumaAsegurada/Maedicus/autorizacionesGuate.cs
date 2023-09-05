namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("autorizacionesGuate")]
    public partial class autorizacionesGuate
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodAutorizacion { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }
    }
}
