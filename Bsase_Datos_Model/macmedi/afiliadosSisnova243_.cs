namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.afiliadosSisnova243#")]
    public partial class afiliadosSisnova243_
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codempresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string codafiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string nombres { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string apellidopaterno { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string apellidomaterno { get; set; }
    }
}
