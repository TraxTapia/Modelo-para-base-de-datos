namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("asd")]
    public partial class asd
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int a { get; set; }
    }
}
