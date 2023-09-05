namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoVendedor")]
    public partial class ContactoVendedor
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodVendedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodContacto { get; set; }

        public int CodTipoContacto { get; set; }

        [Required]
        [StringLength(20)]
        public string Descripcion { get; set; }

        public virtual TipoContacto TipoContacto { get; set; }

        public virtual Vendedor Vendedor { get; set; }
    }
}
