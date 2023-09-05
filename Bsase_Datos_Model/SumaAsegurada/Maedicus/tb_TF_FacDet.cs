namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TF_FacDet
    {
        public int Id { get; set; }

        public int Id_Event { get; set; }

        public int cve_prov { get; set; }

        [Required]
        [StringLength(255)]
        public string no_fac { get; set; }

        [Required]
        [StringLength(255)]
        public string remesa { get; set; }

        public int? secuenciaMac { get; set; }

        [Required]
        [StringLength(255)]
        public string cve_empresa { get; set; }

        public DateTime f_envio_pago { get; set; }

        public bool? estatus { get; set; }

        public string mensaje { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual tb_TF_FacFile tb_TF_FacFile { get; set; }
    }
}
