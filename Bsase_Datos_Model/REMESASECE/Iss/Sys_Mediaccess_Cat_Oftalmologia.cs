namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Cat_Oftalmologia
    {
        [Key]
        public int idConcepto { get; set; }

        public int? codEmpresa { get; set; }

        [StringLength(200)]
        public string Concepto { get; set; }

        public int? PeridoEsperaMeses { get; set; }

        public bool? CrecimientoOseo { get; set; }

        [StringLength(4000)]
        public string Reglas { get; set; }
    }
}
