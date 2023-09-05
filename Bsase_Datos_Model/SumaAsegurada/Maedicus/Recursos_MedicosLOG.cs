namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Recursos_MedicosLOG
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string RFC { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string RecursoMedico { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string Estatus { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(300)]
        public string Direccion { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(5)]
        public string CodEstado { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPoblacion { get; set; }

        [StringLength(50)]
        public string clabe { get; set; }

        [StringLength(50)]
        public string Cuenta { get; set; }

        [StringLength(50)]
        public string Sucursal { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(25)]
        public string SegLogin { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(50)]
        public string lada { get; set; }

        [StringLength(50)]
        public string telefono { get; set; }

        [StringLength(50)]
        public string apellidoPaterno { get; set; }

        [StringLength(50)]
        public string apellidoMaterno { get; set; }

        [StringLength(50)]
        public string nombres { get; set; }

        [StringLength(200)]
        public string nombreComercial { get; set; }

        [StringLength(200)]
        public string nombreFiscal { get; set; }

        public DateTime? fechaBaja { get; set; }

        public DateTime? fechaMovimiento { get; set; }
    }
}
