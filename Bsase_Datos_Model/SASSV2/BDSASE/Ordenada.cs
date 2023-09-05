namespace Bsase_Datos_Model.SASSV2.BDSASE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ordenada")]
    public partial class Ordenada
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Tipo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Numero { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        public int? codEmpresa { get; set; }

        public int? control { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? fechaVerificacion { get; set; }

        [StringLength(100)]
        public string ElegOrigen { get; set; }
    }
}
