namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Sys_Mediaccess_Medicina_Preventiva_Folios
    {
        public int id { get; set; }

        [StringLength(20)]
        public string codAfiliado { get; set; }

        public int? correlativo { get; set; }

        public int? codEmpresa { get; set; }

        [StringLength(20)]
        public string Folio { get; set; }

        public int? idGrupo { get; set; }

        public DateTime? FechaImpresion { get; set; }

        public bool? Estatus { get; set; }

        public DateTime? FechaUso { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? poliza { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [StringLength(2)]
        public string Genero { get; set; }
    }
}
