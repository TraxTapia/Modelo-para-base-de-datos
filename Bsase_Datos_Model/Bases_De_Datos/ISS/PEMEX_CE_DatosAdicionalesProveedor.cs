namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PEMEX_CE_DatosAdicionalesProveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [StringLength(255)]
        public string ResponsablePemex { get; set; }

        [StringLength(60)]
        public string TelResponsable { get; set; }

        [StringLength(150)]
        public string EmailResp { get; set; }

        [StringLength(255)]
        public string Localidad { get; set; }

        [StringLength(255)]
        public string Estado { get; set; }

        [StringLength(255)]
        public string SupervicionSec { get; set; }

        [StringLength(255)]
        public string NombreCordMed { get; set; }

        [StringLength(255)]
        public string ApatCordMed { get; set; }

        [StringLength(255)]
        public string AmatCordMed { get; set; }

        [StringLength(255)]
        public string EmailCordMed { get; set; }

        [StringLength(255)]
        public string TelCordMed { get; set; }

        [StringLength(255)]
        public string CelCordMed { get; set; }

        [StringLength(255)]
        public string Cordinacion { get; set; }

        [StringLength(255)]
        public string Region { get; set; }
    }
}
