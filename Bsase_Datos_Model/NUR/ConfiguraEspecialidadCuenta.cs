namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConfiguraEspecialidadCuenta")]
    public partial class ConfiguraEspecialidadCuenta
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodTipoCuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [Key]
        [Column(Order = 4)]
        public bool Activo { get; set; }
    }
}
