namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguimientoLlamada")]
    public partial class SeguimientoLlamada
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cve_seguimiento { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CveBanEntEM { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CveRespCoor { get; set; }

        [StringLength(50)]
        public string Folio { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(50)]
        public string Usr { get; set; }

        [StringLength(50)]
        public string Observacion { get; set; }
    }
}
