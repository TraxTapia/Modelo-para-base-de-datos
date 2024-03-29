namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConsultaElectronicaFarmacias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodFarmacia { get; set; }

        [StringLength(50)]
        public string Farmacia { get; set; }

        public int? CodClinica { get; set; }
    }
}
