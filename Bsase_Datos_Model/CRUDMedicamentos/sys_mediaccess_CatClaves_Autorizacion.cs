namespace Bsase_Datos_Model.CRUDMedicamentos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_mediaccess_CatClaves_Autorizacion
    {
        [Key]
        public int IdClave { get; set; }

        [StringLength(5)]
        public string Cve_Aut { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(500)]
        public string Comentario { get; set; }

        [StringLength(20)]
        public string Color_Aut { get; set; }
    }
}
