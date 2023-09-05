namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemittancesAdministrationMovements
    {
        public int Id { get; set; }

        public int RemittancesAdministration_Id { get; set; }

        public int RemittanceStatus_Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        [StringLength(50)]
        public string User { get; set; }

        public virtual CatalogRemittanceStatus CatalogRemittanceStatus { get; set; }

        public virtual RemittancesAdministration RemittancesAdministration { get; set; }
    }
}
