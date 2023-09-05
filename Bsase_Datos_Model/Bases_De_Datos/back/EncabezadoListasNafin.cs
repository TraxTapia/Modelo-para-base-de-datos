namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EncabezadoListasNafin")]
    public partial class EncabezadoListasNafin
    {
        [Key]
        [Column("CLAVE DEL PROVEEDOR", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CLAVE_DEL_PROVEEDOR { get; set; }

        [Column("NOMBRE COMERCIAL")]
        public string NOMBRE_COMERCIAL { get; set; }

        [Column("RAZON SOCIAL")]
        public string RAZON_SOCIAL { get; set; }

        [Key]
        [Column(Order = 1)]
        public string ESPECIALIDAD { get; set; }

        [StringLength(62)]
        public string TELFEFONO { get; set; }

        [Key]
        [Column("E-MAIL", Order = 2)]
        [StringLength(50)]
        public string E_MAIL { get; set; }

        [Key]
        [Column("INCREMENTO ANUAL", Order = 3)]
        [StringLength(1)]
        public string INCREMENTO_ANUAL { get; set; }

        [Key]
        [Column("VIGENCIA DE INICIO", Order = 4)]
        [StringLength(1)]
        public string VIGENCIA_DE_INICIO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(1)]
        public string TERMINO { get; set; }

        public string CALLE { get; set; }

        public string COLONIA { get; set; }

        [StringLength(50)]
        public string CP { get; set; }

        [StringLength(50)]
        public string ESTADO { get; set; }

        [StringLength(50)]
        public string CIUDAD { get; set; }
    }
}
