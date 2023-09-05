namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TipoExamen
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TipExaCve { get; set; }

        [StringLength(50)]
        public string TipExaDescripcion { get; set; }

        [StringLength(50)]
        public string Notas { get; set; }
    }
}
