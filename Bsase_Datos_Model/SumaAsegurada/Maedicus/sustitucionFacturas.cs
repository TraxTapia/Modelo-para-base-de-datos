namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sustitucionFacturas
    {
        [StringLength(50)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string no_fac { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        [StringLength(50)]
        public string no_facNueva { get; set; }

        public int? SecuenciaMac { get; set; }

        public int Id { get; set; }

        public virtual Facturas Facturas { get; set; }
    }
}
