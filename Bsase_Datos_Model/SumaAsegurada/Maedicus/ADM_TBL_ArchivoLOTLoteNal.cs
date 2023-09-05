namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ADM_TBL_ArchivoLOTLoteNal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Folio { get; set; }

        [StringLength(15)]
        public string Cedula { get; set; }

        [StringLength(50)]
        public string Medico { get; set; }

        [StringLength(15)]
        public string Expediente { get; set; }

        [StringLength(2)]
        public string Parentesco { get; set; }

        [StringLength(2)]
        public string Consecutivo { get; set; }

        [StringLength(50)]
        public string Paciente { get; set; }

        public int? Clave { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Fecha { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(250)]
        public string EAN { get; set; }

        public int Unidades { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        public DateTime Finsert { get; set; }
    }
}
