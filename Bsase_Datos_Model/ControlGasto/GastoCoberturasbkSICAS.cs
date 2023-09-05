namespace Bsase_Datos_Model.ControlGasto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.GastoCoberturasbkSICAS")]
    public partial class GastoCoberturasbkSICAS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLista { get; set; }

        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [StringLength(50)]
        public string Correlativo { get; set; }

        [StringLength(50)]
        public string CodCobertura { get; set; }

        public int? CodEmpresa { get; set; }

        [StringLength(50)]
        public string Autorizacion { get; set; }

        public DateTime? Fecha { get; set; }

        public double? TotalGasto { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        [StringLength(10)]
        public string Estatus { get; set; }

        public int? codTipoCuenta { get; set; }

        [StringLength(50)]
        public string codEspecialidad { get; set; }

        [StringLength(50)]
        public string codCuenta { get; set; }
    }
}
