namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GroupersHospital")]
    public partial class GroupersHospital
    {
        public int Id { get; set; }

        [Required]
        [StringLength(3)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public bool Active { get; set; }
    }
}
