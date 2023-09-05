namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BanruralCiudades
    {
        public int? Consecutivo { get; set; }

        [StringLength(5)]
        public string CodEstado { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodPoblacion { get; set; }

        [StringLength(255)]
        public string Ciudad { get; set; }

        public int? Afiliacion { get; set; }
    }
}
