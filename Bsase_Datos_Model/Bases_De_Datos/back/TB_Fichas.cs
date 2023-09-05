namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.TB_Fichas")]
    public partial class TB_Fichas
    {
        [Key]
        public int IdFicha { get; set; }

        [StringLength(50)]
        public string Nomina { get; set; }

        [StringLength(150)]
        public string Nombre { get; set; }

        public DateTime? FNacimiento { get; set; }

        public int? Edad { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(50)]
        public string CURP { get; set; }

        [StringLength(255)]
        public string Ocupación { get; set; }

        public int? CVE_ENT { get; set; }

        public int? CVE_MUN { get; set; }

        public int? CVE_LOC { get; set; }

        [StringLength(150)]
        public string LugarResid { get; set; }

        [StringLength(255)]
        public string Direccion { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(150)]
        public string Email { get; set; }

        public DateTime? Fecha_Captura { get; set; }

        [StringLength(50)]
        public string Usuario_Captura { get; set; }
    }
}
