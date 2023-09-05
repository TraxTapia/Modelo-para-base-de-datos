namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.coberturasProductosHist")]
    public partial class coberturasProductosHist
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Iduser { get; set; }

        public string ComandoAnt { get; set; }

        public string ComandoNvo { get; set; }

        [StringLength(25)]
        public string XUsuario { get; set; }

        public DateTime Fecha { get; set; }

        [Key]
        [StringLength(25)]
        public string Evento { get; set; }
    }
}
