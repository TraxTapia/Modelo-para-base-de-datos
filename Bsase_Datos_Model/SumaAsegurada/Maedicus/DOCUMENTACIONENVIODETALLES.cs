namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DOCUMENTACIONENVIODETALLES
    {
        public int Id { get; set; }

        public int envio { get; set; }

        [Required]
        [StringLength(50)]
        public string iCodAfiliado { get; set; }

        [Required]
        [StringLength(50)]
        public string nombre { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_Paterno { get; set; }

        [Required]
        [StringLength(50)]
        public string apellido_Materno { get; set; }

        [Required]
        [StringLength(50)]
        public string parentesco { get; set; }

        [Required]
        [StringLength(50)]
        public string poliza { get; set; }

        [Required]
        [StringLength(50)]
        public string contrato { get; set; }

        [Required]
        [StringLength(50)]
        public string certificado { get; set; }

        [Required]
        [StringLength(50)]
        public string clave_Plan { get; set; }

        [Required]
        [StringLength(255)]
        public string plan_dsc { get; set; }

        [Required]
        [StringLength(50)]
        public string archivo_Original { get; set; }

        [Required]
        [StringLength(50)]
        public string archivo_Final { get; set; }

        [Required]
        [StringLength(255)]
        public string email { get; set; }

        [Required]
        [StringLength(255)]
        public string email_Agente { get; set; }

        [Required]
        [StringLength(255)]
        public string email_Promotor { get; set; }

        [Required]
        [StringLength(255)]
        public string email_Ejecutivo { get; set; }

        public bool envioxeMail { get; set; }

        public bool envioxftp { get; set; }

        [Required]
        [StringLength(25)]
        public string num_Solicitud { get; set; }

        public DateTime? fecha_Envio { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        [StringLength(50)]
        public string vigencia { get; set; }

        [StringLength(80)]
        public string AgrupacionCG { get; set; }

        public bool GeneralConditions { get; set; }

        public virtual DOCUMENTACIONENVIO DOCUMENTACIONENVIO { get; set; }
    }
}
