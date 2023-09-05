namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WebService_ProveedorDiasHabiles
    {
        [Key]
        [Column(Order = 0)]
        public int id { get; set; }

        public string datosEntrada { get; set; }

        public string datosSalida { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime created_at { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short status { get; set; }
    }
}
