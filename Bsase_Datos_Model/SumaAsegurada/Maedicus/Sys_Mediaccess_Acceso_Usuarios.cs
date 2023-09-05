namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Acceso_Usuarios
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 2)]
        [MaxLength(8000)]
        public byte[] Pass { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPerfil { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Subperfil { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string Usuario_I { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime Fecha_I { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(50)]
        public string Usuario_U { get; set; }

        [Key]
        [Column(Order = 9)]
        public DateTime Fecha_U { get; set; }
    }
}
