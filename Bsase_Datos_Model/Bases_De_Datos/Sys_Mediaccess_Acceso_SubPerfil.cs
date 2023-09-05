namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Acceso_SubPerfil
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codperfil { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Subperfil { get; set; }

        [Key]
        [Column(Order = 2)]
        public int IdSubperfil { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string Perfil { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Estatus { get; set; }

        [StringLength(250)]
        public string observaciones { get; set; }
    }
}
