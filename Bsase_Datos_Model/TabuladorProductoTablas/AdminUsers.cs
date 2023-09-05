namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AdminUsers
    {
        [Key]
        [Column(Order = 0)]
        public int Iduser { get; set; }

        [Required]
        [StringLength(20)]
        public string Usuario { get; set; }

        [Required]
        [StringLength(150)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(200)]
        public string Aplicacion { get; set; }

        public int Nivel { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Clinica { get; set; }

        public bool Estatus { get; set; }

        [Required]
        [MaxLength(8000)]
        public byte[] Passwd { get; set; }
    }
}
