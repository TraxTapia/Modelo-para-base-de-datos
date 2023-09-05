namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ProgramacionProcDiag
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCirugia { get; set; }

        [StringLength(100)]
        public string CodDiagnostico1 { get; set; }

        [StringLength(100)]
        public string CodDiagnostico2 { get; set; }

        [StringLength(100)]
        public string CodDiagnostico3 { get; set; }

        [StringLength(100)]
        public string CodProcedimiento1 { get; set; }

        [StringLength(100)]
        public string Codprocedimiento2 { get; set; }

        [StringLength(100)]
        public string Codprocedimiento3 { get; set; }
    }
}
