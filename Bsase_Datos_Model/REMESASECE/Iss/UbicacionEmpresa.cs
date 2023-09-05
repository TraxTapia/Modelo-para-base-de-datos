namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UbicacionEmpresa")]
    public partial class UbicacionEmpresa
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodUbicacion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusUbicacion { get; set; }

        [Required]
        [StringLength(100)]
        public string Domicilio { get; set; }

        [Required]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Required]
        [StringLength(4)]
        public string CodEstado { get; set; }

        public int CodPoblacion { get; set; }

        public int CodColonia { get; set; }

        [Required]
        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(50)]
        public string Horario { get; set; }

        public virtual Colonia Colonia { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual TipoUbicacion TipoUbicacion { get; set; }
    }
}
