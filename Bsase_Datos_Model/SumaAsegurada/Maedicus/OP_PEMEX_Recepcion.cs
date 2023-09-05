namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OP_PEMEX_Recepcion
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Cve_Prov { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string No_Fac { get; set; }

        [Required]
        [StringLength(255)]
        public string CodControl { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int secuenciaMac { get; set; }

        [StringLength(255)]
        public string F_sapi { get; set; }

        [StringLength(255)]
        public string Guia { get; set; }

        [StringLength(255)]
        public string F_Envio { get; set; }

        [StringLength(255)]
        public string F_Entrega { get; set; }

        public string Recibe { get; set; }

        [StringLength(255)]
        public string Estatus { get; set; }

        [StringLength(255)]
        public string StFactura { get; set; }

        [StringLength(255)]
        public string Dias_Trans { get; set; }

        [StringLength(50)]
        public string Uinsert { get; set; }

        public DateTime? Finsert { get; set; }

        [StringLength(50)]
        public string Uupdate { get; set; }

        public DateTime? Fupdate { get; set; }

        public virtual Facturas Facturas { get; set; }

        public virtual Recursos_Medicos Recursos_Medicos { get; set; }
    }
}
