namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CF_GEN_ERROR_LOG
    {
        [Key]
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal Id_Evento { get; set; }

        public DateTime FH_EVENTO { get; set; }

        [Required]
        [StringLength(50)]
        public string CVE_APLICACION { get; set; }

        [Required]
        [StringLength(100)]
        public string PROGRAMA { get; set; }

        public int CVE_TIPO_EVENTO { get; set; }

        [Required]
        [StringLength(2000)]
        public string MENSAJE { get; set; }

        [StringLength(200)]
        public string TIPO_EXCEPCION { get; set; }

        [StringLength(5000)]
        public string ERROR_TRACE { get; set; }

        [Required]
        [StringLength(20)]
        public string CODIGO_USUARIO { get; set; }
    }
}
