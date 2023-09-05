namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RemittancesAdministrationDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RemittancesAdministrationDetails()
        {
            RemittancesAdministrationDetailsErrors = new HashSet<RemittancesAdministrationDetailsErrors>();
        }

        public int Id { get; set; }

        public int RemittancesAdministration_Id { get; set; }

        public int Operation_Id { get; set; }

        public bool PaymentSAPI { get; set; }

        public virtual Operacion Operacion { get; set; }

        public virtual RemittancesAdministration RemittancesAdministration { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RemittancesAdministrationDetailsErrors> RemittancesAdministrationDetailsErrors { get; set; }
    }
}
