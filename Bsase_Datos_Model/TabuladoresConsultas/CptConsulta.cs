namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CptConsulta")]
    public partial class CptConsulta
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cpt { get; set; }

        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public bool Activo { get; set; }
    }
}
