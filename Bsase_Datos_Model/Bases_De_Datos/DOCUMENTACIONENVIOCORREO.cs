namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DOCUMENTACIONENVIOCORREO")]
    public partial class DOCUMENTACIONENVIOCORREO
    {
        public int Id { get; set; }

        public int idenvio { get; set; }

        [Required]
        [StringLength(100)]
        public string archivo { get; set; }

        [Required]
        [StringLength(70)]
        public string correo { get; set; }

        public bool enviado { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuAlta { get; set; }

        public DateTime FechaAlta { get; set; }

        [Required]
        [StringLength(25)]
        public string UsuCambio { get; set; }

        public DateTime FechaCambio { get; set; }

        public virtual DOCUMENTACIONENVIO DOCUMENTACIONENVIO { get; set; }
    }
}
