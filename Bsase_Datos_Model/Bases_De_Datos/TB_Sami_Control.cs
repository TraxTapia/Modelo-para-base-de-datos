namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Sami_Control
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Perfil { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Menu { get; set; }

        public int? SubMenu { get; set; }

        [StringLength(20)]
        public string XusrInsert { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime XDateInsert { get; set; }
    }
}
