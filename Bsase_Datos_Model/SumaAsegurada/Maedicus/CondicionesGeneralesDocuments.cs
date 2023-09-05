namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CondicionesGeneralesDocuments
    {
        public int Id { get; set; }

        public int CondicionesGenerales_Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Archivo { get; set; }

        [Required]
        [StringLength(50)]
        public string Size { get; set; }

        public virtual CondicionesGenerales CondicionesGenerales { get; set; }
    }
}
