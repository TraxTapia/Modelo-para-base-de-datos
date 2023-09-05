namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMI_Afiliados_Renovacion
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

        public int? codPlan { get; set; }

        [StringLength(50)]
        public string codProducto { get; set; }

        public int? codPymeColectividad { get; set; }

        public DateTime? fechaInicioServicio { get; set; }

        public DateTime? fechaFinServicio { get; set; }

        public DateTime? FechaAntiguedad { get; set; }

        [StringLength(250)]
        public string Error { get; set; }

        [StringLength(250)]
        public string Usuario { get; set; }
    }
}
