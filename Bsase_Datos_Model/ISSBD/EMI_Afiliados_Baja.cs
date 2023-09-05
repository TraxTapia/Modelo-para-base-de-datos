namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMI_Afiliados_Baja
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string codAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int correlativo { get; set; }

        public DateTime? fechaFin { get; set; }

        [StringLength(255)]
        public string CodLogin { get; set; }

        public DateTime? FECHACARGA { get; set; }

        [StringLength(700)]
        public string Error { get; set; }
    }
}
