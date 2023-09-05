namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.autorizacionesMI#")]
    public partial class autorizacionesMI_
    {
        [StringLength(20)]
        public string autorizacion { get; set; }

        public int? codcuenta { get; set; }

        [StringLength(100)]
        public string codafiliado { get; set; }

        public int? correlativo { get; set; }

        [StringLength(10)]
        public string codempresa { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codautorizacion { get; set; }

        [StringLength(15)]
        public string xusrinsert { get; set; }

        public DateTime? xdateinsert { get; set; }

        [StringLength(10)]
        public string fechaRegistro { get; set; }

        [StringLength(50)]
        public string elegibilidad { get; set; }

        [StringLength(50)]
        public string autorizacionMI { get; set; }
    }
}
