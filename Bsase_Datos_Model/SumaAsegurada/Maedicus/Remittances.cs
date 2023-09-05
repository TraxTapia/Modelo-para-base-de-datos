namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remittances
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Code { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public bool Visible { get; set; }

        public int MacSequence { get; set; }

        public double Total { get; set; }
    }
}
