namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorFarmaciaM_E_CargaRechazosLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLog { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string usrInsert { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int regInsertados { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int regRechazados { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string fechaBusqueda { get; set; }

        public string finsertBusqueda { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime finsert { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string tipotabla { get; set; }
    }
}
