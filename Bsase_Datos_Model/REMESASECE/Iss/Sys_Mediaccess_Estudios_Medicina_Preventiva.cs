namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Estudios_Medicina_Preventiva
    {
        [Key]
        [Column(Order = 0)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdPlanPreventivo { get; set; }

        [StringLength(200)]
        public string Estudio { get; set; }

        public virtual Sys_Mediaccess_Cat_Medicina_Preventiva Sys_Mediaccess_Cat_Medicina_Preventiva { get; set; }
    }
}
