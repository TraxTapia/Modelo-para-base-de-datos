namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Escolaridad")]
    public partial class Escolaridad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_esc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(25)]
        public string des_esc { get; set; }
    }
}
