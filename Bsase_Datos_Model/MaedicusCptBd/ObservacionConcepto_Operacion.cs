namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ObservacionConcepto_Operacion
    {
        public int Id { get; set; }

        public int Operation_Id { get; set; }

        public int ObservacionConcepto_Id { get; set; }

        public virtual ObservacionesConcepto ObservacionesConcepto { get; set; }

        public virtual Operacion Operacion { get; set; }
    }
}
