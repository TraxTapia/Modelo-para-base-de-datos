namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_Sami_UsrAdmin
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Usuario { get; set; }

        [Key]
        [Column(Order = 2)]
        public string Nombre { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Email { get; set; }

        [Key]
        [Column(Order = 4)]
        [MaxLength(8000)]
        public byte[] Passwd { get; set; }

        [Key]
        [Column(Order = 5)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Perfil { get; set; }

        [Key]
        [Column(Order = 6)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Puesto { get; set; }

        [Key]
        [Column(Order = 7)]
        public bool Estatus { get; set; }

        [Key]
        [Column(Order = 8)]
        public bool Acceso { get; set; }

        [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Blk { get; set; }

        [Key]
        [Column(Order = 10)]
        public DateTime Finsert { get; set; }

        [Key]
        [Column(Order = 11)]
        public DateTime FCadu { get; set; }

        [StringLength(50)]
        public string xusrinsert { get; set; }

        public DateTime? Factual { get; set; }

        [StringLength(50)]
        public string xusractual { get; set; }
    }
}
