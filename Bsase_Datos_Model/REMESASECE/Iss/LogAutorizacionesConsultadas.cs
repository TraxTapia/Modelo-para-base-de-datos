namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LogAutorizacionesConsultadas
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string CodCuenta { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string xDateConsulta { get; set; }

        public string result { get; set; }
    }
}
