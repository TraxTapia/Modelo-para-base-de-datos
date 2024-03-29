namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USUARIO_SISTEMAS
    {
        [Key]
        [Column(Order = 0)]
        public int USRSIS_ID_USRSIS { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string USUARIO { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SISTEMA { get; set; }

        public virtual SISTEMAS SISTEMAS { get; set; }
    }
}
