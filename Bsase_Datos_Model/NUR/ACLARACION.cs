namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ACLARACION")]
    public partial class ACLARACION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaInicio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaTermino { get; set; }

        [StringLength(10)]
        public string CodProveedor { get; set; }

        [StringLength(50)]
        public string NombreCompleto { get; set; }

        [StringLength(10)]
        public string NoFacturas { get; set; }

        [StringLength(1000)]
        public string Antecedente { get; set; }

        [StringLength(1000)]
        public string Problema { get; set; }

        [StringLength(1000)]
        public string Solucion { get; set; }
    }
}
