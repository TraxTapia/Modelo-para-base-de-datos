namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DatoscuentaNafin")]
    public partial class DatoscuentaNafin
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVEDELPROVEEDOR { get; set; }

        [StringLength(255)]
        public string NOMBRECOMERCIAL { get; set; }

        [StringLength(100)]
        public string RAZONSOCIAL { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(255)]
        public string ESPECIALIDAD { get; set; }

        [StringLength(61)]
        public string TELFEFONO { get; set; }

        [Key]
        [Column("E-MAIL", Order = 2)]
        [StringLength(50)]
        public string E_MAIL { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(1)]
        public string INCREMENTOANUAL { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(1)]
        public string VIGENCIADEINICIO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string TERMINO { get; set; }

        [StringLength(1000)]
        public string CALLE { get; set; }

        [StringLength(1000)]
        public string COLONIA { get; set; }

        [StringLength(1000)]
        public string CP { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string CIUDAD { get; set; }
    }
}
