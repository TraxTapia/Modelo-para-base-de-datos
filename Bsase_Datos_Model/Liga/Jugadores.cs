namespace Bsase_Datos_Model.Liga
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Jugadores
    {
        public int Id { get; set; }

        public int Numero { get; set; }

        [Required]
        [StringLength(200)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Apodo { get; set; }

        public int? IdPosicion { get; set; }

        public int Goles { get; set; }

        public virtual Posiciones Posiciones { get; set; }
    }
}
