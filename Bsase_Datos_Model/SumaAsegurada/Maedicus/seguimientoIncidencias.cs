namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class seguimientoIncidencias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folio { get; set; }

        [StringLength(20)]
        public string login { get; set; }

        public DateTime? fecha { get; set; }

        [StringLength(800)]
        public string observaciones { get; set; }

        [StringLength(50)]
        public string personaContactada { get; set; }
    }
}
