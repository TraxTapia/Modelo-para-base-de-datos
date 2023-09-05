namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DescripcionTipoExamen
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DesTipExaCve { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DesTipExaTipExaCve { get; set; }

        [StringLength(50)]
        public string DesTipExaDescripcion { get; set; }

        [StringLength(50)]
        public string DesTipExaNotas { get; set; }
    }
}
