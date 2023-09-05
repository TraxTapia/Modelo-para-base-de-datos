namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Sanos_RecFileDetail
    {
        public int Id { get; set; }

        public int ID_RecFile { get; set; }

        [StringLength(50)]
        public string Expediente { get; set; }

        public string Derechohabiente { get; set; }

        [StringLength(100)]
        public string Estatus { get; set; }

        [StringLength(255)]
        public string Medico { get; set; }

        [StringLength(100)]
        public string Especialidad { get; set; }

        [StringLength(100)]
        public string Nivel_de_Atencion { get; set; }

        [StringLength(50)]
        public string Fecha_Consulta { get; set; }

        public string d_v_idx { get; set; }

        [StringLength(50)]
        public string Pase { get; set; }

        [StringLength(100)]
        public string Tipo_Servicio_o_Diagnostico { get; set; }

        public virtual Tb_Sanos_RecFile Tb_Sanos_RecFile { get; set; }
    }
}
