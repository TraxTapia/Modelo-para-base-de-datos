namespace Bsase_Datos_Model.Mediaccess.Documento_por_aplicacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentosPorAplicacion")]
    public partial class DocumentosPorAplicacion
    {
        public int Id { get; set; }

        public int IdAplicacion { get; set; }

        public int IdDocumento { get; set; }

        public bool Activo { get; set; }
    }
}
