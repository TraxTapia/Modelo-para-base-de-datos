namespace Bsase_Datos_Model.Bases_De_Datos.ISS
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

        public int CodRegimen { get; set; }

        [Required]
        [StringLength(255)]
        public string Descripcion { get; set; }

        [Required]
        [StringLength(2)]
        public string Fisica { get; set; }

        [Required]
        [StringLength(2)]
        public string Moral { get; set; }

        public DateTime? FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }
    }
}
