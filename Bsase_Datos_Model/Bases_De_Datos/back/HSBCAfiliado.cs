namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.HSBCAfiliado")]
    public partial class HSBCAfiliado
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Correlativo { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodParentesco { get; set; }

        [StringLength(250)]
        public string CodCalle { get; set; }

        [StringLength(50)]
        public string CodEstado { get; set; }

        public int? CodEstatus { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string CodEmpresa { get; set; }

        [StringLength(255)]
        public string Nombres { get; set; }

        [StringLength(255)]
        public string ApellidoPaterno { get; set; }

        [StringLength(255)]
        public string ApellidoMaterno { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaNacimiento { get; set; }

        public int? Edad { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaInicioServicio { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? FechaFinServicio { get; set; }

        public DateTime? FechaCargaMediAccess { get; set; }

        [StringLength(10)]
        public string membresia { get; set; }

        [StringLength(30)]
        public string plan { get; set; }

        [StringLength(10)]
        public string idcontratante { get; set; }

        [StringLength(10)]
        public string afiliacion { get; set; }

        [StringLength(10)]
        public string producto { get; set; }

        [StringLength(10)]
        public string tipo { get; set; }

        [StringLength(5)]
        public string cp { get; set; }

        [StringLength(20)]
        public string telefonos { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(150)]
        public string municipio { get; set; }

        [StringLength(50)]
        public string Recibo { get; set; }

        public int? CVE_ENT { get; set; }

        public int? CVE_MUN { get; set; }

        public int? CVE_LOC { get; set; }

        public int? CVE_COL { get; set; }

        [StringLength(50)]
        public string Credencial { get; set; }

        [StringLength(150)]
        public string nombre_archivo { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        public int? CodEstadoCivil { get; set; }
    }
}
