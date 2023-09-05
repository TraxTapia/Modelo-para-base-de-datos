namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class clientes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCliente { get; set; }

        [StringLength(50)]
        public string cliente { get; set; }

        public int? codPlan { get; set; }

        [StringLength(50)]
        public string clientesIncidencias { get; set; }
    }
}
