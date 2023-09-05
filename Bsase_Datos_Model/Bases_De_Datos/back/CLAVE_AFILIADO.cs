namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CLAVE_AFILIADO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_AFILIADO { get; set; }

        [Required]
        [StringLength(50)]
        public string CODAFILIADO { get; set; }

        public int CORRELATIVO { get; set; }

        public int CODEMPRESA { get; set; }
    }
}
