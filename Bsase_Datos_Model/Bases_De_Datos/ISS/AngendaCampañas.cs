namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AngendaCampañas
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdCampaña { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Campaña { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(150)]
        public string CodEspecialidad { get; set; }

        [Key]
        [Column(Order = 3)]
        public bool Estatus { get; set; }
    }
}
