namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblServiceAut")]
    public partial class tblServiceAut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblServiceAut()
        {
            tblServiceAutDetails = new HashSet<tblServiceAutDetails>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Elegibilidad { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        [Required]
        [StringLength(50)]
        public string CodCuenta { get; set; }

        public int CodFarmacia { get; set; }

        public int? CodEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int Correlativo { get; set; }

        [StringLength(10)]
        public string CodDiag1 { get; set; }

        [StringLength(10)]
        public string CodDiag2 { get; set; }

        [StringLength(10)]
        public string CodDiag3 { get; set; }

        [StringLength(10)]
        public string CodDiag4 { get; set; }

        [StringLength(10)]
        public string CodDiag5 { get; set; }

        [StringLength(10)]
        public string CodDiag6 { get; set; }

        [StringLength(10)]
        public string CodDiag7 { get; set; }

        [StringLength(10)]
        public string CodDiag8 { get; set; }

        public int? IdMedicoTratante { get; set; }

        public int? Codespecialidad { get; set; }

        [Column(TypeName = "ntext")]
        public string Observaciones { get; set; }

        public DateTime? xDateInsert { get; set; }

        public DateTime? xDateUpdate { get; set; }

        public int? CodEstatus { get; set; }

        public double? Total { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ProcessedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblServiceAutDetails> tblServiceAutDetails { get; set; }
    }
}
