namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CPTEmpresaPeriodicidad")]
    public partial class CPTEmpresaPeriodicidad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AgrupacionId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CPT { get; set; }

        [Required]
        [StringLength(20)]
        public string CPTEmpresa { get; set; }

        public byte AreaId { get; set; }

        public short EspecialidadId { get; set; }

        [Required]
        [StringLength(255)]
        public string Prestacion { get; set; }

        public short PeriodicidadCantidad { get; set; }

        public byte PeriodicidadUnidadId { get; set; }

        public bool BocaCompleta { get; set; }
    }
}
