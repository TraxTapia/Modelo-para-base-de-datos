namespace Bsase_Datos_Model.Mediaccess.Documento_por_aplicacion
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CatArchivos
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string Nombre { get; set; }

        public bool Activo { get; set; }
    }
}
