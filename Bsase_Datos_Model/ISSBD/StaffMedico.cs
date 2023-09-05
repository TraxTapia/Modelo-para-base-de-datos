namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("StaffMedico")]
    public partial class StaffMedico
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodStaff { get; set; }

        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(3)]
        public string CodEspecialidad { get; set; }

        public int CodSubEspecialidad { get; set; }

        [Required]
        [StringLength(1)]
        public string CodEstatus { get; set; }

        public virtual Estatus Estatus { get; set; }

        public virtual Proveedor Proveedor { get; set; }

        public virtual SubEspecialidad SubEspecialidad { get; set; }
    }
}
