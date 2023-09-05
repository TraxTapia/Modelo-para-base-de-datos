namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ProdMedControlados
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Producto { get; set; }

        [Required]
        [StringLength(50)]
        public string xUsrinsert { get; set; }

        public DateTime xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public bool Estatus { get; set; }
    }
}
