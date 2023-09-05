namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ALZ_SASS_PV_CambioProveedores
    {
        public int iD { get; set; }

        [StringLength(200)]
        public string txtFolioContrato { get; set; }

        [StringLength(200)]
        public string lblNumProveedor { get; set; }

        [StringLength(200)]
        public string Folio { get; set; }

        [StringLength(200)]
        public string cmbTipoPersona { get; set; }

        [StringLength(200)]
        public string cmbTipoCuenta { get; set; }

        [StringLength(200)]
        public string cmbEspecialidad { get; set; }

        [StringLength(200)]
        public string cmbSubEspecialidad { get; set; }

        [StringLength(200)]
        public string txtNomFiscal { get; set; }

        [StringLength(200)]
        public string txtNomComercial { get; set; }

        [StringLength(200)]
        public string txtNombre { get; set; }

        [StringLength(200)]
        public string txtApPaterno { get; set; }

        [StringLength(200)]
        public string txtApMaterno { get; set; }

        [StringLength(200)]
        public string txtNomCompleto { get; set; }

        [StringLength(200)]
        public string txtRFC { get; set; }

        [StringLength(200)]
        public string txtCURP { get; set; }

        [StringLength(200)]
        public string txtObservaciones { get; set; }

        [StringLength(200)]
        public string cmbCodEstatusCuenta { get; set; }

        [StringLength(200)]
        public string cmbMetodoPago { get; set; }

        [StringLength(200)]
        public string cmbBanco { get; set; }

        [StringLength(200)]
        public string txtCuentaBancaria { get; set; }

        [StringLength(200)]
        public string txtCLABE { get; set; }

        [StringLength(200)]
        public string txtCedulaProf { get; set; }

        [StringLength(200)]
        public string txtCedulaEsp { get; set; }

        [StringLength(200)]
        public string txtCertificacion { get; set; }

        [StringLength(200)]
        public string txtFechaCertificacion { get; set; }

        [StringLength(200)]
        public string chkIguala { get; set; }

        [StringLength(200)]
        public string txtImporteIguala { get; set; }

        [StringLength(200)]
        public string txtDescuentoPromSI { get; set; }

        [StringLength(200)]
        public string txtPrecioSerSI { get; set; }

        [StringLength(200)]
        public string txtPrecioSerMem { get; set; }

        [StringLength(200)]
        public string txtDescuentoMem { get; set; }

        [StringLength(200)]
        public string xUsrInsert { get; set; }
    }
}
