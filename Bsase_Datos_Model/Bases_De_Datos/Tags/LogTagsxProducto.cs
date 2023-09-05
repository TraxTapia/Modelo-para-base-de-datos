namespace Bsase_Datos_Model.Bases_De_Datos.Tags
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LogTagsxProducto")]
    public partial class LogTagsxProducto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(40)]
        public string CodProducto { get; set; }

        public int IdTag { get; set; }

        public int CodPlan { get; set; }

        public DateTime DateInsert { get; set; }

        [Required]
        [StringLength(100)]
        public string UserInsert { get; set; }
    }
}
