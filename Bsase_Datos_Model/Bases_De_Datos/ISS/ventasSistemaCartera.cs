namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ventasSistemaCartera")]
    public partial class ventasSistemaCartera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codVenta { get; set; }

        public int? codCorporativo { get; set; }

        public int? codCliente { get; set; }

        public int? codEmpresa { get; set; }

        public int? codPymeColectivo { get; set; }

        public int? codPlan { get; set; }

        [StringLength(15)]
        public string codProducto { get; set; }

        public int? codSegmento { get; set; }

        public int? codCanal { get; set; }

        public double? costoUnitario { get; set; }

        public double? cantidad { get; set; }

        public double? comision { get; set; }

        [StringLength(2)]
        public string comisionEn { get; set; }

        public DateTime? fechaInicio { get; set; }

        public DateTime? fechaFin { get; set; }

        public int? codEstatus { get; set; }

        public DateTime? fechaCarga { get; set; }

        [StringLength(50)]
        public string xusrCarga { get; set; }

        public DateTime? fechaModificacion { get; set; }

        [StringLength(50)]
        public string xsrModificacion { get; set; }

        public int? mesesFacturacion { get; set; }

        public virtual planes planes { get; set; }
    }
}
