namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Folio")]
    public partial class Folio
    {
        [Key]
        [Column("Folio")]
        [StringLength(10)]
        public string Folio1 { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public int Correlativo { get; set; }

        [StringLength(150)]
        public string Exadmin { get; set; }

        [StringLength(10)]
        public string Ccostos { get; set; }
    }
}
