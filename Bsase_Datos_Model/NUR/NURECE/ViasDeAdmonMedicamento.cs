namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ViasDeAdmonMedicamento")]
    public partial class ViasDeAdmonMedicamento
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [StringLength(80)]
        public string ViaDeAdmimistracion { get; set; }

        [Column(TypeName = "text")]
        public string Descripcion { get; set; }

        public int Activo { get; set; }
    }
}
