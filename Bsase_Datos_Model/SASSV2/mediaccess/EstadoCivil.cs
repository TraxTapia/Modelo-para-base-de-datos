namespace Bsase_Datos_Model.SASSV2.mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EstadoCivil")]
    public partial class EstadoCivil
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_civ { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string des_civ { get; set; }
    }
}
