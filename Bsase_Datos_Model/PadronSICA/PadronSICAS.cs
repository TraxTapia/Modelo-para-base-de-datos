namespace Bsase_Datos_Model.PadronSICA
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PadronSICAS
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string ICodCobertura { get; set; }

        [Required]
        [StringLength(250)]
        public string VCHCodProducto { get; set; }
    }
}
