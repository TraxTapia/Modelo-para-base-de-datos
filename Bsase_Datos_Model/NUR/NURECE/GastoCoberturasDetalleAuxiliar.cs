namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.GastoCoberturasDetalleAuxiliar")]
    public partial class GastoCoberturasDetalleAuxiliar
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(20)]
        public string Elegibilidad { get; set; }
    }
}
