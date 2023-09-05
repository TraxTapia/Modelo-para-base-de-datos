namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALZ_CLP_ListaProveedores
    {
        [StringLength(100)]
        public string Tabulador { get; set; }

        [Key]
        [StringLength(10)]
        public string cve_prov { get; set; }

        public string CodigoProveedor { get; set; }

        public string CodDescripción { get; set; }

        public string Descripcion { get; set; }

        public string Estudio { get; set; }

        public double? PrecioPublico { get; set; }

        public double? Descuento { get; set; }

        public double? PrecioMAC { get; set; }

        [StringLength(100)]
        public string Cliente { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_de_inicio_del_tabulador { get; set; }

        public int? Codcliente { get; set; }

        public int? codTipoGasto { get; set; }

        [StringLength(255)]
        public string Usuario { get; set; }

        public string ErrorMsg { get; set; }

        public bool? Val { get; set; }

        public int? AñoAplica { get; set; }
    }
}
