namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FolioRemesasReembolsos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Anio { get; set; }

        public int Folio { get; set; }
    }
}
