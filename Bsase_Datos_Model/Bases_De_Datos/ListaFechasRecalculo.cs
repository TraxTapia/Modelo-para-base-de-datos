namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ListaFechasRecalculo")]
    public partial class ListaFechasRecalculo
    {
        [Key]
        [Column(TypeName = "date")]
        public DateTime fechaRecalculo { get; set; }

        public bool? Activo { get; set; }
    }
}
