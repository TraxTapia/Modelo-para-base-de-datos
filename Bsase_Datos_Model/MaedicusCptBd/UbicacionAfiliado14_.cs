namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UbicacionAfiliado14#")]
    public partial class UbicacionAfiliado14_
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

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string CodEstatusUbicacion { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(150)]
        public string Domicilio { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string CodPais { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(4)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPoblacion { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodColonia { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(50)]
        public string Telefonos { get; set; }

        [StringLength(200)]
        public string colonia { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(200)]
        public string Beneficiario { get; set; }
    }
}
