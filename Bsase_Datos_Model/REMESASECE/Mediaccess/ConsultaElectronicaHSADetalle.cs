namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConsultaElectronicaHSADetalle")]
    public partial class ConsultaElectronicaHSADetalle
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodDetalle { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Cpt { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CodTabulador { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cantidad { get; set; }

        [Key]
        [Column(Order = 5)]
        public double PU { get; set; }

        [Key]
        [Column(Order = 6)]
        public double Total { get; set; }

        [StringLength(8000)]
        public string Indicaciones { get; set; }

        public bool? PagadoFacturado { get; set; }

        [StringLength(50)]
        public string FolioDet { get; set; }
    }
}
