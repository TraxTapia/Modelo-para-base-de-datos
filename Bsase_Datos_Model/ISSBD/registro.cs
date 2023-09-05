namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.registro")]
    public partial class registro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int clave_id { get; set; }

        [StringLength(50)]
        public string nombre { get; set; }

        [StringLength(50)]
        public string apellido_paterno { get; set; }

        [StringLength(50)]
        public string apellido_materno { get; set; }

        [StringLength(50)]
        public string telefono_casa { get; set; }

        [StringLength(50)]
        public string direccion { get; set; }

        [StringLength(50)]
        public string usuario { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [StringLength(10)]
        public string CodEmpresa { get; set; }
    }
}
