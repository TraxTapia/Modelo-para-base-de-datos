namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class cptgeneral_log
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CPT { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [StringLength(1000)]
        public string DescripcionCorta { get; set; }

        [StringLength(1000)]
        public string DescripcionLarga { get; set; }

        public double? Porcentaje { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string Lugar { get; set; }

        [StringLength(2)]
        public string CodEstatus { get; set; }

        public DateTime? FechaInsersion { get; set; }

        [StringLength(20)]
        public string UserInsert { get; set; }
    }
}
