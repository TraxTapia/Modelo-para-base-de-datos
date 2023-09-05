namespace Bsase_Datos_Model.Bases_De_Datos.Mediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Requisitos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [StringLength(2)]
        public string TipoPersona { get; set; }

        [StringLength(1)]
        public string Req1 { get; set; }

        [StringLength(1)]
        public string Req2 { get; set; }

        [StringLength(1)]
        public string Req3 { get; set; }

        [StringLength(1)]
        public string Req4 { get; set; }

        [StringLength(1)]
        public string Req5 { get; set; }

        [StringLength(1)]
        public string Req6 { get; set; }

        [StringLength(1)]
        public string Req7 { get; set; }

        [StringLength(1)]
        public string Req8 { get; set; }

        [StringLength(1)]
        public string Req9 { get; set; }

        [StringLength(1)]
        public string Req10 { get; set; }

        [StringLength(1)]
        public string Req11 { get; set; }

        [StringLength(1)]
        public string Req12 { get; set; }

        [StringLength(1)]
        public string Req13 { get; set; }

        [StringLength(1)]
        public string Req14 { get; set; }

        [StringLength(1)]
        public string Req15 { get; set; }

        [StringLength(1)]
        public string Req16 { get; set; }

        [StringLength(1)]
        public string Req17 { get; set; }

        [StringLength(1)]
        public string Req18 { get; set; }

        [StringLength(1)]
        public string Req19 { get; set; }

        [StringLength(1)]
        public string Req20 { get; set; }

        [StringLength(1)]
        public string Req21 { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [StringLength(20)]
        public string xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        [StringLength(20)]
        public string xDateUpdate { get; set; }
    }
}
