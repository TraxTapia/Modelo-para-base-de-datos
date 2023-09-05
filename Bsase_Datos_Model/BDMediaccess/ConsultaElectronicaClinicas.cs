namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConsultaElectronicaClinicas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodClinica { get; set; }

        [StringLength(50)]
        public string Clinica { get; set; }

        [StringLength(50)]
        public string CodEstatus { get; set; }

        [StringLength(50)]
        public string CodTipoClinica { get; set; }

        public int? codCuenta { get; set; }
    }
}
