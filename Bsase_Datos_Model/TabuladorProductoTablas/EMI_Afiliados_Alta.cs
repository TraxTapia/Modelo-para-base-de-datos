namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class EMI_Afiliados_Alta
    {
        public int? Consecutivo { get; set; }

        public int? codPlan { get; set; }

        [StringLength(50)]
        public string codProducto { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string codEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string codAfiliado { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int numeroBeneficiario { get; set; }

        [StringLength(50)]
        public string numPoliza { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codParentesco { get; set; }

        [StringLength(500)]
        public string codEstado { get; set; }

        public int? codPoblacion { get; set; }

        [StringLength(50)]
        public string colonia { get; set; }

        [StringLength(100)]
        public string Direccion { get; set; }

        [StringLength(5)]
        public string codigoPostal { get; set; }

        [StringLength(100)]
        public string nombres { get; set; }

        [StringLength(100)]
        public string apellidoPaterno { get; set; }

        [StringLength(100)]
        public string apellidoMaterno { get; set; }

        [StringLength(13)]
        public string Rfc { get; set; }

        [StringLength(100)]
        public string email { get; set; }

        [StringLength(52)]
        public string lada { get; set; }

        [StringLength(50)]
        public string telefonoCasa { get; set; }

        [StringLength(50)]
        public string telefonoCelular { get; set; }

        [StringLength(1)]
        public string sexo { get; set; }

        public DateTime? fechaNacimiento { get; set; }

        public DateTime? fechaInicioServicio { get; set; }

        public DateTime? fechaFinServicio { get; set; }

        [StringLength(10)]
        public string codAseguradora { get; set; }

        [StringLength(50)]
        public string codCobertura { get; set; }

        public DateTime? fechaInicioSeguro { get; set; }

        public DateTime? fechaFinSeguro { get; set; }

        [StringLength(50)]
        public string codEmpPymeColectividad { get; set; }

        [StringLength(50)]
        public string vip { get; set; }

        public int? codCorredor { get; set; }

        [StringLength(255)]
        public string CodLogin { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime FECHACARGA { get; set; }

        [StringLength(700)]
        public string Error { get; set; }
    }
}
