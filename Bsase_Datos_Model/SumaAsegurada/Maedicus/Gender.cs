namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Gender")]
    public partial class Gender
    {
        public int Id { get; set; }

        [StringLength(1)]
        public string Code { get; set; }

        [StringLength(20)]
        public string Description { get; set; }

        public bool Active { get; set; }
    }
}
