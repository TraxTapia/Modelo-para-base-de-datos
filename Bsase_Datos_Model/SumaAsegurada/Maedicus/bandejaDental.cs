namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bandejaDental")]
    public partial class bandejaDental
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
        public string descDental { get; set; }

        [StringLength(50)]
        public string cpt1 { get; set; }

        public int? cantidad1 { get; set; }

        [StringLength(50)]
        public string cpt2 { get; set; }

        public int? cantidad2 { get; set; }

        [StringLength(50)]
        public string cpt3 { get; set; }

        public int? cantidad3 { get; set; }

        [StringLength(50)]
        public string cpt4 { get; set; }

        public int? cantidad4 { get; set; }

        [StringLength(50)]
        public string cpt5 { get; set; }

        public int? cantidad5 { get; set; }

        [StringLength(50)]
        public string cpt6 { get; set; }

        public int? cantidad6 { get; set; }

        [StringLength(50)]
        public string cpt7 { get; set; }

        public int? cantidad7 { get; set; }

        [StringLength(50)]
        public string cpt8 { get; set; }

        public int? cantidad8 { get; set; }

        [StringLength(50)]
        public string cie1 { get; set; }

        [StringLength(50)]
        public string cie2 { get; set; }

        [StringLength(50)]
        public string cve_provRealiza { get; set; }

        public DateTime? fechaRecepcion { get; set; }

        [Column(TypeName = "text")]
        public string datosExploracion { get; set; }

        public DateTime? fechaGenerarion { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        [Column(TypeName = "text")]
        public string obsAutorizacion { get; set; }

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
    }
}
