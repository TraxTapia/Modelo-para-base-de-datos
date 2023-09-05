namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ficha_Tecnica151221
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Cobertura { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_TipoCopago { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id_Moneda { get; set; }

        [Key]
        [Column(Order = 5)]
        public decimal Limite_Inicial { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal Limite_Final { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Copago { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "text")]
        public string Especificaciones { get; set; }

        [Key]
        [Column(Order = 9)]
        public bool Activo { get; set; }

        [Key]
        [Column(Order = 10)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdTipoGasto { get; set; }
    }
}
