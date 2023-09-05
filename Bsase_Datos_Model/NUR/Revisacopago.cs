namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Revisacopago")]
    public partial class Revisacopago
    {
        [StringLength(30)]
        public string elegibilidad { get; set; }

        [StringLength(50)]
        public string codafiliado { get; set; }

        public int? codempresa { get; set; }

        public int? CodParentesco { get; set; }

        public int? codPlan { get; set; }

        [StringLength(25)]
        public string CodProducto { get; set; }

        [StringLength(255)]
        public string xUsrInsert { get; set; }

        [StringLength(50)]
        public string Numero { get; set; }

        public int? IdMedicoTratante { get; set; }

        [StringLength(10)]
        public string codEspecialidad { get; set; }

        [StringLength(10)]
        public string espCuenta { get; set; }

        [StringLength(5)]
        public string copagoen { get; set; }

        public double? copago { get; set; }

        [StringLength(100)]
        public string Copago_ECE { get; set; }

        [StringLength(10)]
        public string Fecha { get; set; }

        [Key]
        [StringLength(50)]
        public string Mensaje { get; set; }

        [StringLength(50)]
        public string cpt { get; set; }

        public string datosentrada { get; set; }

        public string DatosSalida { get; set; }

        public string observaciones { get; set; }
    }
}
