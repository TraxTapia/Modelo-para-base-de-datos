namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PublicacionREM")]
    public partial class PublicacionREM
    {
        [StringLength(50)]
        public string folio { get; set; }

        [StringLength(10)]
        public string idFarmacia { get; set; }

        [StringLength(500)]
        public string Paciente { get; set; }

        [StringLength(500)]
        public string Medico { get; set; }

        [StringLength(500)]
        public string especialidad { get; set; }

        [StringLength(50)]
        public string fecha { get; set; }

        public string Datos_Receta { get; set; }

        [StringLength(50)]
        public string copago { get; set; }

        [StringLength(50)]
        public string codplan { get; set; }

        [StringLength(20)]
        public string autorizacion { get; set; }

        [StringLength(50)]
        public string icd1 { get; set; }

        [StringLength(50)]
        public string icd2 { get; set; }

        [StringLength(50)]
        public string icd3 { get; set; }

        [StringLength(50)]
        public string icd4 { get; set; }

        public string Respuesta { get; set; }

        [Key]
        public DateTime FechaInsert { get; set; }

        [StringLength(50)]
        public string InsertURL { get; set; }
    }
}
