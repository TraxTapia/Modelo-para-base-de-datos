namespace Bsase_Datos_Model.Bases_De_Datos.back
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

        [Required]
        [StringLength(2)]
        public string TipoPersona { get; set; }

        public bool Req1 { get; set; }

        public bool Req2 { get; set; }

        public bool Req3 { get; set; }

        public bool Req4 { get; set; }

        public bool Req5 { get; set; }

        public bool Req6 { get; set; }

        public bool Req7 { get; set; }

        public bool Req8 { get; set; }

        public bool Req9 { get; set; }

        public bool Req10 { get; set; }

        public bool Req11 { get; set; }

        public bool Req12 { get; set; }

        public bool Req13 { get; set; }

        public bool Req14 { get; set; }

        public bool Req15 { get; set; }

        public bool Req16 { get; set; }

        public bool Req17 { get; set; }

        public bool Req18 { get; set; }

        public bool Req19 { get; set; }

        public bool Req20 { get; set; }

        public bool Req21 { get; set; }

        [Required]
        [StringLength(100)]
        public string xUsrInsert { get; set; }

        public DateTime? xDateInsert { get; set; }

        [Required]
        [StringLength(100)]
        public string xUsrUpdate { get; set; }

        public DateTime? xDateUpdate { get; set; }
    }
}
