namespace Bsase_Datos_Model.ControlGasto
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.distribucionCorreosIncapacidades")]
    public partial class distribucionCorreosIncapacidades
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IDCORREO { get; set; }

        [StringLength(50)]
        public string CORREO { get; set; }
    }
}
