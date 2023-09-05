namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class planes_log
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        [Required]
        [StringLength(100)]
        public string xUsrInsertEvento { get; set; }

        public DateTime xDateInsertEvento { get; set; }

        [Required]
        [StringLength(100)]
        public string Evento { get; set; }
    }
}
