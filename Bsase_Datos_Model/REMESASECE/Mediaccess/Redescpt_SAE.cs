namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Redescpt_SAE
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NUMERO_DE_PROVEEDOR { get; set; }

        [StringLength(255)]
        public string RAZON_SOCIAL { get; set; }

        [StringLength(50)]
        public string TIPO_DE_PROVEEDOR { get; set; }

        [StringLength(255)]
        public string ESPECIALIDAD { get; set; }

        [StringLength(10)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string POBLACION { get; set; }

        [StringLength(50)]
        public string Red { get; set; }

        [StringLength(35)]
        public string cve_prov { get; set; }
    }
}
