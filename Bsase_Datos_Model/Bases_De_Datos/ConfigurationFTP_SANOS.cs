namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConfigurationFTP_SANOS
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FTPServerIP { get; set; }

        [Required]
        [StringLength(50)]
        public string FTPUser { get; set; }

        [Required]
        [StringLength(100)]
        public string FTPPassword { get; set; }
    }
}
