namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPTGeneral")]
    public partial class CPTGeneral
    {
        [Required]
        [StringLength(20)]
        public string CPT { get; set; }

        public int CodEmpresa { get; set; }

        [StringLength(1000)]
        public string DescripcionCorta { get; set; }

        [StringLength(1000)]
        public string DescripcionLarga { get; set; }

        public double? Porcentaje { get; set; }

        [Required]
        [StringLength(2)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string Lugar { get; set; }

        [StringLength(2)]
        public string CodEstatus { get; set; }

        public int Id { get; set; }
    }
}
