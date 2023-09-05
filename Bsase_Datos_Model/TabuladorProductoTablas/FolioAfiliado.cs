namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FolioAfiliado")]
    public partial class FolioAfiliado
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodVendedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoEntrega { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string FolioMembresia { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public int Correlativo { get; set; }

        public DateTime FechaCarga { get; set; }

        public virtual FolioMembresia FolioMembresia1 { get; set; }
    }
}
