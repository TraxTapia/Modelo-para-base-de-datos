namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estatusCirugiaProramada")]
    public partial class estatusCirugiaProramada
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codEstatus { get; set; }

        [StringLength(50)]
        public string estatusSeguimiento { get; set; }
    }
}
