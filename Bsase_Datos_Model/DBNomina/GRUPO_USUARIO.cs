namespace Bsase_Datos_Model.DBNomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GRUPO_USUARIO
    {
        public int Id { get; set; }

        public int id_grupo { get; set; }

        public int id_usuario { get; set; }

        public bool otorgar { get; set; }

        public bool denegar { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(50)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual GRUPO GRUPO { get; set; }

        public virtual USUARIO USUARIO { get; set; }
    }
}
