namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorFarmaciaM_E_ReplicaLog
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int idLog { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string fechaReplica { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(10)]
        public string fechaReplicacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(25)]
        public string usrInsert { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int registros { get; set; }

        [Key]
        [Column(Order = 6)]
        public DateTime finsert { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(1)]
        public string tipotabla { get; set; }
    }
}
