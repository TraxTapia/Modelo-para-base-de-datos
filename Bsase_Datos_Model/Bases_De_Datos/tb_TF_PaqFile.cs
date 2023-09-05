namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TF_PaqFile
    {
        public int Id { get; set; }

        public int Registro { get; set; }

        public int Val { get; set; }

        public int Error { get; set; }

        public int Rechazos { get; set; }

        public double Monto { get; set; }

        public DateTime F_APaq { get; set; }

        public DateTime? F_DPaq { get; set; }

        public DateTime? F_CPaq { get; set; }

        public bool Estatus { get; set; }
    }
}
