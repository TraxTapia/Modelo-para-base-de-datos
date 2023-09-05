namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("elegibilidadessinpase")]
    public partial class elegibilidadessinpase
    {
        [StringLength(50)]
        public string elegibilidad { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string nomina { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numbenef { get; set; }
    }
}
