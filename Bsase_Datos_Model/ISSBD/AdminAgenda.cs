namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AdminAgenda")]
    public partial class AdminAgenda
    {
        [Key]
        [Column(Order = 0)]
        public int Iduser { get; set; }

        [Required]
        [StringLength(20)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(150)]
        public string nombre { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codclinica { get; set; }

        public DateTime xDateInsert { get; set; }

        public DateTime xDateUpdate { get; set; }

        public short CodPerfil { get; set; }

        public bool Estatus { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] pwds { get; set; }
    }
}
