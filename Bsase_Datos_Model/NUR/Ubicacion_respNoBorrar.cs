namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Ubicacion_respNoBorrar
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodCuenta { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodUbicacion { get; set; }

        [StringLength(10)]
        public string CodTipoCuenta { get; set; }

        [StringLength(10)]
        public string CodEspecialidad { get; set; }

        [StringLength(10)]
        public string CodEstado { get; set; }

        [StringLength(10)]
        public string CodPoblacion { get; set; }

        [StringLength(10)]
        public string SubEspecialidad { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        [StringLength(10)]
        public string CodTipoUbicacion { get; set; }

        [StringLength(100)]
        public string Calle { get; set; }

        [StringLength(100)]
        public string RestoCalle { get; set; }

        [StringLength(100)]
        public string Colonia { get; set; }

        [StringLength(50)]
        public string CodigoPostal { get; set; }

        [StringLength(100)]
        public string Telefono1 { get; set; }

        [StringLength(100)]
        public string Telefono2 { get; set; }

        [StringLength(20)]
        public string Extension1 { get; set; }

        [StringLength(20)]
        public string Extension2 { get; set; }

        [StringLength(20)]
        public string Lada { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string Email1 { get; set; }

        [StringLength(50)]
        public string Email2 { get; set; }

        [StringLength(50)]
        public string Celular1 { get; set; }

        [StringLength(50)]
        public string Celular2 { get; set; }

        [StringLength(50)]
        public string Radio { get; set; }

        [StringLength(50)]
        public string ClaveRadio { get; set; }

        [Column(TypeName = "text")]
        public string HorarioAtencion { get; set; }

        [Column(TypeName = "text")]
        public string Observacion { get; set; }

        public DateTime? FechaProceso { get; set; }

        [StringLength(1)]
        public string CodEstatusUbicacion { get; set; }

        [StringLength(20)]
        public string xUsrInsert { get; set; }

        [StringLength(20)]
        public string xDateInsert { get; set; }

        [StringLength(20)]
        public string xUsrUpdate { get; set; }

        [StringLength(20)]
        public string xDateUpdate { get; set; }

        [StringLength(255)]
        public string Nombre { get; set; }

        [StringLength(255)]
        public string Restonombre { get; set; }

        [StringLength(255)]
        public string NombreCompleto { get; set; }

        [StringLength(50)]
        public string NumGNP { get; set; }
    }
}
