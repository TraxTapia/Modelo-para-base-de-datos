namespace Bsase_Datos_Model.MaedicusCptBd
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Derhabs
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string cve_empresa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(100)]
        public string Nomina { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Numbenef { get; set; }

        [Required]
        [StringLength(10)]
        public string CodEstatus { get; set; }

        [Required]
        [StringLength(300)]
        public string Nombre { get; set; }

        public DateTime F_Alta { get; set; }

        public DateTime? F_Baja { get; set; }

        public DateTime F_nace { get; set; }

        [StringLength(4)]
        public string Edad { get; set; }

        [Required]
        [StringLength(2)]
        public string cve_parent { get; set; }

        [StringLength(50)]
        public string Tipo_emp { get; set; }

        [StringLength(50)]
        public string cve_derhab { get; set; }

        [StringLength(4)]
        public string CodEstado { get; set; }

        public int? CodPoblacion { get; set; }

        [StringLength(3)]
        public string Sexo { get; set; }

        public int? codGrupo { get; set; }

        [StringLength(100)]
        public string Poblacion { get; set; }

        [StringLength(50)]
        public string codPropiedad { get; set; }

        [StringLength(50)]
        public string centroCostos { get; set; }

        [StringLength(100)]
        public string nombres { get; set; }

        [StringLength(100)]
        public string apellidoPaterno { get; set; }

        [StringLength(100)]
        public string apellidoMaterno { get; set; }

        public int? codPlan { get; set; }

        [StringLength(50)]
        public string codProducto { get; set; }

        public int? codEmpresa { get; set; }

        public int? codPymeColectivo { get; set; }

        public DateTime? fechaAntiguedad { get; set; }

        [StringLength(5)]
        public string codAseguradora { get; set; }

        public virtual Estatus_Afiliado Estatus_Afiliado { get; set; }

        public virtual Parentesco Parentesco { get; set; }
    }
}
