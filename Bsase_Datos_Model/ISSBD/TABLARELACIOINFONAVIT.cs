namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TABLARELACIOINFONAVIT")]
    public partial class TABLARELACIOINFONAVIT
    {
        public int CODEMPRESA { get; set; }

        [StringLength(20)]
        public string CODAFILIADO { get; set; }

        public int? CORRELATIVO { get; set; }

        [Column("ELEGIBILIDAD INCORRECTA")]
        [StringLength(20)]
        public string ELEGIBILIDAD_INCORRECTA { get; set; }

        [Column("ELEGIBILIDAD CORRECTA")]
        [StringLength(20)]
        public string ELEGIBILIDAD_CORRECTA { get; set; }

        [Column("AUTORIZACION INCORRECTA")]
        [StringLength(20)]
        public string AUTORIZACION_INCORRECTA { get; set; }

        [Column("AUTORIZACION CORRECTA")]
        [StringLength(20)]
        public string AUTORIZACION_CORRECTA { get; set; }

        [StringLength(231)]
        public string ARCHIVO { get; set; }

        [StringLength(20)]
        public string FOLIO { get; set; }

        public string ESTUDIO { get; set; }

        public bool? Cambio { get; set; }

        [StringLength(20)]
        public string Elegibilidad2 { get; set; }

        [StringLength(20)]
        public string Autorizacion2 { get; set; }

        public int Id { get; set; }
    }
}
