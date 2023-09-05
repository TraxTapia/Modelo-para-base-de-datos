namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Acceso_Usr
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string CodLogin { get; set; }

        [Required]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Pass { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodApp { get; set; }

        public int CodPerfil { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario_I { get; set; }

        public DateTime Fecha_I { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario_U { get; set; }

        public DateTime Fecha_U { get; set; }

        [Required]
        [StringLength(1)]
        public string Estatus { get; set; }

        public virtual Sys_Mediaccess_Acceso_App Sys_Mediaccess_Acceso_App { get; set; }

        public virtual Sys_Mediaccess_Acceso_Perfil_no Sys_Mediaccess_Acceso_Perfil_no { get; set; }
    }
}
