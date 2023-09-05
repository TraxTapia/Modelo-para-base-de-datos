namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_WS_AfiliadosSICAS
    {
        public int Id { get; set; }

        public string cadenaentrada { get; set; }

        public string cadenasalida { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }

        public DateTime? fechaproceso { get; set; }
    }
}
