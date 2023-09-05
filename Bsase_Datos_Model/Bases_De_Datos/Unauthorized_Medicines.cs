namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Unauthorized_Medicines
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string EAN { get; set; }

        [Required]
        [StringLength(300)]
        public string Commercial_Name { get; set; }

        public bool? Status { get; set; }

        public DateTime? DateTime { get; set; }

        public int? CodEnterprise { get; set; }

        public int? CodPyme { get; set; }
    }
}
