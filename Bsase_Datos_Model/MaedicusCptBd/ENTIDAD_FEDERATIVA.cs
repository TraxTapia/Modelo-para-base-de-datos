namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ENTIDAD_FEDERATIVA
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_codigo_ent_fed { get; set; }

        [StringLength(4)]
        public string id_codigo_iso_pais { get; set; }

        [StringLength(100)]
        public string nombre { get; set; }

        public bool activo { get; set; }

        [StringLength(3)]
        public string abreviatura { get; set; }
    }
}
