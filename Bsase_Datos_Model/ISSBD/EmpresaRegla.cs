namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmpresaRegla")]
    public partial class EmpresaRegla
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodEmpresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CodRegla { get; set; }

        [StringLength(50)]
        public string Valor { get; set; }

        public virtual Empresa Empresa { get; set; }

        public virtual Regla Regla { get; set; }
    }
}
