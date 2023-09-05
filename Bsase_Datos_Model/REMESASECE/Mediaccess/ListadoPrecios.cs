namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ListadoPrecios
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodListadoPrecio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string NumeroProveedor { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Cve_Especialidad { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string CodProcedimiento { get; set; }

        [StringLength(255)]
        public string Procedimiento { get; set; }

        [Column(TypeName = "money")]
        public decimal? Importe { get; set; }

        [StringLength(10)]
        public string TipoGasto { get; set; }
    }
}
