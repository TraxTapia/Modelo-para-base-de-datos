namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.UbicacionAfiliado")]
    public partial class UbicacionAfiliado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
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
        [StringLength(100)]
        public string Domicilio { get; set; }

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

        public virtual TipoUbicacion1 TipoUbicacion1 { get; set; }
    }
}
