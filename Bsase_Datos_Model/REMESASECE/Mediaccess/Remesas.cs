namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remesas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRemesa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string NumeroProveedor { get; set; }

        [StringLength(1)]
        public string CodStatusRemesa { get; set; }

        [StringLength(50)]
        public string NumeroRemesa { get; set; }

        [StringLength(100)]
        public string NombreProveedor { get; set; }

        [StringLength(10)]
        public string FechaRemesa { get; set; }

        [StringLength(10)]
        public string CodEmpresa { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [StringLength(20)]
        public string xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        [StringLength(20)]
        public string xDateUpdate { get; set; }
    }
}
