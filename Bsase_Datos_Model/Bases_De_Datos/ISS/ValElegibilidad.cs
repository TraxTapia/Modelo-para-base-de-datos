namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ValElegibilidad")]
    public partial class ValElegibilidad
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codcuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Codcontrol { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(20)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string Codtipocuenta { get; set; }

        [StringLength(15)]
        public string xUsrtInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [Key]
        [Column(Order = 4)]
        public int Idvalida { get; set; }
    }
}
