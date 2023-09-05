namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GruposFacturacion")]
    public partial class GruposFacturacion
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string Rfc { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string CodEmpresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(25)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPlan { get; set; }

        [StringLength(50)]
        public string Grupo { get; set; }

        public string Domicilio { get; set; }

        public string RazonSocial { get; set; }
    }
}
