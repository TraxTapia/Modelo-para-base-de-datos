namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("datosrptcmb")]
    public partial class datosrptcmb
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Compania { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string TipoSeguro { get; set; }

        [StringLength(50)]
        public string TipoPlan { get; set; }

        [StringLength(50)]
        public string inumpoliza { get; set; }

        [StringLength(50)]
        public string NumCertificado { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string TipoIdentifica { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string TipoPersona { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        [StringLength(50)]
        public string Paterno { get; set; }

        [StringLength(50)]
        public string Materno { get; set; }

        [StringLength(5)]
        public string Sexo { get; set; }

        [StringLength(30)]
        public string FecNac { get; set; }

        [StringLength(30)]
        public string PolIniVig { get; set; }

        [StringLength(30)]
        public string PolFinVig { get; set; }

        [StringLength(20)]
        public string CodParent { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(20)]
        public string NumeroEmpleado { get; set; }

        [StringLength(20)]
        public string CodAsegurado { get; set; }

        [StringLength(20)]
        public string IdAfiliado { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(20)]
        public string CodigoAgente { get; set; }

        [StringLength(50)]
        public string fechaproceso { get; set; }

        [StringLength(100)]
        public string UsuarioProceso { get; set; }
    }
}
