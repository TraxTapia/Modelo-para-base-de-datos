namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sami_TB_Factura
    {
        public int Id { get; set; }

        public string C_Proveedor { get; set; }

        public string N_Factura { get; set; }

        public string RFC { get; set; }

        public string Uuid { get; set; }

        public string Serie { get; set; }

        public string N_Xml { get; set; }

        [Column(TypeName = "xml")]
        public string A_Xml { get; set; }

        public string R_Pdf { get; set; }

        public DateTime? F_Factura { get; set; }

        [StringLength(50)]
        public string U_Insert { get; set; }

        public DateTime? F_Insert { get; set; }

        public DateTime? F_Update { get; set; }
    }
}
