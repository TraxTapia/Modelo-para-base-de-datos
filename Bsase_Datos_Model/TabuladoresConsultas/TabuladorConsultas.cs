namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TabuladorConsultas
    {
        [Key]
        public int Id { get; set; }

        public int CveProveedor { get; set; }

        public int Especialidad { get; set; }

        public int Cpt { get; set; }

        public decimal Monto { get; set; }

        public bool Activo { get; set; }
    }
}
