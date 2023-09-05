namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tabulador")]
    public partial class Tabulador
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEspecialidad { get; set; }

        [StringLength(255)]
        public string ClaveEspecialidad { get; set; }

        [StringLength(255)]
        public string Especialidad { get; set; }

        [StringLength(50)]
        public string CodigoCPT4 { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProcedimiento { get; set; }

        [StringLength(255)]
        public string Procedimiento { get; set; }

        [Column(TypeName = "money")]
        public decimal? Costo23 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Costo21 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Costo18 { get; set; }

        [Column(TypeName = "money")]
        public decimal? Costo14 { get; set; }
    }
}
