namespace Bsase_Datos_Model.Bases_De_Datos
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Operacion")]
    public partial class Operacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Operacion()
        {
            ConceptosMovimiento = new HashSet<ConceptosMovimiento>();
            ObservacionConcepto_Operacion = new HashSet<ObservacionConcepto_Operacion>();
            Observations = new HashSet<Observations>();
            OperationsMovementsLog = new HashSet<OperationsMovementsLog>();
            OperationsDisabledLog = new HashSet<OperationsDisabledLog>();
            Operacion_Compl = new HashSet<Operacion_Compl>();
            OperationRollbackCopayHospital = new HashSet<OperationRollbackCopayHospital>();
            Operations_Error_Log = new HashSet<Operations_Error_Log>();
            OperationsDuplicated = new HashSet<OperationsDuplicated>();
            OperationsCoverage = new HashSet<OperationsCoverage>();
        }

        [Required]
        [StringLength(10)]
        public string cve_prov { get; set; }

        [Required]
        [StringLength(50)]
        public string no_fac { get; set; }

        [Required]
        [StringLength(18)]
        public string consecutivo { get; set; }

        [Required]
        [StringLength(20)]
        public string folio { get; set; }

        public DateTime? f_ocurrido { get; set; }

        [StringLength(2)]
        public string CodFormato { get; set; }

        [StringLength(10)]
        public string CodCopiaFormato { get; set; }

        [Required]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Nomina { get; set; }

        public int Numbenef { get; set; }

        [Required]
        [StringLength(5)]
        public string cve_cie { get; set; }

        [Required]
        [StringLength(4)]
        public string cve_espec { get; set; }

        [Required]
        [StringLength(20)]
        public string cve_proc { get; set; }

        public double importe { get; set; }

        public double iva { get; set; }

        public double isr { get; set; }

        public double retiva { get; set; }

        public double? impCedular { get; set; }

        public double total { get; set; }

        [Required]
        [StringLength(10)]
        public string articulo { get; set; }

        [StringLength(100)]
        public string SegLogin { get; set; }

        public double cantidad { get; set; }

        [Required]
        [StringLength(50)]
        public string CodTabulador { get; set; }

        [StringLength(150)]
        public string Exadmin { get; set; }

        [StringLength(10)]
        public string ccostos { get; set; }

        [StringLength(50)]
        public string autorizacion { get; set; }

        public DateTime? f_ingreso { get; set; }

        public DateTime? f_egreso { get; set; }

        [StringLength(200)]
        public string sucursal { get; set; }

        [StringLength(10)]
        public string provOrigen { get; set; }

        [StringLength(50)]
        public string tipoEmpleado { get; set; }

        public double? porCopago { get; set; }

        public double? impCopago { get; set; }

        public DateTime? fecha { get; set; }

        public int? anioLP { get; set; }

        public double? descuento { get; set; }

        [StringLength(50)]
        public string Elegibilidad { get; set; }

        [StringLength(20)]
        public string CodProducto { get; set; }

        public int? codPlan { get; set; }

        public int? codPymeColectivo { get; set; }

        public int? Codempresa { get; set; }

        [StringLength(255)]
        public string Num_Certificado { get; set; }

        [StringLength(20)]
        public string CPT { get; set; }

        [StringLength(5)]
        public string cve_cie_egreso { get; set; }

        [StringLength(5)]
        public string cve_cie_segdiag { get; set; }

        public int ID { get; set; }

        public int? SecuenciaMac { get; set; }

        public bool Visible { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ConceptosMovimiento> ConceptosMovimiento { get; set; }

        public virtual Facturas Facturas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ObservacionConcepto_Operacion> ObservacionConcepto_Operacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Observations> Observations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsMovementsLog> OperationsMovementsLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsDisabledLog> OperationsDisabledLog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operacion_Compl> Operacion_Compl { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationRollbackCopayHospital> OperationRollbackCopayHospital { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operations_Error_Log> Operations_Error_Log { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsDuplicated> OperationsDuplicated { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OperationsCoverage> OperationsCoverage { get; set; }
    }
}
