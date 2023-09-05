namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CatRegimenFiscal")]
    public partial class CatRegimenFiscal
    {
        public int Id { get; set; }

        public int? c_RegimenFiscal { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Fisica { get; set; }

        [StringLength(255)]
        public string Moral { get; set; }

        [Column("Fecha de inicio de vigencia")]
        public DateTime? Fecha_de_inicio_de_vigencia { get; set; }

        [Column("Fecha de fin de vigencia")]
        public DateTime? Fecha_de_fin_de_vigencia { get; set; }
    }
}
