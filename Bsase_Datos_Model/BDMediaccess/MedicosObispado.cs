namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicosObispado")]
    public partial class MedicosObispado
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codclinica { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [StringLength(255)]
        public string medico { get; set; }

        [StringLength(255)]
        public string codespecialidad { get; set; }

        [StringLength(255)]
        public string especialidad { get; set; }

        [StringLength(50)]
        public string LunesDE { get; set; }

        [StringLength(50)]
        public string LunesA { get; set; }

        [StringLength(50)]
        public string MartesDE { get; set; }

        [StringLength(50)]
        public string MartesA { get; set; }

        [StringLength(50)]
        public string MiercolesDE { get; set; }

        [StringLength(50)]
        public string MiercolesA { get; set; }

        [StringLength(50)]
        public string JuevesDE { get; set; }

        [StringLength(50)]
        public string JuevesA { get; set; }

        [StringLength(50)]
        public string ViernesDE { get; set; }

        [StringLength(50)]
        public string ViernesA { get; set; }

        [StringLength(50)]
        public string SabadoDE { get; set; }

        [StringLength(50)]
        public string SabadoA { get; set; }

        [StringLength(50)]
        public string DomingoDE { get; set; }

        [StringLength(50)]
        public string DomingoA { get; set; }

        [StringLength(500)]
        public string Observaciones { get; set; }

        [StringLength(1)]
        public string CodEstatus { get; set; }

        public int? TiempoConsulta { get; set; }

        [StringLength(50)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [StringLength(50)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }

        [StringLength(6000)]
        public string MovimientosDias { get; set; }

        [StringLength(50)]
        public string Cedula { get; set; }

        public DateTime? Expedicion { get; set; }

        [StringLength(70)]
        public string Institucion { get; set; }

        [StringLength(50)]
        public string EspCedula { get; set; }

        public DateTime? EspExpedicion { get; set; }

        [StringLength(70)]
        public string EspInstitucion { get; set; }

        [StringLength(50)]
        public string CerCedula { get; set; }

        public DateTime? CerExpedicion { get; set; }

        [StringLength(70)]
        public string CerInstitucion { get; set; }
    }
}
