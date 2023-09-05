namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminAplicativo")]
    public partial class AdminAplicativo
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Aplicativo { get; set; }

        [Required]
        [StringLength(50)]
        public string TipoAplicativo { get; set; }

        [Required]
        [StringLength(50)]
        public string NomProyecto { get; set; }

        [Required]
        [StringLength(50)]
        public string Comentario { get; set; }

        public string Tablas { get; set; }

        public string StoreP { get; set; }

        public string Vistas { get; set; }

        public string Funciones { get; set; }

        public string Trigers { get; set; }

        public string IntegrationServ { get; set; }

        public string Reportingserv { get; set; }
    }
}
