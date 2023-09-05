namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_PolizasAdssyf
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CODEMPRESA { get; set; }

        public int? CodPymeColectivo { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string NombreComercial { get; set; }

        [StringLength(50)]
        public string Poliza { get; set; }

        [StringLength(50)]
        public string idPoliza { get; set; }
    }
}
