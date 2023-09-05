namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TabuladorEspecialidadPoblacion")]
    public partial class TabuladorEspecialidadPoblacion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(5)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPoblacion { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(20)]
        public string CPT { get; set; }

        public double Costo { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTabulador { get; set; }

        public DateTime fechaActualizacion { get; set; }
    }
}
