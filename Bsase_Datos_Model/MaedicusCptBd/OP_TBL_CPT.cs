namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_TBL_CPT
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Cpt { get; set; }

        [Key]
        [Column(Order = 1)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Estudio { get; set; }

        [Key]
        [Column(Order = 3)]
        public double PrecioPublico { get; set; }

        [Key]
        [Column(Order = 4)]
        public double Descuento { get; set; }

        [Key]
        [Column(Order = 5)]
        public double PrecioMAC { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codtabulador { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool CodEstatus { get; set; }

        [StringLength(5)]
        public string TipoTabulador { get; set; }
    }
}
