namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ACLARACION_BANDEJA
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string UsuarioEnvio { get; set; }

        [StringLength(50)]
        public string UsuarioBandeja { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(1)]
        public string TipoUsuario { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Folio { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "smalldatetime")]
        public DateTime FechaEnvio { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string Estatus { get; set; }
    }
}
