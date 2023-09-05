namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PolizaAdssyf_130522
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPoliza { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string NumeroPolizaUnico { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaEmision { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ICodSucursal { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaInicioVigencia { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaFinVigencia { get; set; }

        [Key]
        [Column(Order = 7)]
        public DateTime FechaAnulacion { get; set; }

        [Key]
        [Column(Order = 8)]
        public DateTime FechaCancelacion { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string StsPoliza { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(200)]
        public string DescripcionPoliza { get; set; }

        [Key]
        [Column(Order = 11)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NumeroRenovacion { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(50)]
        public string CodAgente { get; set; }

        [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCliente { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(100)]
        public string NombreCliente { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(100)]
        public string ApellidoPaternoCliente { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(100)]
        public string ApellidoMaternoCliente { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(20)]
        public string IdTipoSeguro { get; set; }
    }
}
