namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class RedMedicaInfonavitXLS
    {
        public int Id { get; set; }

        public int ClaveEF { get; set; }

        [StringLength(50)]
        public string EntidadFederativa { get; set; }

        public int ClaveMunicipio { get; set; }

        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(100)]
        public string PlazaInfonavit { get; set; }

        [Required]
        [StringLength(100)]
        public string NivelAtencion { get; set; }

        [Required]
        [StringLength(100)]
        public string Especialidad { get; set; }

        public int ClaveProveedor { get; set; }

        [Required]
        [StringLength(200)]
        public string Proveedor { get; set; }

        [Required]
        [StringLength(200)]
        public string Direccion { get; set; }

        [StringLength(10)]
        public string CodigoPostal { get; set; }

        [Required]
        [StringLength(30)]
        public string Telefono { get; set; }

        [Required]
        [StringLength(200)]
        public string HorarioServicio { get; set; }

        [StringLength(100)]
        public string NombreSucursal { get; set; }

        [StringLength(100)]
        public string DescuentoLaboratorioGabinete { get; set; }

        public bool IsMedico { get; set; }

        public bool ServicioDomicilio { get; set; }

        public DateTime FechaCarga { get; set; }

        [Required]
        [StringLength(100)]
        public string UsuarioCarga { get; set; }

        [Required]
        [StringLength(100)]
        public string FileNameXLS { get; set; }
    }
}
