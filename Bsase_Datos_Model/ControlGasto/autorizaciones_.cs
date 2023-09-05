namespace Bsase_Datos_Model.ControlGasto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.autorizaciones#")]
    public partial class autorizaciones_
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodAutorizacion { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(15)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }
    }
}
