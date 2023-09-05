namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorGeneral")]
    public partial class TabuladorGeneral
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string IdCodTabulador { get; set; }

        public int? CodTabuladorCliente { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CPT { get; set; }

        [Key]
        [Column(Order = 3)]
        public double Costo { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [StringLength(10)]
        public string CveProv { get; set; }

        [StringLength(5)]
        public string CodEstado { get; set; }

        public int? CodPoblacion { get; set; }

        [StringLength(4)]
        public string CveEspec { get; set; }

        [StringLength(2)]
        public string CodZona { get; set; }

        public int? CodTipoGasto { get; set; }

        [StringLength(2)]
        public string CodEstatus { get; set; }

        public int? IdAgrupado { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? codPyme { get; set; }
    }
}
