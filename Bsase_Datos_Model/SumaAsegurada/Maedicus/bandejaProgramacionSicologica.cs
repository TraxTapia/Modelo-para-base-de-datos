namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bandejaProgramacionSicologica")]
    public partial class bandejaProgramacionSicologica
    {
        [Key]
        public int idsesion { get; set; }

        public int folio_xk { get; set; }

        [StringLength(50)]
        public string codafiliado_xk { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaTermino { get; set; }

        [StringLength(50)]
        public string frecuencia { get; set; }

        public int? autorizadas { get; set; }

        public int? codEstatus { get; set; }

        [Column(TypeName = "text")]
        public string observaciones { get; set; }
    }
}
