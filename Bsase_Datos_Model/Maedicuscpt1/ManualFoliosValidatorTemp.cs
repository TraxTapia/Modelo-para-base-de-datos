namespace Bsase_Datos_Model.Maedicuscpt1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ManualFoliosValidatorTemp")]
    public partial class ManualFoliosValidatorTemp
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(20)]
        public string CodProcedimiento { get; set; }

        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public decimal Total { get; set; }
    }
}
