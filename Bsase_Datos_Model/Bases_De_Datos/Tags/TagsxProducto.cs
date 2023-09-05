namespace Bsase_Datos_Model.Bases_De_Datos.Tags
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TagsxProducto")]
    public partial class TagsxProducto
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(40)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTag { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codPlan { get; set; }
    }
}
