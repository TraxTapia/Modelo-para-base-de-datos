namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfigurationMail_SANOS
    {
        public int Id { get; set; }

        [Required]
        public string TemplateHTML_Confirmation { get; set; }

        [Required]
        public string TemplateHTML_Notification { get; set; }

        [Required]
        public string TemplateHTML_Error { get; set; }

        [Required]
        [StringLength(50)]
        public string MailReceives { get; set; }

        [Required]
        [StringLength(50)]
        public string MailSend { get; set; }

        [Required]
        [StringLength(50)]
        public string MailSend_Password { get; set; }

        [Required]
        [StringLength(50)]
        public string SMTP_Host { get; set; }

        public int SMTP_Port { get; set; }

        public bool MailCC_Active { get; set; }

        public bool SMTP_EnableSsl { get; set; }

        [Required]
        [StringLength(50)]
        public string MailReceives_CC1 { get; set; }

        [Required]
        [StringLength(50)]
        public string MailReceives_CC2 { get; set; }

        [Required]
        [StringLength(50)]
        public string MailReceives_CC3 { get; set; }
    }
}
