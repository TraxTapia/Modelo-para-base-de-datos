namespace Bsase_Datos_Model.Maedicuscpt1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ElectronicFoliosValidatorTemp")]
    public partial class ElectronicFoliosValidatorTemp
    {
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        [Required]
        [StringLength(20)]
        public string CodProcedimiento { get; set; }

        public int Cantidad { get; set; }

        public decimal Importe { get; set; }

        public decimal Total { get; set; }
    }
}
