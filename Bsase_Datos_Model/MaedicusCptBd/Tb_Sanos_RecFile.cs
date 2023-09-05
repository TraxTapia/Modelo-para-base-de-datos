namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Sanos_RecFile
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Sanos_RecFile()
        {
            Tb_Sanos_RecFileDetail = new HashSet<Tb_Sanos_RecFileDetail>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Archivo { get; set; }

        public int Registros { get; set; }

        public int Tamaño { get; set; }

        public DateTime? Finsert { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Sanos_RecFileDetail> Tb_Sanos_RecFileDetail { get; set; }
    }
}
