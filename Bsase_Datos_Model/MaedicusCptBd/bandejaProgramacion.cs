namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bandejaProgramacion")]
    public partial class bandejaProgramacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folio { get; set; }

        public DateTime? fechaServicio { get; set; }

        [StringLength(50)]
        public string elegibilidad { get; set; }

        public int? codempresa { get; set; }

        [StringLength(50)]
        public string codafiliado { get; set; }

        public int? correlativo { get; set; }

        [StringLength(50)]
        public string cve_provMedico { get; set; }

        public int? viaRecepcion { get; set; }

        [Column(TypeName = "text")]
        public string descProgramacion { get; set; }

        [StringLength(50)]
        public string cpt1 { get; set; }

        [StringLength(50)]
        public string cpt2 { get; set; }

        [StringLength(50)]
        public string cpt3 { get; set; }

        [StringLength(50)]
        public string cie1 { get; set; }

        [StringLength(50)]
        public string cie2 { get; set; }

        [StringLength(50)]
        public string cve_provHosp { get; set; }

        public DateTime? fechaRecepcion { get; set; }

        public DateTime? fechaProgramacion { get; set; }

        [StringLength(50)]
        public string horaProgramacion { get; set; }

        [StringLength(50)]
        public string responsable { get; set; }

        [StringLength(50)]
        public string contacto { get; set; }

        public int? tipoFactura { get; set; }

        public DateTime? fechaIngreso { get; set; }

        [StringLength(50)]
        public string horaIngreso { get; set; }

        public int? tipoIngreso { get; set; }

        public int? tipoPaciente { get; set; }

        [Column(TypeName = "text")]
        public string datosExploracion { get; set; }

        [Column(TypeName = "text")]
        public string estudiosLaboratorio { get; set; }

        [Column(TypeName = "text")]
        public string estudiosGabinete { get; set; }

        public DateTime? fechaGenerarion { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [Column(TypeName = "text")]
        public string obsAutorizacion { get; set; }

        [StringLength(50)]
        public string honCirujano { get; set; }

        [StringLength(50)]
        public string honAnestesiologo { get; set; }

        [StringLength(50)]
        public string hon1erAyud { get; set; }

        [StringLength(50)]
        public string hon2doAyud { get; set; }

        [Column(TypeName = "text")]
        public string indicacionesMedico { get; set; }

        [Column(TypeName = "text")]
        public string indicacionesPaciente { get; set; }

        [Column(TypeName = "text")]
        public string indicacionesHospital { get; set; }

        public int? codEstatus { get; set; }

        [Column(TypeName = "text")]
        public string observacionPendiente { get; set; }

        public int? estatusImpresion { get; set; }

        [StringLength(20)]
        public string folioReceta { get; set; }

        [StringLength(50)]
        public string cve_usuario { get; set; }
    }
}
