namespace Bsase_Datos_Model.BDMediaccess
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContactoLOG")]
    public partial class ContactoLOG
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodContacto { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [StringLength(100)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string TelefonoDirecto { get; set; }

        [StringLength(20)]
        public string Extension { get; set; }

        [StringLength(50)]
        public string CargoContacto { get; set; }

        [StringLength(50)]
        public string EmailContacto { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [StringLength(20)]
        public string xDateInsert { get; set; }

        [StringLength(50)]
        public string TipoAccion { get; set; }
    }
}
