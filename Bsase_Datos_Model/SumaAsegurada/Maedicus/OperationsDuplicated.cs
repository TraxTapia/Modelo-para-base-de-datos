namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OperationsDuplicated")]
    public partial class OperationsDuplicated
    {
        public int Id { get; set; }

        public int OperationId { get; set; }

        public DateTime Date { get; set; }

        public bool Visible { get; set; }

        [StringLength(50)]
        public string UserAuthorize { get; set; }

        public DateTime DateAuthorize { get; set; }

        public DateTime DateCancelation { get; set; }

        [StringLength(50)]
        public string UserCancelation { get; set; }

        public bool Authorized { get; set; }

        public int Duplicated_Bill { get; set; }

        public int Duplicated_Id { get; set; }

        public int Module_Id { get; set; }

        public virtual Operacion Operacion { get; set; }

        public virtual WebModules WebModules { get; set; }
    }
}
