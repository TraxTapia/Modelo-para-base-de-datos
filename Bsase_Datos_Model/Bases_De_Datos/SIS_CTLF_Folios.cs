namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SIS_CTLF_Folios
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(25)]
        public string folio { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        public int estatus { get; set; }

        [StringLength(50)]
        public string guia { get; set; }

        [StringLength(15)]
        public string lote { get; set; }

        public DateTime fecha_asignacion { get; set; }

        public DateTime? fecha_salida { get; set; }

        public DateTime? fecha_recepcion { get; set; }

        public DateTime? fecha_entrega_prov { get; set; }

        [StringLength(1000)]
        public string observaciones { get; set; }

        [Required]
        [StringLength(15)]
        public string usr_asigno { get; set; }

        [StringLength(15)]
        public string usr_recibio { get; set; }

        [StringLength(15)]
        public string usr_entrego { get; set; }

        [StringLength(50)]
        public string usr_reg_salida { get; set; }

        public virtual Recursos_Medicos Recursos_Medicos { get; set; }

        public virtual SIS_CTLF_EstatusFolios SIS_CTLF_EstatusFolios { get; set; }

        public virtual SIS_CTLF_Stock SIS_CTLF_Stock { get; set; }
    }
}
