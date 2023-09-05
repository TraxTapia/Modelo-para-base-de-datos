namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_PermisosEspeciales_Aplicativos
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPermiso { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodApp { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPerfil { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(255)]
        public string Permiso { get; set; }

        [StringLength(250)]
        public string observaciones { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime Fech_Alta { get; set; }

        public DateTime? Fech_Cambio { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Estatus { get; set; }
    }
}
