namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EnvioDocumentacionMovimientos
    {
        public int Id { get; set; }

        public int Envio_Id { get; set; }

        public int StatusEnvioDocumentacion_Id { get; set; }

        public DateTime Date { get; set; }

        [StringLength(100)]
        public string User { get; set; }

        public virtual DOCUMENTACIONENVIO DOCUMENTACIONENVIO { get; set; }

        public virtual EnvioDocumentacionStatus EnvioDocumentacionStatus { get; set; }
    }
}
