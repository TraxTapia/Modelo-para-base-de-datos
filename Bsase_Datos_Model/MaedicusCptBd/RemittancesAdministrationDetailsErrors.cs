namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemittancesAdministrationDetailsErrors
    {
        public int Id { get; set; }

        public int RemittancesAdministrationDetails_Id { get; set; }

        public int Validation_Id { get; set; }

        public bool Active { get; set; }

        [StringLength(50)]
        public string UserApprove { get; set; }

        public DateTime? DateApprove { get; set; }

        public virtual RemittancesAdministrationDetails RemittancesAdministrationDetails { get; set; }

        public virtual RemittancesValidations RemittancesValidations { get; set; }
    }
}
