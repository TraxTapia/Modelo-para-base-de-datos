namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ayudaproveedores
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codcuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        [StringLength(255)]
        public string nombrecompleto { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(200)]
        public string RecursoMedico { get; set; }
    }
}
