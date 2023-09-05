namespace Bsase_Datos_Model.ISSBD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class vLayoutAfiliadosSass_Log
    {
        [Column("Clave de afiliado")]
        [StringLength(81)]
        public string Clave_de_afiliado { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(1000)]
        public string Póliza { get; set; }

        [Key]
        [Column("RFC/Documento", Order = 1)]
        [StringLength(1000)]
        public string RFC_Documento { get; set; }

        [StringLength(1000)]
        public string Nombres { get; set; }

        [Column("Apellido paterno")]
        [StringLength(1000)]
        public string Apellido_paterno { get; set; }

        [Column("Apellido materno")]
        [StringLength(1000)]
        public string Apellido_materno { get; set; }

        [StringLength(8000)]
        public string Teléfono { get; set; }

        [Key]
        [Column("Teléfono 2", Order = 2)]
        [StringLength(2)]
        public string Teléfono_2 { get; set; }

        [Column("Fecha inicio vigencia", TypeName = "date")]
        public DateTime? Fecha_inicio_vigencia { get; set; }

        [Column("Fecha fin vigencia", TypeName = "date")]
        public DateTime? Fecha_fin_vigencia { get; set; }

        [StringLength(8000)]
        public string Dirección { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(2)]
        public string Marca { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(2)]
        public string Modelo { get; set; }

        [Key]
        [Column("Año vehículo", Order = 5)]
        [StringLength(2)]
        public string Año_vehículo { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(2)]
        public string Chasis { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(2)]
        public string Placa { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(2)]
        public string Peso { get; set; }

        [Key]
        [Column("Color vehículo", Order = 9)]
        [StringLength(2)]
        public string Color_vehículo { get; set; }

        [Key]
        [Column("tipo vehículo", Order = 10)]
        [StringLength(2)]
        public string tipo_vehículo { get; set; }

        [Key]
        [Column("ID cuenta", Order = 11)]
        [StringLength(6)]
        public string ID_cuenta { get; set; }

        [Key]
        [Column("ID plan", Order = 12)]
        [StringLength(6)]
        public string ID_plan { get; set; }

        [Column("Observación especial")]
        [StringLength(83)]
        public string Observación_especial { get; set; }

        [Key]
        [Column("Correo electrónico", Order = 13)]
        [StringLength(200)]
        public string Correo_electrónico { get; set; }

        [Column("Fecha nacimiento", TypeName = "date")]
        public DateTime? Fecha_nacimiento { get; set; }

        [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string Sexo { get; set; }

        [Key]
        [Column(Order = 15)]
        [StringLength(1000)]
        public string Estado { get; set; }

        [Key]
        [Column(Order = 16)]
        [StringLength(2)]
        public string Localidad { get; set; }

        [Key]
        [Column(Order = 17)]
        [StringLength(1000)]
        public string Colonia { get; set; }

        [Key]
        [Column("Codigo Postal", Order = 18)]
        [StringLength(1000)]
        public string Codigo_Postal { get; set; }

        [Key]
        [Column(Order = 19)]
        [StringLength(2)]
        public string Beneficiario { get; set; }

        [Key]
        [Column("Nombre Mascota", Order = 20)]
        [StringLength(2)]
        public string Nombre_Mascota { get; set; }

        [Key]
        [Column("Especie Mascota", Order = 21)]
        [StringLength(2)]
        public string Especie_Mascota { get; set; }

        [Key]
        [Column("Sexo Mascota", Order = 22)]
        [StringLength(2)]
        public string Sexo_Mascota { get; set; }

        [Key]
        [Column("Raza mascota", Order = 23)]
        [StringLength(2)]
        public string Raza_mascota { get; set; }

        [Key]
        [Column("Color mascota", Order = 24)]
        [StringLength(2)]
        public string Color_mascota { get; set; }

        [Key]
        [Column("Año mascota", Order = 25)]
        [StringLength(2)]
        public string Año_mascota { get; set; }

        [Key]
        [Column("Meses mascota", Order = 26)]
        [StringLength(2)]
        public string Meses_mascota { get; set; }

        [Key]
        [Column("Señas mascota", Order = 27)]
        [StringLength(2)]
        public string Señas_mascota { get; set; }

        [Key]
        [Column(Order = 28)]
        [StringLength(10)]
        public string USR { get; set; }

        [Key]
        [Column(Order = 29)]
        public DateTime FINSERT { get; set; }

        public bool? VIP { get; set; }
    }
}
