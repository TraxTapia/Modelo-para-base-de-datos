namespace Bsase_Datos_Model.DBContextISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CodPymesWELLNES1
    {
        public int? codEmpresa { get; set; }

        public int? codPymeColectiva { get; set; }

        public int? codEstatus { get; set; }

        public int Id { get; set; }
    }
}
