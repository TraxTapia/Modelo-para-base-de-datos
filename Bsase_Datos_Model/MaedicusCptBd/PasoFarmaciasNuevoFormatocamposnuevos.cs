namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PasoFarmaciasNuevoFormatocamposnuevos
    {
        public int? codempresa { get; set; }

        public int? codpymecolectivo { get; set; }

        public int? codplan { get; set; }

        [StringLength(50)]
        public string codproducto { get; set; }

        [StringLength(50)]
        public string poliza { get; set; }

        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(10)]
        public string secuenciamac { get; set; }

        [Key]
        [StringLength(20)]
        public string consecutivo { get; set; }

        [StringLength(100)]
        public string id { get; set; }

        [StringLength(100)]
        public string usr { get; set; }
    }
}
