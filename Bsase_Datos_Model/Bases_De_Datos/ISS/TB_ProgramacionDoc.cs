namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_ProgramacionDoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCirugia { get; set; }

        [StringLength(10)]
        public string Id { get; set; }

        [StringLength(255)]
        public string N_Imagen { get; set; }

        [Column(TypeName = "image")]
        public byte[] Imagen { get; set; }

        public byte[] Documento { get; set; }
    }
}
