namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class consultaElectronicaHSADetalle_sase
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConsecutivoMed { get; set; }

        [StringLength(50)]
        public string codAutorizacion { get; set; }

        [StringLength(50)]
        public string codEspecialidad { get; set; }

        [StringLength(50)]
        public string Autorizacion { get; set; }

        [StringLength(50)]
        public string Cpt { get; set; }

        [StringLength(10)]
        public string CodTabulador { get; set; }

        public int? Cantidad { get; set; }

        public double? PU { get; set; }

        public double? Total { get; set; }

        [StringLength(10)]
        public string CopagoEn { get; set; }

        public int? Copago { get; set; }

        [StringLength(300)]
        public string Descripcion { get; set; }

        [StringLength(8000)]
        public string Indicaciones { get; set; }

        public bool? IsFacturado { get; set; }
    }
}
