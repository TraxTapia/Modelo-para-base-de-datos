namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EMPRESAVIRTUAL")]
    public partial class EMPRESAVIRTUAL
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(6)]
        public string CLAVECARGA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(3)]
        public string CODEMPRESA { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(1)]
        public string POLIZA { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(5)]
        public string CODPYME { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string DESCRIPCION { get; set; }
    }
}
