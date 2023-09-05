namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NUR_ECE
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        [Required]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(10)]
        public string Elegibilidad { get; set; }

        [Required]
        [StringLength(20)]
        public string EAN { get; set; }

        [Required]
        [StringLength(20)]
        public string Folio { get; set; }

        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Required]
        [StringLength(50)]
        public string NUR { get; set; }

        [Required]
        [StringLength(5)]
        public string CIE10 { get; set; }

        public bool Activo { get; set; }
    }
}
