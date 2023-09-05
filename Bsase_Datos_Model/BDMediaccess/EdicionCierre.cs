namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EdicionCierre")]
    public partial class EdicionCierre
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string UsuarioID { get; set; }

        [StringLength(15)]
        public string Pagina { get; set; }

        public int? Editar { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Fecha { get; set; }
    }
}
