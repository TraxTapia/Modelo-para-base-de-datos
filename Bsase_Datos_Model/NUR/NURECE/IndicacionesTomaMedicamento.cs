namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("IndicacionesTomaMedicamento")]
    public partial class IndicacionesTomaMedicamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string EAN { get; set; }

        public int CantidadUnidades { get; set; }

        public int ViaDeAdmonMedicamentoId { get; set; }

        public int CantidadToma { get; set; }

        public int FrecuenciaDeToma { get; set; }

        public int FrecuenciaUnidadDeTiempoId { get; set; }

        public int DuracionDeToma { get; set; }

        public int DuracionUnidadDeTiempoId { get; set; }

        [Required]
        [StringLength(30)]
        public string Unidad { get; set; }

        [Required]
        [StringLength(500)]
        public string Observaciones { get; set; }

        [Required]
        [StringLength(30)]
        public string NUR { get; set; }
    }
}
