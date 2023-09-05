namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EspecialidadesECEvsMediKit")]
    public partial class EspecialidadesECEvsMediKit
    {
        public int Id { get; set; }

        public int CodEspecialidad { get; set; }

        [StringLength(150)]
        public string Especialidad { get; set; }

        [StringLength(150)]
        public string Cve_Especialidad { get; set; }

        [StringLength(150)]
        public string Name { get; set; }

        [StringLength(45)]
        public string EspecialidadMediKit { get; set; }

        [StringLength(45)]
        public string idUAT { get; set; }

        [StringLength(45)]
        public string idPRODUCCION { get; set; }
    }
}
