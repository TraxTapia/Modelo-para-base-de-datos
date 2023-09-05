namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class iss_sys_mediaccess_producto_autorizado
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Autorizacion { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Cpt { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(10)]
        public string CodTabulador { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string CodServicio { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cantidad { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal PU { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal Total { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(10)]
        public string CopagoEn { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Copago { get; set; }

        [Key]
        [Column(Order = 11)]
        public string Descripcion { get; set; }

        [Key]
        [Column(Order = 12, TypeName = "date")]
        public DateTime F_Ocurrido { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool Surtido { get; set; }

        public int? Codcuenta { get; set; }

        [Column(TypeName = "date")]
        public DateTime? F_Surtido { get; set; }
    }
}
