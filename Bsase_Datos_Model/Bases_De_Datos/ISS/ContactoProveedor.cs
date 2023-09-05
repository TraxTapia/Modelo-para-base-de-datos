namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoProveedor")]
    public partial class ContactoProveedor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodUbicacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodContactoProveedor { get; set; }

        public int CodTipoContacto { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public virtual TipoContacto TipoContacto { get; set; }

        public virtual UbicacionProveedor UbicacionProveedor { get; set; }
    }
}
