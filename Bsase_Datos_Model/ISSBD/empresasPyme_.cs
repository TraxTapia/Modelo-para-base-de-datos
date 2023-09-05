namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.empresasPyme#")]
    public partial class empresasPyme_
    {
        public int? icodempresa { get; set; }

        public int? icodplan { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int icodcontratante { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(180)]
        public string rs { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(180)]
        public string nc { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string vchrfc { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int estatus { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime fecha { get; set; }
    }
}
