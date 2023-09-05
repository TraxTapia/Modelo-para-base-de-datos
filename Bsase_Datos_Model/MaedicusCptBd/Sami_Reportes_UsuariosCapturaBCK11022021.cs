namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sami_Reportes_UsuariosCapturaBCK11022021
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAreasCaptura { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string cve_usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }

        [Column("User Principal Name")]
        [StringLength(255)]
        public string User_Principal_Name { get; set; }
    }
}
