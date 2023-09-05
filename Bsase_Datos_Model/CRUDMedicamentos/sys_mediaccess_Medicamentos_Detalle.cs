namespace Bsase_Datos_Model.CRUDMedicamentos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_Medicamentos_Detalle
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string EAN { get; set; }

        public int? IdMedicamento { get; set; }

        [StringLength(700)]
        public string NombreComercial { get; set; }

        [StringLength(300)]
        public string FormaFarmaceutica { get; set; }

        [StringLength(50)]
        public string UnidaddeMedida { get; set; }

        public int? PiezasporUnidad { get; set; }

        [StringLength(50)]
        public string Concentracion { get; set; }

        [Column(TypeName = "money")]
        public decimal? PMP { get; set; }

        [StringLength(100)]
        public string ViaAdmUnidad { get; set; }

        [StringLength(50)]
        public string Unidad { get; set; }

        public int? Autorizacion { get; set; }

        public int? PrioridadMensaje { get; set; }
    }
}
