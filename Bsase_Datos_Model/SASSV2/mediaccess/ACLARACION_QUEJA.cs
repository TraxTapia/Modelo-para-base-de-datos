namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACLARACION_QUEJA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodQuejaAclaracion { get; set; }

        [StringLength(50)]
        public string QuejaAclaracion { get; set; }
    }
}
