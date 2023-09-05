namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class FICHA_PRODUCTO
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(4)]
        public string COD_EMPRESA { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string COD_PRODUCTO { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(2)]
        public string COD_PLAN { get; set; }

        [Key]
        [Column(Order = 3, TypeName = "text")]
        public string DESCRIP { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(70)]
        public string NOM_PRODUCTO { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(10)]
        public string ORIGEN_TARIFA { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(10)]
        public string ESTATUS { get; set; }

        [Key]
        [Column(Order = 7, TypeName = "date")]
        public DateTime FEC_SOL { get; set; }

        [Key]
        [Column(Order = 8, TypeName = "date")]
        public DateTime FEC_INI_VIG { get; set; }

        [Key]
        [Column(Order = 9, TypeName = "date")]
        public DateTime FEC_FIN_VIG { get; set; }

        [Key]
        [Column(Order = 10)]
        [StringLength(3)]
        public string COPAGO { get; set; }

        [Key]
        [Column(Order = 11)]
        [StringLength(1)]
        public string COPAGOEN { get; set; }

        [Key]
        [Column("DEDUCIBLE_$", Order = 12)]
        public decimal DEDUCIBLE__ { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(10)]
        public string COD_RED1 { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(10)]
        public string COD_RED2 { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(10)]
        public string COD_RED3 { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(10)]
        public string LIST_MED1 { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(10)]
        public string LIST_MED2 { get; set; }

        [Key]
        [Column(Order = 18)]
        [StringLength(10)]
        public string LIST_MED3 { get; set; }

        [Key]
        [Column(Order = 19)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int COD_TIPO_CUENTA { get; set; }

        [Key]
        [Column(Order = 20)]
        [StringLength(10)]
        public string COD_ESPECIALIDAD { get; set; }

        [Key]
        [Column(Order = 21)]
        public decimal LIMITE_SUPERIOR { get; set; }

        [Key]
        [Column(Order = 22)]
        public decimal LIMITE_INFERIOR { get; set; }

        [Key]
        [Column(Order = 23)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EVENTO_MAX { get; set; }
    }
}
