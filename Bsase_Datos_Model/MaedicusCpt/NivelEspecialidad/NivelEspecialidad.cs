namespace Bsase_Datos_Model.MaedicusCpt.NivelEspecialidad
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NivelEspecialidad")]
    public partial class NivelEspecialidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idNivel { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }
    }
}
