namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Cat_Medicina_Preventiva
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sys_Mediaccess_Cat_Medicina_Preventiva()
        {
            Sys_Mediaccess_Estudios_Medicina_Preventiva = new HashSet<Sys_Mediaccess_Estudios_Medicina_Preventiva>();
            Sys_Mediaccess_Rangos_Medicina_Preventiva = new HashSet<Sys_Mediaccess_Rangos_Medicina_Preventiva>();
        }

        public int Id { get; set; }

        [StringLength(200)]
        public string PlanPreventivo { get; set; }

        [StringLength(5)]
        public string ClavePlan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Estudios_Medicina_Preventiva> Sys_Mediaccess_Estudios_Medicina_Preventiva { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sys_Mediaccess_Rangos_Medicina_Preventiva> Sys_Mediaccess_Rangos_Medicina_Preventiva { get; set; }
    }
}
