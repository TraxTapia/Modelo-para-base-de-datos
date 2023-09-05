namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AreaTrabajo")]
    public partial class AreaTrabajo
    {
        [Key]
        public int IdArea { get; set; }

        [StringLength(500)]
        public string NombreArea { get; set; }

        [StringLength(800)]
        public string Descripcion { get; set; }

        public bool estatus { get; set; }
    }
}
