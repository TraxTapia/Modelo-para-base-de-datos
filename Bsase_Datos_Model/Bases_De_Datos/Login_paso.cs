namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Login_paso
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SegPass { get; set; }

        [StringLength(50)]
        public string spass { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPerfil { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string CodEstatus { get; set; }
    }
}
