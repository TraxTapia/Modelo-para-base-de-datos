namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServicioReferido")]
    public partial class ServicioReferido
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodServicioGeneral { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ConsecutivoServicio { get; set; }

        public int CodTipoServicioReferido { get; set; }

        [Required]
        [StringLength(5)]
        public string CIE { get; set; }

        public DateTime? FechaInicioSintomatologia { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Indicaciones { get; set; }

        public int? Dias { get; set; }

        [StringLength(15)]
        public string Cantidad { get; set; }

        public DateTime? FechaServicio { get; set; }

        [StringLength(100)]
        public string medicamento { get; set; }

        public virtual ServicioGeneral ServicioGeneral { get; set; }

        public virtual TipoServicioReferido TipoServicioReferido { get; set; }
    }
}
