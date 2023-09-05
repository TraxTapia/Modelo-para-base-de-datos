namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorConsulta")]
    public partial class TabuladorConsulta
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(2)]
        public string codZona { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CPT { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodTipoGasto { get; set; }

        public double Costo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        public DateTime fechaActualizacion { get; set; }
    }
}
