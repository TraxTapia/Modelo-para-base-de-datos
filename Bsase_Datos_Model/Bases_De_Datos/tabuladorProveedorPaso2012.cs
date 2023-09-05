namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tabuladorProveedorPaso2012
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codTipoGasto { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string CodigoProveedor { get; set; }

        [StringLength(20)]
        public string CodDescripción { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string Estudio { get; set; }

        [Key]
        [Column(Order = 3)]
        public double PrecioPublico { get; set; }

        [Key]
        [Column(Order = 4)]
        public double Descuento { get; set; }

        [Key]
        [Column(Order = 5)]
        public double PrecioMAC { get; set; }

        [StringLength(255)]
        public string Cliente { get; set; }

        public DateTime? FechadeCarga { get; set; }

        public DateTime? FechadeActualizacion { get; set; }

        [StringLength(255)]
        public string Usuarioqueactualizo { get; set; }

        public int? AplicaparaelAÑO { get; set; }
    }
}
