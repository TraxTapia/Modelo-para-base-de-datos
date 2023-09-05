namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PolizasOxxoVigencia")]
    public partial class PolizasOxxoVigencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Poliza { get; set; }

        public DateTime? InicioVigencia { get; set; }

        public DateTime? FinVigencia { get; set; }
    }
}
