namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_PermisosEspeciales_Usuarios
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPermiso { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string User_Alta { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime Fech_Alta { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string User_Cambio { get; set; }

        public DateTime? Fech_Cambio { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string Estatus { get; set; }
    }
}
