namespace Bsase_Datos_Model.NUR.NURECE
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MedicalNetworkInfonavit")]
    public partial class MedicalNetworkInfonavit
    {
        public int Id { get; set; }

        public int Entidad_Id { get; set; }

        public int ClaveMunicipio { get; set; }

        public int Municipio_Id { get; set; }

        public int Plaza_Id { get; set; }

        public int NivelAtencion_Id { get; set; }

        public int Especialidad_Id { get; set; }

        public int Proveedor_Id { get; set; }

        public int ClaveProveedor { get; set; }

        [Required]
        [StringLength(300)]
        public string Direccion { get; set; }

        [StringLength(20)]
        public string CP { get; set; }

        [StringLength(50)]
        public string Telefono { get; set; }

        [StringLength(200)]
        public string HorarioServicio { get; set; }

        [StringLength(200)]
        public string Sucursal { get; set; }

        [StringLength(100)]
        public string Descuento { get; set; }

        public bool ServicioDomicilio { get; set; }

        public bool IsMedico { get; set; }

        public DateTime FechaRegistro { get; set; }

        public virtual EntidadFederativaInfonavit EntidadFederativaInfonavit { get; set; }

        public virtual EspecialidadInfonavit EspecialidadInfonavit { get; set; }

        public virtual MunicipioInfonavit MunicipioInfonavit { get; set; }

        public virtual NivelAtencionInfonavit NivelAtencionInfonavit { get; set; }

        public virtual PlazaInfonavit PlazaInfonavit { get; set; }

        public virtual ProveedoresInfonavit ProveedoresInfonavit { get; set; }
    }
}
