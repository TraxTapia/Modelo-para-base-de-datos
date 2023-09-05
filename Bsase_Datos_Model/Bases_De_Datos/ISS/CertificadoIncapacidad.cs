namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CertificadoIncapacidad")]
    public partial class CertificadoIncapacidad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodServicioGeneral { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodIncapacidad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string Folio { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime FechaIncapacidad { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodMotivoIncapacidad { get; set; }

        [Key]
        [Column(Order = 5)]
        public DateTime FechaInicioIncapacidad { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime FechaFinIncapacidad { get; set; }

        [StringLength(50)]
        public string Autorizacion { get; set; }

        [StringLength(500)]
        public string Descripcion { get; set; }

        public virtual MotivoIncapacidad MotivoIncapacidad { get; set; }
    }
}
