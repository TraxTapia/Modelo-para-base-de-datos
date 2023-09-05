namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.elegibilidades2012#")]
    public partial class elegibilidades2012_
    {
        public DateTime? xdateinsert { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        public int? codEmpresa { get; set; }

        public int? control { get; set; }

        public DateTime? fechaVerificacion { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codcuenta { get; set; }

        [StringLength(255)]
        public string nombrecompleto { get; set; }

        [StringLength(10)]
        public string codestado { get; set; }

        [StringLength(15)]
        public string uusario { get; set; }
    }
}
