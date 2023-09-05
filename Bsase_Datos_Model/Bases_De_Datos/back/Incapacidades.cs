namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Incapacidades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codbandeja { get; set; }

        [StringLength(255)]
        public string Autorizacion { get; set; }

        [StringLength(255)]
        public string Folio { get; set; }

        [StringLength(255)]
        public string Servicio { get; set; }

        public int? DIAS { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FECHAINICIAL { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FECHAFINAL { get; set; }
    }
}
