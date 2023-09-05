namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GuiaForanea")]
    public partial class GuiaForanea
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodGuiaForanea { get; set; }

        [StringLength(50)]
        public string NumeroGuia { get; set; }

        public DateTime? FechaGuia { get; set; }

        [StringLength(100)]
        public string Remitente { get; set; }

        public DateTime? FechaRecepcion { get; set; }

        [StringLength(100)]
        public string QuienRecepciona { get; set; }

        public int? CantidadFacturas { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public DateTime? FechaCaptura { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
