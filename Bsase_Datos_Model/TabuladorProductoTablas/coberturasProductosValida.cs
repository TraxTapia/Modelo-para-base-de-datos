namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("saMediaccess.coberturasProductosValida")]
    public partial class coberturasProductosValida
    {
        [Key]
        public int codCobertura { get; set; }

        public int? codPlan { get; set; }

        [StringLength(20)]
        public string codProducto { get; set; }

        public int? codPresentacion { get; set; }

        [StringLength(3000)]
        public string cobertura { get; set; }

        public int? codTipoCuenta { get; set; }

        [StringLength(50)]
        public string codEspecialidad { get; set; }

        public int? codSelect { get; set; }

        [StringLength(150)]
        public string TextoCoberturaSelect { get; set; }

        [StringLength(10)]
        public string cpt { get; set; }

        public double? copago { get; set; }

        [StringLength(5)]
        public string copagoen { get; set; }

        public double? deducible { get; set; }

        [StringLength(10)]
        public string codTabulador { get; set; }

        [StringLength(50)]
        public string limiteSuperior { get; set; }

        [StringLength(50)]
        public string limiteInferior { get; set; }

        [StringLength(50)]
        public string numeroEventos { get; set; }

        [StringLength(15)]
        public string cubiertoen { get; set; }

        public bool? CubreCobertura { get; set; }

        [StringLength(25)]
        public string XUsuario { get; set; }

        public DateTime? FechaEvento { get; set; }

        [StringLength(25)]
        public string TipoProceso { get; set; }

        public string script { get; set; }

        public bool? Aprovacion { get; set; }
    }
}
