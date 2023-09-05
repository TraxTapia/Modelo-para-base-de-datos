namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Programacion
    {
        [Key]
        public int CodCirugia { get; set; }

        public int CodEstatus { get; set; }

        [Required]
        [StringLength(100)]
        public string CodAfiliado { get; set; }

        public int CodEmpresa { get; set; }

        public int Correlativo { get; set; }

        public DateTime? xFechaInsert { get; set; }

        public DateTime? xFechaUltimoMovimiento { get; set; }

        [StringLength(100)]
        public string Autorizacion { get; set; }

        [StringLength(100)]
        public string OrigenLlamada { get; set; }

        [StringLength(100)]
        public string NombreQuienLlama { get; set; }

        [StringLength(100)]
        public string CorreoQuienLlama { get; set; }

        [StringLength(100)]
        public string TelQuienLlama { get; set; }

        public int? CodCuenta { get; set; }

        [StringLength(100)]
        public string Motivo { get; set; }

        [StringLength(100)]
        public string Servicio { get; set; }

        public int? CodHospital { get; set; }

        [StringLength(100)]
        public string Folio { get; set; }

        [Column(TypeName = "money")]
        public decimal? HonorariosCirujano { get; set; }

        [Column(TypeName = "money")]
        public decimal? HonorariosAnestesiologo { get; set; }

        [Column(TypeName = "money")]
        public decimal? HonorariosAyudante1 { get; set; }

        [Column(TypeName = "money")]
        public decimal? HonorariosAyudante2 { get; set; }

        [Column(TypeName = "money")]
        public decimal? deducible { get; set; }

        public int? coaseguro { get; set; }

        public int? Copago { get; set; }

        [StringLength(2)]
        public string CopagoEn { get; set; }

        public string Observaciones { get; set; }

        [StringLength(255)]
        public string Siniestro { get; set; }

        public string MotivoPendiente { get; set; }

        public string DescripcionSiniestro { get; set; }

        [StringLength(255)]
        public string correoHospital { get; set; }

        [StringLength(255)]
        public string correoMedicoTratante { get; set; }

        [StringLength(255)]
        public string correoPaciente { get; set; }

        [StringLength(255)]
        public string MedDictaminador { get; set; }

        [StringLength(255)]
        public string descripcionCirugia { get; set; }
    }
}
