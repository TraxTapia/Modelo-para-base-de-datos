namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UbicacionAfiliado")]
    public partial class UbicacionAfiliado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodUbicacion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusUbicacion { get; set; }

        [Required]
        [StringLength(150)]
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
        public string Telefonos { get; set; }

        [StringLength(200)]
        public string colonia { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [StringLength(200)]
        public string Beneficiario { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual TipoUbicacion TipoUbicacion { get; set; }
    }
}
