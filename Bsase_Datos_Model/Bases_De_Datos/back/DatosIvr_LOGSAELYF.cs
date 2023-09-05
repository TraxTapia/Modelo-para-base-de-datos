namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.DatosIvr_LOGSAELYF")]
    public partial class DatosIvr_LOGSAELYF
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Numero { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        public int? codEmpresa { get; set; }

        public int? control { get; set; }

        public DateTime? fechaVerificacion { get; set; }
    }
}
