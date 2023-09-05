namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Cat_Grupo_Medicina_Preventiva
    {
        public int id { get; set; }

        [StringLength(20)]
        public string Descripcion { get; set; }
    }
}
