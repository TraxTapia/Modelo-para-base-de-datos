namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cuestionario")]
    public partial class Cuestionario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_cues { get; set; }

        [StringLength(25)]
        public string nom_cues { get; set; }

        [StringLength(300)]
        public string des_cues { get; set; }
    }
}
