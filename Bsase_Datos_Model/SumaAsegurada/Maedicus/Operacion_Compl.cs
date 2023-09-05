namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Operacion_Compl
    {
        [Required]
        [StringLength(18)]
        public string consecutivo { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string no_fac { get; set; }

        [StringLength(20)]
        public string CPT { get; set; }

        [StringLength(5)]
        public string cve_cie_egreso { get; set; }

        [StringLength(5)]
        public string cve_cie_segdiag { get; set; }

        [Required]
        [StringLength(50)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(300)]
        public string Dsc_Procedimiento { get; set; }

        [Required]
        [StringLength(50)]
        public string Incremento { get; set; }

        [StringLength(50)]
        public string seglogin_captura { get; set; }

        public DateTime? F_captura { get; set; }

        public int ConsecPaseEsp { get; set; }

        [Required]
        [StringLength(50)]
        public string ElegOrigen { get; set; }

        public int? Id_TabProveedor { get; set; }

        public int? SecuenciaMac { get; set; }

        public int Id { get; set; }

        public int? OperationID { get; set; }

        public decimal? ImporteLP { get; set; }

        public decimal? ImporteDespuesCopago { get; set; }

        public decimal? ImporteAntesCopago { get; set; }

        public decimal ImporteDescuentoFarmacia { get; set; }

        public decimal ImporteDespuesDescuento { get; set; }

        public decimal ImporteAntesCopagoPorCantidad { get; set; }

        public int? Edad { get; set; }

        public int? Genero_Id { get; set; }

        public int EtiquetaPago_Id { get; set; }

        [StringLength(50)]
        public string TicketFarmacia { get; set; }

        [StringLength(50)]
        public string NUR { get; set; }

        public virtual EtiquetaPago EtiquetaPago { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
