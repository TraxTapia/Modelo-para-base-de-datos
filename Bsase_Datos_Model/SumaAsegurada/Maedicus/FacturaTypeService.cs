namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FacturaTypeService")]
    public partial class FacturaTypeService
    {
        public int Id { get; set; }

        public int SecuenciaMAC { get; set; }

        public int TypeService_Id { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual TypeService TypeService { get; set; }
    }
}
