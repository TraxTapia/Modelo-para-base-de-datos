namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_AfiliadoVentas
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Codafiliado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codempresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Required]
        [StringLength(50)]
        public string CostoUnitario { get; set; }

        [Required]
        [StringLength(50)]
        public string CostoNeto { get; set; }

        [Required]
        [StringLength(50)]
        public string DerechoPoliza { get; set; }

        [Required]
        [StringLength(50)]
        public string RecargoPago { get; set; }

        [Required]
        public string Agente { get; set; }

        [Required]
        public string Promotora { get; set; }

        [Required]
        public string Proyecto { get; set; }

        [Required]
        public string Oficina { get; set; }

        [Required]
        public string DireccionComercialAg { get; set; }
    }
}
