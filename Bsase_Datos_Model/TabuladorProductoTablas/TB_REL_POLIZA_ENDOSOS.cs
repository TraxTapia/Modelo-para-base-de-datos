namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_REL_POLIZA_ENDOSOS
    {
        public int Id { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(20)]
        public string Poliza { get; set; }

        public int idPoliza { get; set; }

        public int CodPymeColectivo { get; set; }

        [Required]
        [StringLength(200)]
        public string nombrecomercial { get; set; }

        [Required]
        [StringLength(200)]
        public string NombreArchivo { get; set; }

        [Required]
        [StringLength(20)]
        public string CodAfiliado { get; set; }

        public bool Activo { get; set; }

        public DateTime FProceso { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [StringLength(50)]
        public string Origen { get; set; }
    }
}
