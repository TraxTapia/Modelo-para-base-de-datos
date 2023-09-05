namespace Bsase_Datos_Model.REMESASECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FoliosReceta")]
    public partial class FoliosReceta
    {
        [Key]
        [StringLength(50)]
        public string FolioReceta { get; set; }

        public int? ClaveProveedor { get; set; }

        public decimal Copago { get; set; }

        [Required]
        [StringLength(20)]
        public string Cpt { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int Correlativo { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(5)]
        public string CIE10 { get; set; }

        [Required]
        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        public double Monto { get; set; }

        public int Cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Required]
        [StringLength(300)]
        public string DescripcionProcedimiento { get; set; }

        public int Modulo { get; set; }

        public double Descuento { get; set; }

        [Required]
        [StringLength(200)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(10)]
        public string OrigenProveedor { get; set; }

        public DateTime FechaCreacion { get; set; }

        public int Pyme { get; set; }

        public DateTime FechaOcurrido { get; set; }
    }
}
