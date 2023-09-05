namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Medicamentos_BANCOMEXT
    {
        [StringLength(50)]
        public string EAN { get; set; }

        [StringLength(300)]
        public string NombreComercial { get; set; }

        [StringLength(300)]
        public string Nombre { get; set; }

        [StringLength(300)]
        public string DscSal { get; set; }

        [StringLength(300)]
        public string FormaFarmaceutica { get; set; }

        [StringLength(100)]
        public string ViaAdmUnidad { get; set; }

        [StringLength(50)]
        public string Unidad { get; set; }

        public int? PiezasporUnidad { get; set; }

        [StringLength(50)]
        public string Concentracion { get; set; }

        [StringLength(50)]
        public string UnidaddeMedida { get; set; }

        [Column(TypeName = "money")]
        public decimal? PMP { get; set; }

        [StringLength(300)]
        public string DscGrupo { get; set; }

        [StringLength(300)]
        public string Dsc_Cuadro { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdClave { get; set; }

        [StringLength(71)]
        public string Autorizacion { get; set; }
    }
}
