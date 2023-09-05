namespace Bsase_Datos_Model.REMESASECE.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Empresa")]
    public partial class Empresa
    {
        [Key]
        [StringLength(10)]
        public string CodEmpresa { get; set; }

        [Column("Empresa")]
        [StringLength(100)]
        public string Empresa1 { get; set; }

        [StringLength(255)]
        public string NombreLargo { get; set; }

        [StringLength(1)]
        public string CodEstatusEmpresa { get; set; }

        public DateTime? FechaInicioServicio { get; set; }

        [StringLength(20)]
        public string Rfc { get; set; }

        [StringLength(20)]
        public string Telefono1 { get; set; }

        [StringLength(20)]
        public string Telefono2 { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(255)]
        public string Calle { get; set; }

        [StringLength(100)]
        public string Colonia { get; set; }

        [StringLength(10)]
        public string CodEstado { get; set; }

        [StringLength(10)]
        public string CodPoblacion { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        [StringLength(50)]
        public string Correo { get; set; }

        [StringLength(3)]
        public string tipoprod { get; set; }

        public int? codPlan { get; set; }

        public int? CodTabulador { get; set; }
    }
}
