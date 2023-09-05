namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ConsultaElectronicaCitas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCita { get; set; }

        public int? CodClinica { get; set; }

        [StringLength(10)]
        public string CodCuenta { get; set; }

        public int? CodEstatus { get; set; }

        public int? CodEmpresa { get; set; }

        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        public DateTime? Inicio { get; set; }

        public DateTime? Fin { get; set; }

        [StringLength(50)]
        public string TelefonoContacto { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateUpdate { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        [StringLength(50)]
        public string Celular { get; set; }
    }
}
