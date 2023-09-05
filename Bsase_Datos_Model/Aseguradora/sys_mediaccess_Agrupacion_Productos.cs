namespace Bsase_Datos_Model.Aseguradora
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Agrupacion_Productos
    {
        [Key]
        public int IdAgrupacion { get; set; }

        [Required]
        [StringLength(20)]
        public string codProducto { get; set; }

        public int codGrupo { get; set; }

        public int codRed { get; set; }

        public bool IsEspecialidad { get; set; }
    }
}
