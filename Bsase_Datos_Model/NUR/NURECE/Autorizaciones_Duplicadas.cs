namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Autorizaciones_Duplicadas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodAutorizacion { get; set; }

        [StringLength(20)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string IP { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAutorizacion { get; set; }

        public DateTime? FechaModificacion { get; set; }

        [StringLength(30)]
        public string UsuarioModifica { get; set; }
    }
}
