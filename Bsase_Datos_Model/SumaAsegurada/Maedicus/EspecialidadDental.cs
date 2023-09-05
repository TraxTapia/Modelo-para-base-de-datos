namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EspecialidadDental")]
    public partial class EspecialidadDental
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short CodEspecialidad { get; set; }

        [Required]
        [StringLength(255)]
        public string Especialidad { get; set; }
    }
}
