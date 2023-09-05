namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Autorizaciones
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodAutorizacion { get; set; }

        public int CodMotivoLlamada { get; set; }

        [Required]
        [StringLength(3)]
        public string CodServicio { get; set; }

        [Required]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(2)]
        public string CodViaCarga { get; set; }

        [Required]
        [StringLength(10)]
        public string xUsrInsert { get; set; }

        public DateTime xDateInsert { get; set; }

        public virtual Servicio Servicio { get; set; }

        public virtual ViaCarga ViaCarga { get; set; }
    }
}
