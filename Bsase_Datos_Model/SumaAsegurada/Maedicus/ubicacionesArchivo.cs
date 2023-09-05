namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ubicacionesArchivo")]
    public partial class ubicacionesArchivo
    {
        [Key]
        public int idUbicacionArchivo { get; set; }

        [StringLength(50)]
        public string ubicacionArchivo { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string responsable { get; set; }
    }
}
