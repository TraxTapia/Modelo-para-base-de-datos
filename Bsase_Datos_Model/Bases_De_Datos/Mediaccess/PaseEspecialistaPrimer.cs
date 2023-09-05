namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PaseEspecialistaPrimer")]
    public partial class PaseEspecialistaPrimer
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodBandeja { get; set; }

        public DateTime? FechaLlamada { get; set; }

        [StringLength(10)]
        public string Codempresa { get; set; }

        [StringLength(100)]
        public string CodAfiliado { get; set; }

        public int? correlativo { get; set; }

        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codCuenta { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clinica { get; set; }

        [StringLength(10)]
        public string codEspecialidad { get; set; }
    }
}
