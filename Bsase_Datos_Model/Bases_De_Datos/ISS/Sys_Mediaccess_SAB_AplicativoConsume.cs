namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_SAB_AplicativoConsume
    {
        [Key]
        public int Idaplicativo { get; set; }

        [Required]
        [StringLength(255)]
        public string Aplicacion { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        public int Estatus { get; set; }
    }
}
