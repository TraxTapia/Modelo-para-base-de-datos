namespace Bsase_Datos_Model.TabuladorProductoTablas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_WS_AfiliadosSICASC
    {
        public int? CodEmpresa { get; set; }

        [StringLength(50)]
        public string CodAfiliado { get; set; }

        public int? Correlativo { get; set; }

        [StringLength(50)]
        public string Nombres { get; set; }

        [StringLength(50)]
        public string ApellidoPaterno { get; set; }

        [StringLength(50)]
        public string ApellidoMaterno { get; set; }

        public DateTime? FechaNacimiento { get; set; }

        [StringLength(1)]
        public string Sexo { get; set; }

        [StringLength(15)]
        public string RFC { get; set; }

        public DateTime? FechaInicioServicio { get; set; }

        public DateTime? FechaFinServicio { get; set; }

        public DateTime? FechaCargaMediaccess { get; set; }

        public int? CodParentesco { get; set; }

        public int? CodEstadoCivil { get; set; }

        public int? CodEstatusAfiliado { get; set; }

        public int? CodPeriodo { get; set; }

        [StringLength(2)]
        public string DiaSemanaCorte { get; set; }

        public int? DiaMesCorte { get; set; }

        [StringLength(25)]
        public string CodProducto { get; set; }

        [StringLength(1)]
        public string CodEstatusImpresion { get; set; }

        [StringLength(20)]
        public string CodVendedor { get; set; }

        [Key]
        [StringLength(2)]
        public string CodViaCarga { get; set; }

        [StringLength(1)]
        public string CodSeguro { get; set; }

        [StringLength(255)]
        public string Observaciones { get; set; }

        public int? codGrupo { get; set; }

        public int? codPlan { get; set; }

        [StringLength(50)]
        public string tipoEmpleado { get; set; }

        [StringLength(50)]
        public string centroCostos { get; set; }

        [StringLength(10)]
        public string CodProductoAux { get; set; }

        public int? codPymeColectivo { get; set; }

        public int? codVip { get; set; }

        [StringLength(50)]
        public string Poliza { get; set; }

        public DateTime? FechaAntiguedad { get; set; }

        [StringLength(5)]
        public string codaseguradora { get; set; }

        public int? CodUbicacion { get; set; }

        [StringLength(2)]
        public string CodTipoUbicacion { get; set; }

        [StringLength(1)]
        public string CodEstatusUbicacion { get; set; }

        [StringLength(150)]
        public string Domicilio { get; set; }

        [StringLength(2)]
        public string CodPais { get; set; }

        [StringLength(4)]
        public string CodEstado { get; set; }

        public int? CodPoblacion { get; set; }

        public int? CodColonia { get; set; }

        [StringLength(5)]
        public string CP { get; set; }

        [StringLength(50)]
        public string Telefonos { get; set; }

        [StringLength(200)]
        public string colonia { get; set; }

        [StringLength(50)]
        public string email { get; set; }

        [StringLength(200)]
        public string Beneficiario { get; set; }

        [StringLength(1)]
        public string Movimiento { get; set; }

        [StringLength(100)]
        public string UsuarioProceso { get; set; }

        [StringLength(800)]
        public string MSGValida { get; set; }

        public DateTime? FechaProceso { get; set; }
    }
}
