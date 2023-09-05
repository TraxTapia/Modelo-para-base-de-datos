namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProveedorCertificado")]
    public partial class ProveedorCertificado
    {
        public int Id { get; set; }

        public int CodCuenta { get; set; }

        public bool Certificado { get; set; }
    }
}
