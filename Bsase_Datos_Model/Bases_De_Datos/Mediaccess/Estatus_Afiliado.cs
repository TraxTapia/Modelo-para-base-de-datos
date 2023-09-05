namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Estatus_Afiliado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEstatus { get; set; }

        [StringLength(50)]
        public string EstatusAfiliado { get; set; }

        [StringLength(1)]
        public string Estatus { get; set; }
    }
}
