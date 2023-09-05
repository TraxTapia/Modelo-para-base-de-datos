namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tabulador")]
    public partial class Tabulador
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodRed { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(3)]
        public string CodEspecialidad { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string CodProcedimiento { get; set; }

        [Required]
        [StringLength(3)]
        public string CodTipoTabulador { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatusProcedimiento { get; set; }

        public DateTime FechaAltaProcedimiento { get; set; }

        public DateTime? FechaBajaProcedimiento { get; set; }

        public double Importe { get; set; }

        public virtual ProcedimientoEspecialidad ProcedimientoEspecialidad { get; set; }

        public virtual RedProveedor RedProveedor { get; set; }
    }
}
