namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sami_Reportes_Listado
    {
        [Key]
        [Column(Order = 0)]
        public int idReporte { get; set; }

        [StringLength(100)]
        public string NombreReporte { get; set; }

        [StringLength(200)]
        public string DescripcionReporte { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrdenAparece { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }
    }
}
