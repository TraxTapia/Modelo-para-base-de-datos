namespace Bsase_Datos_Model.DBNomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ROL_OPCION
    {
        public int Id { get; set; }

        public int id_rol { get; set; }

        public int id_item_modulo { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_ROL CAT_ROL { get; set; }

        public virtual OPCION_MODULO OPCION_MODULO { get; set; }
    }
}
