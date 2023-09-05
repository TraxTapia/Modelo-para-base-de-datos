namespace Bsase_Datos_Model.Red
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Grupos
    {
        [Key]
        public int codGrupo { get; set; }

        [Required]
        [StringLength(5)]
        public string cve_empresa { get; set; }

        [StringLength(50)]
        public string descripcion { get; set; }

        public bool GenElegibilidad { get; set; }

        public bool GenAutorizacion { get; set; }

        public int IdCatCuadro { get; set; }
    }
}
