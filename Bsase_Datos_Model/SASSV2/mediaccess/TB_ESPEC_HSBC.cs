namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ESPEC_HSBC
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idEspec { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Espec { get; set; }

        public int? CodEspecialidad { get; set; }
    }
}
