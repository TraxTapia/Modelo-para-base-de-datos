namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RolReglasStatusProcesoConcepto")]
    public partial class RolReglasStatusProcesoConcepto
    {
        public int id { get; set; }

        public int idReglasStatusProcesoConcepto { get; set; }

        public int idRol { get; set; }

        public bool estatus { get; set; }

        public virtual ReglasStatusProcesoConcepto ReglasStatusProcesoConcepto { get; set; }
    }
}