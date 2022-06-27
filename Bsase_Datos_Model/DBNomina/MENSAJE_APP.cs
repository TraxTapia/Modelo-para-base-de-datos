namespace Bsase_Datos_Model.DBNomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MENSAJE_APP
    {
        public int id { get; set; }

        public int id_app { get; set; }

        public int id_rol_origen { get; set; }

        public int id_rol_destino { get; set; }

        public int id_tipo_mensaje { get; set; }

        [Required]
        [StringLength(2000)]
        public string mensaje { get; set; }

        [Required]
        [StringLength(100)]
        public string json_data { get; set; }

        public bool isread { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual CAT_APP CAT_APP { get; set; }

        public virtual CAT_ROL CAT_ROL { get; set; }
    }
}
