namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hospitalcede")]
    public partial class hospitalcede
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(255)]
        public string Hospital { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [Key]
        [Column(Order = 4)]
        public string Direccion { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string Consultorio { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(20)]
        public string Telefono { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(10)]
        public string Ext { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(20)]
        public string Celular { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(20)]
        public string UsrInsert { get; set; }
    }
}
