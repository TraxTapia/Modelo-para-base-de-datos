namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bandejaIncidencias
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int folio { get; set; }

        public int? consecutivo { get; set; }

        public int? codArea { get; set; }

        public DateTime? fechaRegistro { get; set; }

        [StringLength(50)]
        public string usrRegistro { get; set; }

        [Column(TypeName = "text")]
        public string incidencia { get; set; }

        [Column(TypeName = "text")]
        public string solucion { get; set; }

        public DateTime? fechaCierre { get; set; }

        [StringLength(50)]
        public string usrCierre { get; set; }

        public int? codEstatus { get; set; }

        public int? codCliente { get; set; }

        [StringLength(50)]
        public string nombreResponsable { get; set; }

        [StringLength(50)]
        public string emailResponsable { get; set; }

        [StringLength(50)]
        public string telResponsable { get; set; }

        [StringLength(50)]
        public string celResponsable { get; set; }

        [Column(TypeName = "text")]
        public string pendientes { get; set; }

        [StringLength(50)]
        public string nombreContacto { get; set; }

        public string emailContacto { get; set; }

        [StringLength(50)]
        public string telContacto { get; set; }

        [StringLength(50)]
        public string celContacto { get; set; }

        public int? codTipoIncidencia { get; set; }
    }
}
