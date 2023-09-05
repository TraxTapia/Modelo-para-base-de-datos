namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sami_Reportes_AreasCaptura
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Sami_Reportes_AreasCaptura()
        {
            Sami_Reportes_UsuariosCaptura = new HashSet<Sami_Reportes_UsuariosCaptura>();
        }

        [Key]
        public int IdAreasCaptura { get; set; }

        public int? codArea { get; set; }

        public int? codSubArea { get; set; }

        [StringLength(250)]
        public string DescripcionSubArea { get; set; }

        public virtual areas areas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Sami_Reportes_UsuariosCaptura> Sami_Reportes_UsuariosCaptura { get; set; }
    }
}
