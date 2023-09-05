namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("productoNvoECE#")]
    public partial class productoNvoECE_
    {
        [Key]
        [StringLength(25)]
        public string producto { get; set; }
    }
}
