namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.procesoClinicas#")]
    public partial class procesoClinicas_
    {
        public int? anio { get; set; }

        public int? mes { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codcuenta { get; set; }

        [StringLength(255)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(22)]
        public string via { get; set; }

        public int? cuantas { get; set; }
    }
}
