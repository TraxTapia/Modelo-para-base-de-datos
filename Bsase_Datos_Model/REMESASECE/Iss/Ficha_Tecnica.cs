namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ficha_Tecnica
    {
        public int Id { get; set; }

        [Required]
        [StringLength(250)]
        public string CodProducto { get; set; }

        public int Id_Cobertura { get; set; }

        public int Id_TipoCopago { get; set; }

        public int Id_Moneda { get; set; }

        public decimal Limite_Inicial { get; set; }

        public decimal Limite_Final { get; set; }

        public decimal Copago { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Especificaciones { get; set; }

        public bool Activo { get; set; }

        public int IdTipoGasto { get; set; }

        public virtual Catalogo_Moneda Catalogo_Moneda { get; set; }

        public virtual Coberturas_Ficha_Tecnica Coberturas_Ficha_Tecnica { get; set; }

        public virtual TipoCopago TipoCopago { get; set; }

        public virtual TipoGastoCopago TipoGastoCopago { get; set; }
    }
}
