namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GastoMedicamentos
    {
        [Key]
        public int idLista { get; set; }

        [Required]
        [StringLength(50)]
        public string CodEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Required]
        [StringLength(50)]
        public string Correlativo { get; set; }

        public int CodCuenta { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoConsulta { get; set; }

        [Required]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        public DateTime Fecha { get; set; }

        public double MontoConsulta { get; set; }

        public double MontoCopago { get; set; }

        public double TotalGasto { get; set; }

        [Required]
        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public int Estatus { get; set; }
    }
}
