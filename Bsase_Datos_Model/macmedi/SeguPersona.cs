namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SeguPersona")]
    public partial class SeguPersona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPersona { get; set; }

        [StringLength(100)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string Cargo { get; set; }

        [StringLength(50)]
        public string Email1 { get; set; }

        [StringLength(50)]
        public string Email2 { get; set; }
    }
}
