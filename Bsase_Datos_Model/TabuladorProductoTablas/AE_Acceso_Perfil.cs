namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AE_Acceso_Perfil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codperfil { get; set; }

        [Required]
        [StringLength(255)]
        public string Perfil { get; set; }

        public int Estatus { get; set; }
    }
}
