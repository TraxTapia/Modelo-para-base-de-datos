namespace Bsase_Datos_Model.SumaAsegurada.Maedicus
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_TF_FacFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_TF_FacFile()
        {
            tb_TF_FacDet = new HashSet<tb_TF_FacDet>();
        }

        public int id { get; set; }

        public int Registro { get; set; }

        public int Val { get; set; }

        public int Error { get; set; }

        public int Rechazos { get; set; }

        public double Monto { get; set; }

        public DateTime Fecha { get; set; }

        public bool estatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tb_TF_FacDet> tb_TF_FacDet { get; set; }
    }
}
