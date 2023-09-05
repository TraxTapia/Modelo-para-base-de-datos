namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoEmpresa")]
    public partial class ContactoEmpresa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodContacto { get; set; }

        public int CodTipoContacto { get; set; }

        [Required]
        [StringLength(50)]
        public string Descripcion { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual TipoContacto TipoContacto { get; set; }
    }
}
