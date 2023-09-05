namespace Bsase_Datos_Model.macmedi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("dcorona.TB_Hipertension")]
    public partial class TB_Hipertension
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFicha { get; set; }

        [Column("1A")]
        public bool? C1A { get; set; }

        [Column("1B")]
        public bool? C1B { get; set; }

        [Column("1C")]
        public bool? C1C { get; set; }

        [Column("2A")]
        public bool? C2A { get; set; }

        [Column("2B")]
        public bool? C2B { get; set; }

        [Column("2C")]
        public bool? C2C { get; set; }

        [Column("3A")]
        public bool? C3A { get; set; }

        [Column("3B")]
        public bool? C3B { get; set; }

        [Column("3C")]
        public bool? C3C { get; set; }

        [Column("4A")]
        public bool? C4A { get; set; }

        [Column("4B")]
        public bool? C4B { get; set; }

        [Column("4C")]
        public bool? C4C { get; set; }

        [Column("5A")]
        public bool? C5A { get; set; }

        [Column("5B")]
        public bool? C5B { get; set; }

        [Column("6A")]
        public bool? C6A { get; set; }

        [Column("6B")]
        public bool? C6B { get; set; }

        [Column("6C")]
        public bool? C6C { get; set; }

        [Column("6D")]
        public bool? C6D { get; set; }

        [Column("7A")]
        public bool? C7A { get; set; }

        [Column("7B")]
        public bool? C7B { get; set; }

        [Column("8A")]
        public bool? C8A { get; set; }

        [Column("8B")]
        public bool? C8B { get; set; }

        [Column("9A")]
        public bool? C9A { get; set; }

        [Column("9B")]
        public bool? C9B { get; set; }
    }
}
