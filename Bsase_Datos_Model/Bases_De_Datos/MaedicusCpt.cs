using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Bases_De_Datos
{
    public partial class MaedicusCpt : DbContext
    {
        public MaedicusCpt()
            : base("name=MaedicusCpt")
        {
        }

        public virtual DbSet<ADM_TBL_ArchivoLOTLoteNal> ADM_TBL_ArchivoLOTLoteNal { get; set; }
        public virtual DbSet<AfiliadoAdssyf> AfiliadoAdssyf { get; set; }
        public virtual DbSet<AfiliadoAdssyf_20220906> AfiliadoAdssyf_20220906 { get; set; }
        public virtual DbSet<AfiliadoAdssyf_Log> AfiliadoAdssyf_Log { get; set; }
        public virtual DbSet<Agrupaciones> Agrupaciones { get; set; }
        public virtual DbSet<AgrupaPrestaciones> AgrupaPrestaciones { get; set; }
        public virtual DbSet<AprobacionNotasCredito> AprobacionNotasCredito { get; set; }
        public virtual DbSet<ArchivoMembrete> ArchivoMembrete { get; set; }
        public virtual DbSet<areas> areas { get; set; }
        public virtual DbSet<asd> asd { get; set; }
        public virtual DbSet<BandejaDental_Estatus> BandejaDental_Estatus { get; set; }
        public virtual DbSet<bandejaDentalCuadrante> bandejaDentalCuadrante { get; set; }
        public virtual DbSet<bandejaIncidencias> bandejaIncidencias { get; set; }
        public virtual DbSet<bandejaProgramacionSicologica> bandejaProgramacionSicologica { get; set; }
        public virtual DbSet<CaptureChangeLog> CaptureChangeLog { get; set; }
        public virtual DbSet<CaseEmpresa> CaseEmpresa { get; set; }
        public virtual DbSet<CatalogoFolios> CatalogoFolios { get; set; }
        public virtual DbSet<CatalogoPeriodicidad> CatalogoPeriodicidad { get; set; }
        public virtual DbSet<CatCodigosPostales> CatCodigosPostales { get; set; }
        public virtual DbSet<CatDocumentosAfiliado> CatDocumentosAfiliado { get; set; }
        public virtual DbSet<CatErrores> CatErrores { get; set; }
        public virtual DbSet<CatEstados> CatEstados { get; set; }
        public virtual DbSet<CatMunicipio> CatMunicipio { get; set; }
        public virtual DbSet<catReporte> catReporte { get; set; }
        public virtual DbSet<CIE10> CIE10 { get; set; }
        public virtual DbSet<clientes> clientes { get; set; }
        public virtual DbSet<CoberturaAddsyf> CoberturaAddsyf { get; set; }
        public virtual DbSet<CobranzaCotsco> CobranzaCotsco { get; set; }
        public virtual DbSet<Concepto> Concepto { get; set; }
        public virtual DbSet<concepto_WSFacturaXML> concepto_WSFacturaXML { get; set; }
        public virtual DbSet<ConceptosMovimiento> ConceptosMovimiento { get; set; }
        public virtual DbSet<CondicionesGenerales> CondicionesGenerales { get; set; }
        public virtual DbSet<Configuracion_OpValidadorFolios> Configuracion_OpValidadorFolios { get; set; }
        public virtual DbSet<Configuracion_SAMICPT> Configuracion_SAMICPT { get; set; }
        public virtual DbSet<ConfigurationFTP_SANOS> ConfigurationFTP_SANOS { get; set; }
        public virtual DbSet<ConfigurationMail_SANOS> ConfigurationMail_SANOS { get; set; }
        public virtual DbSet<controlElegibilidadesAfiliados> controlElegibilidadesAfiliados { get; set; }
        public virtual DbSet<CopagoValidador> CopagoValidador { get; set; }
        public virtual DbSet<CopayApplied> CopayApplied { get; set; }
        public virtual DbSet<CopiaFormato> CopiaFormato { get; set; }
        public virtual DbSet<CPT> CPT { get; set; }
        public virtual DbSet<CPTEmpresaPeriodicidad> CPTEmpresaPeriodicidad { get; set; }
        public virtual DbSet<CPTGeneral> CPTGeneral { get; set; }
        public virtual DbSet<Derhabs> Derhabs { get; set; }
        public virtual DbSet<derhabsesp> derhabsesp { get; set; }
        public virtual DbSet<descuentosProveedores> descuentosProveedores { get; set; }
        public virtual DbSet<DetallesFoliosConceptos> DetallesFoliosConceptos { get; set; }
        public virtual DbSet<DiagnosisCode> DiagnosisCode { get; set; }
        public virtual DbSet<diasFestivos> diasFestivos { get; set; }
        public virtual DbSet<Direccion> Direccion { get; set; }
        public virtual DbSet<DOCUMENTACIONENVIO> DOCUMENTACIONENVIO { get; set; }
        public virtual DbSet<DOCUMENTACIONENVIOCORREO> DOCUMENTACIONENVIOCORREO { get; set; }
        public virtual DbSet<DOCUMENTACIONENVIODETALLES> DOCUMENTACIONENVIODETALLES { get; set; }
        public virtual DbSet<DocumentacionSoporte> DocumentacionSoporte { get; set; }
        public virtual DbSet<DocumentacionSoporteEstatus> DocumentacionSoporteEstatus { get; set; }
        public virtual DbSet<DocumentacionSoporteProceso> DocumentacionSoporteProceso { get; set; }
        public virtual DbSet<DocumentosCargados> DocumentosCargados { get; set; }
        public virtual DbSet<DocumentosCargadosEliminacionLog> DocumentosCargadosEliminacionLog { get; set; }
        public virtual DbSet<empleadosRH> empleadosRH { get; set; }
        public virtual DbSet<empresaClientes> empresaClientes { get; set; }
        public virtual DbSet<EmpresaGrupo> EmpresaGrupo { get; set; }
        public virtual DbSet<Empresas> Empresas { get; set; }
        public virtual DbSet<ENTIDAD_FEDERATIVA> ENTIDAD_FEDERATIVA { get; set; }
        public virtual DbSet<EnvioDocumentacionMovimientos> EnvioDocumentacionMovimientos { get; set; }
        public virtual DbSet<EnvioDocumentacionStatus> EnvioDocumentacionStatus { get; set; }
        public virtual DbSet<Error_Log_SQL> Error_Log_SQL { get; set; }
        public virtual DbSet<Error_Log_VF> Error_Log_VF { get; set; }
        public virtual DbSet<ErrorCFDI> ErrorCFDI { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<EspecialidadDental> EspecialidadDental { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Estatus_Afiliado> Estatus_Afiliado { get; set; }
        public virtual DbSet<EstatusCargaProveedor> EstatusCargaProveedor { get; set; }
        public virtual DbSet<estatusCirugiaProramada> estatusCirugiaProramada { get; set; }
        public virtual DbSet<EstatusDocumentacionSoporte> EstatusDocumentacionSoporte { get; set; }
        public virtual DbSet<EstatusFactura> EstatusFactura { get; set; }
        public virtual DbSet<EstatusFacturaRemesa> EstatusFacturaRemesa { get; set; }
        public virtual DbSet<EstatusFacturaRemesaSAT> EstatusFacturaRemesaSAT { get; set; }
        public virtual DbSet<estatusProveedor> estatusProveedor { get; set; }
        public virtual DbSet<EstatusReembolso> EstatusReembolso { get; set; }
        public virtual DbSet<EstatusRemesas> EstatusRemesas { get; set; }
        public virtual DbSet<EtiquetaPago> EtiquetaPago { get; set; }
        public virtual DbSet<ExcludedProceduresByTipoGasto> ExcludedProceduresByTipoGasto { get; set; }
        public virtual DbSet<FacturaRemesa> FacturaRemesa { get; set; }
        public virtual DbSet<facturaRemesasMediaccess> facturaRemesasMediaccess { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<Facturas_HWS> Facturas_HWS { get; set; }
        public virtual DbSet<FacturaTypeService> FacturaTypeService { get; set; }
        public virtual DbSet<FacturaxRemesa> FacturaxRemesa { get; set; }
        public virtual DbSet<FechasSecuencias> FechasSecuencias { get; set; }
        public virtual DbSet<FIN_TBL_LayoutPagosRealizados> FIN_TBL_LayoutPagosRealizados { get; set; }
        public virtual DbSet<FirmasDocumentos> FirmasDocumentos { get; set; }
        public virtual DbSet<FolioReembolsos> FolioReembolsos { get; set; }
        public virtual DbSet<FolioRemesasReembolsos> FolioRemesasReembolsos { get; set; }
        public virtual DbSet<FoliosConceptos> FoliosConceptos { get; set; }
        public virtual DbSet<FoliosReceta> FoliosReceta { get; set; }
        public virtual DbSet<FoliosRemesa> FoliosRemesa { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<GroupersHospital> GroupersHospital { get; set; }
        public virtual DbSet<GynecologySpeciality> GynecologySpeciality { get; set; }
        public virtual DbSet<HospitalCopayLog> HospitalCopayLog { get; set; }
        public virtual DbSet<HospitalCopayStatus> HospitalCopayStatus { get; set; }
        public virtual DbSet<LogFacturasConError> LogFacturasConError { get; set; }
        public virtual DbSet<metodoPago> metodoPago { get; set; }
        public virtual DbSet<migrations> migrations { get; set; }
        public virtual DbSet<MotivoRechazoDocumentacion> MotivoRechazoDocumentacion { get; set; }
        public virtual DbSet<MotivoReclamacion> MotivoReclamacion { get; set; }
        public virtual DbSet<MotivoSolicitudReembolso> MotivoSolicitudReembolso { get; set; }
        public virtual DbSet<movimientosFacturas> movimientosFacturas { get; set; }
        public virtual DbSet<muestra_estatus> muestra_estatus { get; set; }
        public virtual DbSet<NivelesdeServicio> NivelesdeServicio { get; set; }
        public virtual DbSet<NotaCredito> NotaCredito { get; set; }
        public virtual DbSet<NotaCreditoDetalle> NotaCreditoDetalle { get; set; }
        public virtual DbSet<NotFounded_UUID> NotFounded_UUID { get; set; }
        public virtual DbSet<NotFounded_UUID_2018> NotFounded_UUID_2018 { get; set; }
        public virtual DbSet<NotFounded_UUID_2019> NotFounded_UUID_2019 { get; set; }
        public virtual DbSet<NotFounded_UUID_2020> NotFounded_UUID_2020 { get; set; }
        public virtual DbSet<NotificacionDiagnostico> NotificacionDiagnostico { get; set; }
        public virtual DbSet<NuevoTabuladorFarmacia_R> NuevoTabuladorFarmacia_R { get; set; }
        public virtual DbSet<NumeroRemesa> NumeroRemesa { get; set; }
        public virtual DbSet<NUR_ECE> NUR_ECE { get; set; }
        public virtual DbSet<ObservacionConcepto_Operacion> ObservacionConcepto_Operacion { get; set; }
        public virtual DbSet<ObservacionesConcepto> ObservacionesConcepto { get; set; }
        public virtual DbSet<Observations> Observations { get; set; }
        public virtual DbSet<OP_EMPRESA_TabuladorEspecial> OP_EMPRESA_TabuladorEspecial { get; set; }
        public virtual DbSet<OP_Factura_Remesas_Foliador> OP_Factura_Remesas_Foliador { get; set; }
        public virtual DbSet<OP_PEMEX_Recepcion> OP_PEMEX_Recepcion { get; set; }
        public virtual DbSet<OP_PEMEX_RecepcionLog> OP_PEMEX_RecepcionLog { get; set; }
        public virtual DbSet<OP_TBL_COSTOS> OP_TBL_COSTOS { get; set; }
        public virtual DbSet<OP_TBL_TabuladorFarmaciaMLOTNAL> OP_TBL_TabuladorFarmaciaMLOTNAL { get; set; }
        public virtual DbSet<OpeDetalleST> OpeDetalleST { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<Operacion_Compl> Operacion_Compl { get; set; }
        public virtual DbSet<Operacion_NotaCredito> Operacion_NotaCredito { get; set; }
        public virtual DbSet<OperationRollbackCopayHospital> OperationRollbackCopayHospital { get; set; }
        public virtual DbSet<Operations_Error_Log> Operations_Error_Log { get; set; }
        public virtual DbSet<OperationsCoverage> OperationsCoverage { get; set; }
        public virtual DbSet<OperationsDisabledLog> OperationsDisabledLog { get; set; }
        public virtual DbSet<OperationsDuplicated> OperationsDuplicated { get; set; }
        public virtual DbSet<OperationsMovementsLog> OperationsMovementsLog { get; set; }
        public virtual DbSet<Parametros> Parametros { get; set; }
        public virtual DbSet<ParametrosXRFC> ParametrosXRFC { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<PasoFarmaciasNuevoFormato> PasoFarmaciasNuevoFormato { get; set; }
        public virtual DbSet<PediatricSpeciality> PediatricSpeciality { get; set; }
        public virtual DbSet<PermisoDocumentoAfiliado> PermisoDocumentoAfiliado { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<PlanProducto> PlanProducto { get; set; }
        public virtual DbSet<PlanProductoAdssyf> PlanProductoAdssyf { get; set; }
        public virtual DbSet<PlanProductoAdssyf_Log> PlanProductoAdssyf_Log { get; set; }
        public virtual DbSet<Poblacion> Poblacion { get; set; }
        public virtual DbSet<PolizaAdssyf> PolizaAdssyf { get; set; }
        public virtual DbSet<PolizaCorreosEnvio> PolizaCorreosEnvio { get; set; }
        public virtual DbSet<procedimientOdontologico> procedimientOdontologico { get; set; }
        public virtual DbSet<ProductoMembrete> ProductoMembrete { get; set; }
        public virtual DbSet<ProvCargaEspecial> ProvCargaEspecial { get; set; }
        public virtual DbSet<ProvidersExceedsDays> ProvidersExceedsDays { get; set; }
        public virtual DbSet<ProvidersWithoutCopay> ProvidersWithoutCopay { get; set; }
        public virtual DbSet<ReasonRejectedFolio> ReasonRejectedFolio { get; set; }
        public virtual DbSet<Recursos_Medicos> Recursos_Medicos { get; set; }
        public virtual DbSet<ReglasStatusProcesoConcepto> ReglasStatusProcesoConcepto { get; set; }
        public virtual DbSet<RelacionDireccion> RelacionDireccion { get; set; }
        public virtual DbSet<RelationFacturasWithoutUuid_Log> RelationFacturasWithoutUuid_Log { get; set; }
        public virtual DbSet<relReporteUsuario> relReporteUsuario { get; set; }
        public virtual DbSet<Remesas> Remesas { get; set; }
        public virtual DbSet<Remittances> Remittances { get; set; }
        public virtual DbSet<RemittanceStatus> RemittanceStatus { get; set; }
        public virtual DbSet<RolConceptosEmpresas> RolConceptosEmpresas { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<RolReglasStatusProcesoConcepto> RolReglasStatusProcesoConcepto { get; set; }
        public virtual DbSet<RolStatusProcesoConcepto> RolStatusProcesoConcepto { get; set; }
        public virtual DbSet<Sami_Reportes_AreasCaptura> Sami_Reportes_AreasCaptura { get; set; }
        public virtual DbSet<Sami_TB_FacturaXMLP> Sami_TB_FacturaXMLP { get; set; }
        public virtual DbSet<SARSCoV2_Letters> SARSCoV2_Letters { get; set; }
        public virtual DbSet<SeguimientoProcesos> SeguimientoProcesos { get; set; }
        public virtual DbSet<SeguimientoStatus> SeguimientoStatus { get; set; }
        public virtual DbSet<sepomex> sepomex { get; set; }
        public virtual DbSet<SEPOMEX_CP> SEPOMEX_CP { get; set; }
        public virtual DbSet<SIS_CTLF_EstatusFolios> SIS_CTLF_EstatusFolios { get; set; }
        public virtual DbSet<SIS_CTLF_Folios> SIS_CTLF_Folios { get; set; }
        public virtual DbSet<SIS_CTLF_Stock> SIS_CTLF_Stock { get; set; }
        public virtual DbSet<Sistema> Sistema { get; set; }
        public virtual DbSet<SISTEMAS> SISTEMAS { get; set; }
        public virtual DbSet<SolicitudesPago> SolicitudesPago { get; set; }
        public virtual DbSet<SolicitudesPagoDetalle> SolicitudesPagoDetalle { get; set; }
        public virtual DbSet<SolicitudFacturacion> SolicitudFacturacion { get; set; }
        public virtual DbSet<SolicitudFacturacionDetalle> SolicitudFacturacionDetalle { get; set; }
        public virtual DbSet<SolicitudReembolso> SolicitudReembolso { get; set; }
        public virtual DbSet<SolicitudReembolsoxMotivoRechazoId> SolicitudReembolsoxMotivoRechazoId { get; set; }
        public virtual DbSet<SolicitudReembolsoxMotivoSolicitudReembolso> SolicitudReembolsoxMotivoSolicitudReembolso { get; set; }
        public virtual DbSet<StatusProcesoConcepto> StatusProcesoConcepto { get; set; }
        public virtual DbSet<SustitucionDeFactura> SustitucionDeFactura { get; set; }
        public virtual DbSet<sustitucionFacturas> sustitucionFacturas { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_App> Sys_Mediaccess_Acceso_App { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Ctrl> Sys_Mediaccess_Acceso_Ctrl { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Menu> Sys_Mediaccess_Acceso_Menu { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_MenuSub> Sys_Mediaccess_Acceso_MenuSub { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Perfil_no> Sys_Mediaccess_Acceso_Perfil_no { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Usr> Sys_Mediaccess_Acceso_Usr { get; set; }
        public virtual DbSet<sys_mediaccess_EventosRegistrosTablas> sys_mediaccess_EventosRegistrosTablas { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TabuladorConsulta> TabuladorConsulta { get; set; }
        public virtual DbSet<TabuladorCPT> TabuladorCPT { get; set; }
        public virtual DbSet<TabuladorEspecial> TabuladorEspecial { get; set; }
        public virtual DbSet<TabuladorEspecialidadPoblacion> TabuladorEspecialidadPoblacion { get; set; }
        public virtual DbSet<TabuladorFarmacia> TabuladorFarmacia { get; set; }
        public virtual DbSet<TabuladorFarmaciaE> TabuladorFarmaciaE { get; set; }
        public virtual DbSet<TabuladorFarmaciaExcelLog> TabuladorFarmaciaExcelLog { get; set; }
        public virtual DbSet<TabuladorFarmaciaM> TabuladorFarmaciaM { get; set; }
        public virtual DbSet<tabuladorFarmaciaMpromedio> tabuladorFarmaciaMpromedio { get; set; }
        public virtual DbSet<TabuladorPoblacion> TabuladorPoblacion { get; set; }
        public virtual DbSet<TabuladorProveedor> TabuladorProveedor { get; set; }
        public virtual DbSet<TabuladorProveedorPruebaAlta> TabuladorProveedorPruebaAlta { get; set; }
        public virtual DbSet<Tb_Sanos_RecFile> Tb_Sanos_RecFile { get; set; }
        public virtual DbSet<Tb_Sanos_RecFileDetail> Tb_Sanos_RecFileDetail { get; set; }
        public virtual DbSet<tb_TF_CatCargo> tb_TF_CatCargo { get; set; }
        public virtual DbSet<tb_TF_FacDet> tb_TF_FacDet { get; set; }
        public virtual DbSet<tb_TF_FacFile> tb_TF_FacFile { get; set; }
        public virtual DbSet<tb_TF_PaqFile> tb_TF_PaqFile { get; set; }
        public virtual DbSet<TemporalLayout> TemporalLayout { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoGasto> TipoGasto { get; set; }
        public virtual DbSet<TipoGastoListaPrecios> TipoGastoListaPrecios { get; set; }
        public virtual DbSet<TipoRemesa> TipoRemesa { get; set; }
        public virtual DbSet<TiposReembolso> TiposReembolso { get; set; }
        public virtual DbSet<TKM_Prospectos> TKM_Prospectos { get; set; }
        public virtual DbSet<Transferencias_TB_Cargo> Transferencias_TB_Cargo { get; set; }
        public virtual DbSet<Transferencias_TB_PagosLOG> Transferencias_TB_PagosLOG { get; set; }
        public virtual DbSet<TypeMovement> TypeMovement { get; set; }
        public virtual DbSet<TypeMovement_AfiliadoAddsyf> TypeMovement_AfiliadoAddsyf { get; set; }
        public virtual DbSet<TypeMovementPlanProducto> TypeMovementPlanProducto { get; set; }
        public virtual DbSet<TypeService> TypeService { get; set; }
        public virtual DbSet<Unauthorized_Medicines> Unauthorized_Medicines { get; set; }
        public virtual DbSet<UserApp> UserApp { get; set; }
        public virtual DbSet<UserAppDatos> UserAppDatos { get; set; }
        public virtual DbSet<UsuarioDatosAdicionales> UsuarioDatosAdicionales { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRol { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<usuarios_ws> usuarios_ws { get; set; }
        public virtual DbSet<ValidatedFileDetails> ValidatedFileDetails { get; set; }
        public virtual DbSet<ValidatedFiles> ValidatedFiles { get; set; }
        public virtual DbSet<ValidatedFilesLog> ValidatedFilesLog { get; set; }
        public virtual DbSet<WebModules> WebModules { get; set; }
        public virtual DbSet<WSFacturaXML> WSFacturaXML { get; set; }
        public virtual DbSet<WSFacturaXML_UUIDRelacionado> WSFacturaXML_UUIDRelacionado { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }
        public virtual DbSet<Formato> Formato { get; set; }
        public virtual DbSet<R_REPOSITORY_LOG> R_REPOSITORY_LOG { get; set; }
        public virtual DbSet<tb_BillAccount> tb_BillAccount { get; set; }
        public virtual DbSet<tb_BillCatCargo> tb_BillCatCargo { get; set; }
        public virtual DbSet<tb_BillFile> tb_BillFile { get; set; }
        public virtual DbSet<tb_BillFileRecipient> tb_BillFileRecipient { get; set; }
        public virtual DbSet<tb_BillFileRecipientDetail> tb_BillFileRecipientDetail { get; set; }
        public virtual DbSet<tb_BillState> tb_BillState { get; set; }
        public virtual DbSet<tb_BillStateLog> tb_BillStateLog { get; set; }
        public virtual DbSet<tb_PaymentsFile> tb_PaymentsFile { get; set; }
        public virtual DbSet<tb_PaymentsFileRecipient> tb_PaymentsFileRecipient { get; set; }
        public virtual DbSet<activos> activos { get; set; }
        public virtual DbSet<ActualizaTabuladorProveedor> ActualizaTabuladorProveedor { get; set; }
        public virtual DbSet<ADM_TBL_ActualizaFacturasLog> ADM_TBL_ActualizaFacturasLog { get; set; }
        public virtual DbSet<ADM_TBL_lineasLoteNalValidadas> ADM_TBL_lineasLoteNalValidadas { get; set; }
        public virtual DbSet<afiliado_log> afiliado_log { get; set; }
        public virtual DbSet<afiliados14_> afiliados14_ { get; set; }
        public virtual DbSet<afiliados25_> afiliados25_ { get; set; }
        public virtual DbSet<afiliados26_> afiliados26_ { get; set; }
        public virtual DbSet<AfilSicas> AfilSicas { get; set; }
        public virtual DbSet<altaCuentasRemesasLOG> altaCuentasRemesasLOG { get; set; }
        public virtual DbSet<ALZ_CLP_ListaProveedores> ALZ_CLP_ListaProveedores { get; set; }
        public virtual DbSet<archivoRemesas> archivoRemesas { get; set; }
        public virtual DbSet<asignacionCoberturaGrupoEmpresa> asignacionCoberturaGrupoEmpresa { get; set; }
        public virtual DbSet<asignacionPlanCobertura> asignacionPlanCobertura { get; set; }
        public virtual DbSet<asignacionPlanEmpresaGrupo> asignacionPlanEmpresaGrupo { get; set; }
        public virtual DbSet<autorizacionesGuate> autorizacionesGuate { get; set; }
        public virtual DbSet<ayuda> ayuda { get; set; }
        public virtual DbSet<ayudaproveedores> ayudaproveedores { get; set; }
        public virtual DbSet<bandejaDental> bandejaDental { get; set; }
        public virtual DbSet<bandejaProgramacion> bandejaProgramacion { get; set; }
        public virtual DbSet<bandejaprogramacionLog> bandejaprogramacionLog { get; set; }
        public virtual DbSet<cambioStatusMAC> cambioStatusMAC { get; set; }
        public virtual DbSet<Capitas_> Capitas_ { get; set; }
        public virtual DbSet<Cat_Codigo_Tabulador> Cat_Codigo_Tabulador { get; set; }
        public virtual DbSet<Catalogo_Medicamentos_SASE> Catalogo_Medicamentos_SASE { get; set; }
        public virtual DbSet<CatLocalidades> CatLocalidades { get; set; }
        public virtual DbSet<catLugaresIngreso> catLugaresIngreso { get; set; }
        public virtual DbSet<centrosCostoSantander> centrosCostoSantander { get; set; }
        public virtual DbSet<Cobertura_TipoGasto> Cobertura_TipoGasto { get; set; }
        public virtual DbSet<coberturasTipoGasto> coberturasTipoGasto { get; set; }
        public virtual DbSet<concentradoPagado30112009_> concentradoPagado30112009_ { get; set; }
        public virtual DbSet<concentradox> concentradox { get; set; }
        public virtual DbSet<ConfigTraceProcedimientos> ConfigTraceProcedimientos { get; set; }
        public virtual DbSet<controlFoliosCapturados> controlFoliosCapturados { get; set; }
        public virtual DbSet<CPT_CVEPROV_TIPOGASTO4> CPT_CVEPROV_TIPOGASTO4 { get; set; }
        public virtual DbSet<cptCirugia> cptCirugia { get; set; }
        public virtual DbSet<cptgeneral_log> cptgeneral_log { get; set; }
        public virtual DbSet<CuadroBasicoM> CuadroBasicoM { get; set; }
        public virtual DbSet<CuadroBasicoM_> CuadroBasicoM_ { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<CuentaMediaccess> CuentaMediaccess { get; set; }
        public virtual DbSet<DatoscuentaNafin> DatoscuentaNafin { get; set; }
        public virtual DbSet<DATOSFINALESNAFIN> DATOSFINALESNAFIN { get; set; }
        public virtual DbSet<derhabssicas> derhabssicas { get; set; }
        public virtual DbSet<derhabsspcnova> derhabsspcnova { get; set; }
        public virtual DbSet<DescuentoProveedor> DescuentoProveedor { get; set; }
        public virtual DbSet<dhx> dhx { get; set; }
        public virtual DbSet<elegibilidadessinpase> elegibilidadessinpase { get; set; }
        public virtual DbSet<ElegSinPE> ElegSinPE { get; set; }
        public virtual DbSet<empleadosRHLOG> empleadosRHLOG { get; set; }
        public virtual DbSet<empresa14_> empresa14_ { get; set; }
        public virtual DbSet<EmpresasFacturaAfiliado> EmpresasFacturaAfiliado { get; set; }
        public virtual DbSet<empresassicas> empresassicas { get; set; }
        public virtual DbSet<Envío_a_pago> Envío_a_pago { get; set; }
        public virtual DbSet<EspecialidadSASS> EspecialidadSASS { get; set; }
        public virtual DbSet<FacRes> FacRes { get; set; }
        public virtual DbSet<facturas_cambio> facturas_cambio { get; set; }
        public virtual DbSet<facturas_prueba> facturas_prueba { get; set; }
        public virtual DbSet<FacturasEmail> FacturasEmail { get; set; }
        public virtual DbSet<FacturasLOG> FacturasLOG { get; set; }
        public virtual DbSet<FacturasLOGcambioestatus> FacturasLOGcambioestatus { get; set; }
        public virtual DbSet<FacturasNAFIN> FacturasNAFIN { get; set; }
        public virtual DbSet<facturasNotaCredito> facturasNotaCredito { get; set; }
        public virtual DbSet<farmacias_> farmacias_ { get; set; }
        public virtual DbSet<FIN_TB_FacturasLayout> FIN_TB_FacturasLayout { get; set; }
        public virtual DbSet<folios> folios { get; set; }
        public virtual DbSet<foliosBloqueadosBoletinados> foliosBloqueadosBoletinados { get; set; }
        public virtual DbSet<generacionOrdenPago> generacionOrdenPago { get; set; }
        public virtual DbSet<grupos> grupos { get; set; }
        public virtual DbSet<HistoricoContador_Especiales_Bancomext> HistoricoContador_Especiales_Bancomext { get; set; }
        public virtual DbSet<HistoricoContador_Especiales_Bancomext_respaldo> HistoricoContador_Especiales_Bancomext_respaldo { get; set; }
        public virtual DbSet<Layout_SHF_Entrega> Layout_SHF_Entrega { get; set; }
        public virtual DbSet<Layout_SHF_fac> Layout_SHF_fac { get; set; }
        public virtual DbSet<Layout_SHF_Ope> Layout_SHF_Ope { get; set; }
        public virtual DbSet<ListaFechasRecalculo> ListaFechasRecalculo { get; set; }
        public virtual DbSet<LISTAPRECIOSESPECIALES> LISTAPRECIOSESPECIALES { get; set; }
        public virtual DbSet<listaspreciosFarmacias> listaspreciosFarmacias { get; set; }
        public virtual DbSet<Log_Parametros> Log_Parametros { get; set; }
        public virtual DbSet<Log_ParametrosXRFC> Log_ParametrosXRFC { get; set; }
        public virtual DbSet<Login_paso> Login_paso { get; set; }
        public virtual DbSet<LogProcedimientos> LogProcedimientos { get; set; }
        public virtual DbSet<MedicamentsAuthorized> MedicamentsAuthorized { get; set; }
        public virtual DbSet<MemoOperacion> MemoOperacion { get; set; }
        public virtual DbSet<nomina_> nomina_ { get; set; }
        public virtual DbSet<OP_Factura_Remesas> OP_Factura_Remesas { get; set; }
        public virtual DbSet<OP_Factura_Remesas_Catalogo> OP_Factura_Remesas_Catalogo { get; set; }
        public virtual DbSet<OP_Factura_Remesas_Devueltas> OP_Factura_Remesas_Devueltas { get; set; }
        public virtual DbSet<OP_Factura_Remesas_Foliador_LOG> OP_Factura_Remesas_Foliador_LOG { get; set; }
        public virtual DbSet<OP_PE_PEMEX_RemesasLog> OP_PE_PEMEX_RemesasLog { get; set; }
        public virtual DbSet<OP_PE_VF_LogValidaciones> OP_PE_VF_LogValidaciones { get; set; }
        public virtual DbSet<OP_PE_VF_PasoFarmaciasNuevoFormatoLog> OP_PE_VF_PasoFarmaciasNuevoFormatoLog { get; set; }
        public virtual DbSet<OP_PE_VF_TemporalPFNF> OP_PE_VF_TemporalPFNF { get; set; }
        public virtual DbSet<OP_TBL_CPT> OP_TBL_CPT { get; set; }
        public virtual DbSet<OP_TP_Remesas_Paso> OP_TP_Remesas_Paso { get; set; }
        public virtual DbSet<OP_TP_RemesasNova_Paso> OP_TP_RemesasNova_Paso { get; set; }
        public virtual DbSet<OP_VF_BANRURAL_Carga> OP_VF_BANRURAL_Carga { get; set; }
        public virtual DbSet<OP_VF_Bansefi_Carga> OP_VF_Bansefi_Carga { get; set; }
        public virtual DbSet<OP_VF_pemex_Carga> OP_VF_pemex_Carga { get; set; }
        public virtual DbSet<operacion_Autorizaciones> operacion_Autorizaciones { get; set; }
        public virtual DbSet<Operacion_Log> Operacion_Log { get; set; }
        public virtual DbSet<operacion_notacredito_log> operacion_notacredito_log { get; set; }
        public virtual DbSet<operacionElegibilidad> operacionElegibilidad { get; set; }
        public virtual DbSet<OperacionI> OperacionI { get; set; }
        public virtual DbSet<PaseEspecialistaSegundo> PaseEspecialistaSegundo { get; set; }
        public virtual DbSet<PasoFarmaciasNuevoFormatocamposnuevos> PasoFarmaciasNuevoFormatocamposnuevos { get; set; }
        public virtual DbSet<PasoFarmaciasNuevoFormatoI> PasoFarmaciasNuevoFormatoI { get; set; }
        public virtual DbSet<PasoFarmaciasTest> PasoFarmaciasTest { get; set; }
        public virtual DbSet<pasoTabuladorProveedor> pasoTabuladorProveedor { get; set; }
        public virtual DbSet<PlanProducto_12_11_2021> PlanProducto_12_11_2021 { get; set; }
        public virtual DbSet<PlanProducto_16_11_2021> PlanProducto_16_11_2021 { get; set; }
        public virtual DbSet<PolizaAdssyf_130522> PolizaAdssyf_130522 { get; set; }
        public virtual DbSet<preReemboslsosFacturas> preReemboslsosFacturas { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Producto_Comision> Producto_Comision { get; set; }
        public virtual DbSet<Proveedores_TB_ArchivoTXT> Proveedores_TB_ArchivoTXT { get; set; }
        public virtual DbSet<proveedoresBloqueados2014> proveedoresBloqueados2014 { get; set; }
        public virtual DbSet<Proveedoresfarmacialistaprecios> Proveedoresfarmacialistaprecios { get; set; }
        public virtual DbSet<proveedoresMismoRFCDiffClaveProveedor> proveedoresMismoRFCDiffClaveProveedor { get; set; }
        public virtual DbSet<R_CuadroBasicoM> R_CuadroBasicoM { get; set; }
        public virtual DbSet<Recursos_MedicosLOG> Recursos_MedicosLOG { get; set; }
        public virtual DbSet<RecursosBANRURAL> RecursosBANRURAL { get; set; }
        public virtual DbSet<RecursosBansefi> RecursosBansefi { get; set; }
        public virtual DbSet<RecursosPemex> RecursosPemex { get; set; }
        public virtual DbSet<Red> Red { get; set; }
        public virtual DbSet<red_cuenta> red_cuenta { get; set; }
        public virtual DbSet<RESPALDOBANDEJASTATUSPENDIENTE> RESPALDOBANDEJASTATUSPENDIENTE { get; set; }
        public virtual DbSet<Sami_Reportes_Listado> Sami_Reportes_Listado { get; set; }
        public virtual DbSet<Sami_Reportes_UsuariosCaptura> Sami_Reportes_UsuariosCaptura { get; set; }
        public virtual DbSet<Sami_Reportes_UsuariosCapturaBCK11022021> Sami_Reportes_UsuariosCapturaBCK11022021 { get; set; }
        public virtual DbSet<Sami_TB_Factura> Sami_TB_Factura { get; set; }
        public virtual DbSet<Samiweb_Devoluciones_Email> Samiweb_Devoluciones_Email { get; set; }
        public virtual DbSet<seguimientoCiruriaProgramada> seguimientoCiruriaProgramada { get; set; }
        public virtual DbSet<seguimientoIncidencias> seguimientoIncidencias { get; set; }
        public virtual DbSet<SIS_SAE_Padron> SIS_SAE_Padron { get; set; }
        public virtual DbSet<SYS_IVR_PaseEspecialista> SYS_IVR_PaseEspecialista { get; set; }
        public virtual DbSet<SYS_IVR_PaseEspecialista_completo> SYS_IVR_PaseEspecialista_completo { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Perfil> Sys_Mediaccess_Acceso_Perfil { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Perfil_> Sys_Mediaccess_Acceso_Perfil_ { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_SubPerfil> Sys_Mediaccess_Acceso_SubPerfil { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Usr_Bajas> Sys_Mediaccess_Acceso_Usr_Bajas { get; set; }
        public virtual DbSet<Sys_Mediaccess_Acceso_Usuarios> Sys_Mediaccess_Acceso_Usuarios { get; set; }
        public virtual DbSet<Sys_Mediaccess_Cambio_Monto_Captura> Sys_Mediaccess_Cambio_Monto_Captura { get; set; }
        public virtual DbSet<Sys_Mediaccess_EmpresasFacturaAfiliado> Sys_Mediaccess_EmpresasFacturaAfiliado { get; set; }
        public virtual DbSet<Sys_Mediaccess_ExcentoCopago> Sys_Mediaccess_ExcentoCopago { get; set; }
        public virtual DbSet<Sys_Mediaccess_LogSami> Sys_Mediaccess_LogSami { get; set; }
        public virtual DbSet<Sys_Mediaccess_PermisosEspeciales_Aplicativos> Sys_Mediaccess_PermisosEspeciales_Aplicativos { get; set; }
        public virtual DbSet<Sys_Mediaccess_PermisosEspeciales_Usuarios> Sys_Mediaccess_PermisosEspeciales_Usuarios { get; set; }
        public virtual DbSet<Sys_Mediaccess_ProcesosLog> Sys_Mediaccess_ProcesosLog { get; set; }
        public virtual DbSet<SYS_OP_TPClasi> SYS_OP_TPClasi { get; set; }
        public virtual DbSet<SYS_OP_TPCliente> SYS_OP_TPCliente { get; set; }
        public virtual DbSet<SYS_SAE_Padron> SYS_SAE_Padron { get; set; }
        public virtual DbSet<SYS_SAE_Padron_> SYS_SAE_Padron_ { get; set; }
        public virtual DbSet<SYS_SAE_PadronJ_> SYS_SAE_PadronJ_ { get; set; }
        public virtual DbSet<SYS_SAE_PadronLog> SYS_SAE_PadronLog { get; set; }
        public virtual DbSet<SYS_SAE_PadronLog_> SYS_SAE_PadronLog_ { get; set; }
        public virtual DbSet<TabuladorFarmacia_Tmp> TabuladorFarmacia_Tmp { get; set; }
        public virtual DbSet<TabuladorFarmaciaEmail> TabuladorFarmaciaEmail { get; set; }
        public virtual DbSet<TabuladorFarmaciaFTP> TabuladorFarmaciaFTP { get; set; }
        public virtual DbSet<TabuladorFarmaciaFTPLog> TabuladorFarmaciaFTPLog { get; set; }
        public virtual DbSet<TabuladorFarmaciaM_E_CargaRechazosLog> TabuladorFarmaciaM_E_CargaRechazosLog { get; set; }
        public virtual DbSet<TabuladorFarmaciaM_E_ReplicaLog> TabuladorFarmaciaM_E_ReplicaLog { get; set; }
        public virtual DbSet<TabuladorFarmaciaM_log> TabuladorFarmaciaM_log { get; set; }
        public virtual DbSet<TabuladorFarmaciaM_R> TabuladorFarmaciaM_R { get; set; }
        public virtual DbSet<TabuladorFarmaciaMM> TabuladorFarmaciaMM { get; set; }
        public virtual DbSet<TabuladorFarmaciaMPromedio_> TabuladorFarmaciaMPromedio_ { get; set; }
        public virtual DbSet<TabuladorFarmaciaMpromedio_log> TabuladorFarmaciaMpromedio_log { get; set; }
        public virtual DbSet<tabuladorFarmaciaMpromedio_log_modificaciones> tabuladorFarmaciaMpromedio_log_modificaciones { get; set; }
        public virtual DbSet<TabuladorFarmaciaMPromedioLOG> TabuladorFarmaciaMPromedioLOG { get; set; }
        public virtual DbSet<TabuladorFarmaciaMPromedioReciente> TabuladorFarmaciaMPromedioReciente { get; set; }
        public virtual DbSet<TabuladorFarmaciaMPromedioRecienteNEW> TabuladorFarmaciaMPromedioRecienteNEW { get; set; }
        public virtual DbSet<TabuladorGeneral> TabuladorGeneral { get; set; }
        public virtual DbSet<TabuladorGeneral_LOG> TabuladorGeneral_LOG { get; set; }
        public virtual DbSet<tabuladorLYF> tabuladorLYF { get; set; }
        public virtual DbSet<TabuladorProveedor_Log> TabuladorProveedor_Log { get; set; }
        public virtual DbSet<TabuladorProveedorM> TabuladorProveedorM { get; set; }
        public virtual DbSet<tabuladorProveedorPaso2012> tabuladorProveedorPaso2012 { get; set; }
        public virtual DbSet<tabuladorSAE> tabuladorSAE { get; set; }
        public virtual DbSet<TB_OP_Bansefi_Remesa> TB_OP_Bansefi_Remesa { get; set; }
        public virtual DbSet<TB_Sami_Control> TB_Sami_Control { get; set; }
        public virtual DbSet<TB_Sami_UsrAdmin> TB_Sami_UsrAdmin { get; set; }
        public virtual DbSet<tb_TF_CatTransf> tb_TF_CatTransf { get; set; }
        public virtual DbSet<tb_TF_Fac> tb_TF_Fac { get; set; }
        public virtual DbSet<tb_TF_Pag> tb_TF_Pag { get; set; }
        public virtual DbSet<tb_TF_PagFin> tb_TF_PagFin { get; set; }
        public virtual DbSet<tb_TF_PagFin_log> tb_TF_PagFin_log { get; set; }
        public virtual DbSet<tb_TF_PagLOG> tb_TF_PagLOG { get; set; }
        public virtual DbSet<tbHospicheckDetail> tbHospicheckDetail { get; set; }
        public virtual DbSet<TBL_OP_TP_Remesas> TBL_OP_TP_Remesas { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TMP_CPT> TMP_CPT { get; set; }
        public virtual DbSet<Transferencias_TB_Cargo23122021> Transferencias_TB_Cargo23122021 { get; set; }
        public virtual DbSet<Transferencias_TB_CargoLOG> Transferencias_TB_CargoLOG { get; set; }
        public virtual DbSet<Transferencias_TB_Facturas> Transferencias_TB_Facturas { get; set; }
        public virtual DbSet<Transferencias_TB_LogFacturas> Transferencias_TB_LogFacturas { get; set; }
        public virtual DbSet<UbicacionAfiliado14_> UbicacionAfiliado14_ { get; set; }
        public virtual DbSet<UbicacionAfiliado25_> UbicacionAfiliado25_ { get; set; }
        public virtual DbSet<UbicacionAfiliado26_> UbicacionAfiliado26_ { get; set; }
        public virtual DbSet<ubicacionesArchivo> ubicacionesArchivo { get; set; }
        public virtual DbSet<USUARIO_SISTEMAS> USUARIO_SISTEMAS { get; set; }
        public virtual DbSet<Usuarios_Bajas> Usuarios_Bajas { get; set; }
        public virtual DbSet<ValidatedFilesMovimientosLog> ValidatedFilesMovimientosLog { get; set; }
        public virtual DbSet<WebService_ProveedorDiasHabiles> WebService_ProveedorDiasHabiles { get; set; }
        public virtual DbSet<WSFacturaXMLJunior> WSFacturaXMLJunior { get; set; }
        public virtual DbSet<ZADM_TBL_lineasLoteNalValidadasrespaldo> ZADM_TBL_lineasLoteNalValidadasrespaldo { get; set; }
        public virtual DbSet<DatosIvr> DatosIvr { get; set; }
        public virtual DbSet<afiliados14_1> afiliados14_1 { get; set; }
        public virtual DbSet<CargaMasivaFarmacia> CargaMasivaFarmacia { get; set; }
        public virtual DbSet<gastoTOtalLentes_> gastoTOtalLentes_ { get; set; }
        public virtual DbSet<gastoTotalReembolsos> gastoTotalReembolsos { get; set; }
        public virtual DbSet<Maric> Maric { get; set; }
        public virtual DbSet<sysdiagrams1> sysdiagrams1 { get; set; }
        public virtual DbSet<tabuladorProveedorPaso> tabuladorProveedorPaso { get; set; }
        public virtual DbSet<autorizacionesMI_> autorizacionesMI_ { get; set; }
        public virtual DbSet<coberturasProductos> coberturasProductos { get; set; }
        public virtual DbSet<coberturasproductosIIBSL200NONO0715> coberturasproductosIIBSL200NONO0715 { get; set; }
        public virtual DbSet<coberturasproductosTMP> coberturasproductosTMP { get; set; }
        public virtual DbSet<tb_BillCatTransf> tb_BillCatTransf { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Consecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Paciente)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ArchivoLOTLoteNal>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.IdPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.NumeroPolizaUnico)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.IdExterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.StsPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.IdTipoSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.CodAgente)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.PlanCoberturas)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.EstadoPlan)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.NOMBRECLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf>()
                .Property(e => e.CODPARENT)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.IdPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.NumeroPolizaUnico)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.IdExterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.StsPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.IdTipoSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.CodAgente)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.PlanCoberturas)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.EstadoPlan)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.NOMBRECLIENTE)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_20220906>()
                .Property(e => e.CODPARENT)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoAdssyf_Log>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<Agrupaciones>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AgrupaPrestaciones>()
                .Property(e => e.ProductoId)
                .IsUnicode(false);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Agrupador)
                .IsUnicode(false);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Importe)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Descuento)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.PrecioPublico)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Iva)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Isr)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Retiva)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.ImpCedular)
                .HasPrecision(10, 2);

            modelBuilder.Entity<AprobacionNotasCredito>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<ArchivoMembrete>()
                .Property(e => e.Agrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<ArchivoMembrete>()
                .Property(e => e.Membrete)
                .IsUnicode(false);

            modelBuilder.Entity<ArchivoMembrete>()
                .Property(e => e.ReporteCredencial)
                .IsUnicode(false);

            modelBuilder.Entity<areas>()
                .Property(e => e.area)
                .IsUnicode(false);

            modelBuilder.Entity<areas>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaDental_Estatus>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaDental_Estatus>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaDental_Estatus>()
                .Property(e => e.cve_provMedico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaDental_Estatus>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaDental_Estatus>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaDental_Estatus>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.cve_provMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.descDental)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.cve_provRealiza)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.datosExploracion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.obsAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.indicacionesMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.indicacionesPaciente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.indicacionesHospital)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.observacionPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .Property(e => e.cve_cie)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDentalCuadrante>()
                .HasMany(e => e.procedimientOdontologico)
                .WithRequired(e => e.bandejaDentalCuadrante)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.usrRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.incidencia)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.solucion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.usrCierre)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.nombreResponsable)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.emailResponsable)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.telResponsable)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.celResponsable)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.pendientes)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.nombreContacto)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.telContacto)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaIncidencias>()
                .Property(e => e.celContacto)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacionSicologica>()
                .Property(e => e.codafiliado_xk)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacionSicologica>()
                .Property(e => e.frecuencia)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacionSicologica>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CaptureChangeLog>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.NombreEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.NombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.CodEstatusEmpresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CaseEmpresa>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoFolios>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoPeriodicidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoPeriodicidad>()
                .Property(e => e.Intervalo)
                .IsUnicode(false);

            modelBuilder.Entity<CatCodigosPostales>()
                .Property(e => e.d_codigo)
                .IsUnicode(false);

            modelBuilder.Entity<CatCodigosPostales>()
                .Property(e => e.cve_ent)
                .IsUnicode(false);

            modelBuilder.Entity<CatCodigosPostales>()
                .Property(e => e.d_municipio)
                .IsUnicode(false);

            modelBuilder.Entity<CatCodigosPostales>()
                .Property(e => e.cve_mun)
                .IsUnicode(false);

            modelBuilder.Entity<CatCodigosPostales>()
                .Property(e => e.d_asenta)
                .IsUnicode(false);

            modelBuilder.Entity<CatDocumentosAfiliado>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<CatDocumentosAfiliado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CatErrores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatEstados>()
                .Property(e => e.cve_ent)
                .IsUnicode(false);

            modelBuilder.Entity<CatEstados>()
                .Property(e => e.nom_ent)
                .IsUnicode(false);

            modelBuilder.Entity<CatEstados>()
                .Property(e => e.nom_abr)
                .IsUnicode(false);

            modelBuilder.Entity<catReporte>()
                .Property(e => e.nombreReporte)
                .IsUnicode(false);

            modelBuilder.Entity<catReporte>()
                .Property(e => e.contructorReporte)
                .IsUnicode(false);

            modelBuilder.Entity<CIE10>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CIE10>()
                .Property(e => e.diagnostico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.cliente)
                .IsUnicode(false);

            modelBuilder.Entity<clientes>()
                .Property(e => e.clientesIncidencias)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaAddsyf>()
                .Property(e => e.CodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaAddsyf>()
                .Property(e => e.DescripcionCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaAddsyf>()
                .Property(e => e.NumeroPolizaUnico)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaAddsyf>()
                .Property(e => e.CODPLANPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.adicional1)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.adicional2)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.adicional3)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.adicional4)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.adicional5)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.tipoPago)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.rga)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.tipoCobro)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.importeRga)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.cobranza)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.saldo)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.montoNC)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.montoPendienteCobro)
                .HasPrecision(10, 2);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.fA)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.estatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.factureaRelacionada)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.usu_alta)
                .IsUnicode(false);

            modelBuilder.Entity<CobranzaCotsco>()
                .Property(e => e.usu_cambio)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .Property(e => e.Concepto1)
                .IsUnicode(false);

            modelBuilder.Entity<Concepto>()
                .HasMany(e => e.ReglasStatusProcesoConcepto)
                .WithRequired(e => e.Concepto)
                .HasForeignKey(e => new { e.codEstatusFactura, e.codConceptoOrigen })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Concepto>()
                .HasMany(e => e.ReglasStatusProcesoConcepto1)
                .WithRequired(e => e.Concepto1)
                .HasForeignKey(e => new { e.codEstatusFactura, e.codConceptoDestino })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Concepto>()
                .HasMany(e => e.StatusProcesoConcepto)
                .WithRequired(e => e.Concepto)
                .HasForeignKey(e => new { e.CodEstatusFactura, e.CodConcepto })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<concepto_WSFacturaXML>()
                .Property(e => e.unidad)
                .IsUnicode(false);

            modelBuilder.Entity<concepto_WSFacturaXML>()
                .Property(e => e.noIdentificacion)
                .IsUnicode(false);

            modelBuilder.Entity<concepto_WSFacturaXML>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionesGenerales>()
                .Property(e => e.Agrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionesGenerales>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<CondicionesGenerales>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Configuracion_OpValidadorFolios>()
                .Property(e => e.ImporteMaximo_Remesa)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Configuracion_OpValidadorFolios>()
                .Property(e => e.TipoRemesa_VF)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationFTP_SANOS>()
                .Property(e => e.FTPServerIP)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationFTP_SANOS>()
                .Property(e => e.FTPUser)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationFTP_SANOS>()
                .Property(e => e.FTPPassword)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.TemplateHTML_Confirmation)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.TemplateHTML_Notification)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.TemplateHTML_Error)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.MailReceives)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.MailSend)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.MailSend_Password)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.SMTP_Host)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.MailReceives_CC1)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.MailReceives_CC2)
                .IsUnicode(false);

            modelBuilder.Entity<ConfigurationMail_SANOS>()
                .Property(e => e.MailReceives_CC3)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.nomina)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.xusrCapturo)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<controlElegibilidadesAfiliados>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<CopagoValidador>()
                .Property(e => e.FolioMed)
                .IsUnicode(false);

            modelBuilder.Entity<CopagoValidador>()
                .Property(e => e.AutorizacionMed)
                .IsUnicode(false);

            modelBuilder.Entity<CopagoValidador>()
                .Property(e => e.Descripcion_med)
                .IsUnicode(false);

            modelBuilder.Entity<CopayApplied>()
                .Property(e => e.Cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<CopayApplied>()
                .HasMany(e => e.HospitalCopayLog)
                .WithRequired(e => e.CopayApplied)
                .HasForeignKey(e => e.CopayApplied_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CopayApplied>()
                .HasMany(e => e.OperationRollbackCopayHospital)
                .WithRequired(e => e.CopayApplied)
                .HasForeignKey(e => e.CopayApplied_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CopiaFormato>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<CopiaFormato>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<CopiaFormato>()
                .Property(e => e.CopiaFormato1)
                .IsUnicode(false);

            modelBuilder.Entity<CopiaFormato>()
                .Property(e => e.CodVista)
                .IsUnicode(false);

            modelBuilder.Entity<CopiaFormato>()
                .Property(e => e.codTabulador)
                .IsFixedLength();

            modelBuilder.Entity<CPT>()
                .Property(e => e.CPT1)
                .IsUnicode(false);

            modelBuilder.Entity<CPT>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<CPT>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<CPT>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CPT>()
                .Property(e => e.Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<CPT>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CPT>()
                .HasMany(e => e.OP_TBL_COSTOS)
                .WithRequired(e => e.CPT1)
                .HasForeignKey(e => e.CPT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPT>()
                .HasMany(e => e.procedimientOdontologico)
                .WithRequired(e => e.CPT1)
                .HasForeignKey(e => e.CPT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPT>()
                .HasMany(e => e.TabuladorCPT)
                .WithRequired(e => e.CPT1)
                .HasForeignKey(e => e.CPT)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CPTEmpresaPeriodicidad>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<CPTEmpresaPeriodicidad>()
                .Property(e => e.CPTEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<CPTEmpresaPeriodicidad>()
                .Property(e => e.Prestacion)
                .IsUnicode(false);

            modelBuilder.Entity<CPTGeneral>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<CPTGeneral>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<CPTGeneral>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<CPTGeneral>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CPTGeneral>()
                .Property(e => e.Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<CPTGeneral>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.Nombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.Edad)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.cve_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.Tipo_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.cve_derhab)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.codPropiedad)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Derhabs>()
                .Property(e => e.codAseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.ProvOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.Numbenef)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsesp>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<descuentosProveedores>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<descuentosProveedores>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<descuentosProveedores>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<DetallesFoliosConceptos>()
                .Property(e => e.codConceptoOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<DetallesFoliosConceptos>()
                .Property(e => e.codConceptoDestino)
                .IsUnicode(false);

            modelBuilder.Entity<DetallesFoliosConceptos>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<DiagnosisCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<DiagnosisCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.NumeroExterior)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.NumeroInterior)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Latitud)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Longitud)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Altitud)
                .HasPrecision(18, 10);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<Direccion>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .Property(e => e.OT)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .HasMany(e => e.DOCUMENTACIONENVIODETALLES)
                .WithRequired(e => e.DOCUMENTACIONENVIO)
                .HasForeignKey(e => e.envio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .HasMany(e => e.DocumentosCargados)
                .WithRequired(e => e.DOCUMENTACIONENVIO)
                .HasForeignKey(e => e.EnvioDocumentacion_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .HasMany(e => e.EnvioDocumentacionMovimientos)
                .WithRequired(e => e.DOCUMENTACIONENVIO)
                .HasForeignKey(e => e.Envio_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCUMENTACIONENVIO>()
                .HasMany(e => e.DOCUMENTACIONENVIOCORREO)
                .WithRequired(e => e.DOCUMENTACIONENVIO)
                .HasForeignKey(e => e.idenvio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DOCUMENTACIONENVIOCORREO>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIOCORREO>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIOCORREO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIOCORREO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.iCodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.apellido_Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.apellido_Materno)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.contrato)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.certificado)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.clave_Plan)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.plan_dsc)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.archivo_Original)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.archivo_Final)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.email_Agente)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.email_Promotor)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.email_Ejecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.num_Solicitud)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DOCUMENTACIONENVIODETALLES>()
                .Property(e => e.vigencia)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporte>()
                .Property(e => e.Identificador)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporte>()
                .Property(e => e.Documento)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporte>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporte>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporteEstatus>()
                .Property(e => e.MotivoRechazo)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporteEstatus>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporteEstatus>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporteEstatus>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporteProceso>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentacionSoporteProceso>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosCargados>()
                .Property(e => e.UsuarioCarga)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosCargados>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosCargados>()
                .Property(e => e.FileSize)
                .IsUnicode(false);

            modelBuilder.Entity<DocumentosCargados>()
                .HasMany(e => e.DocumentosCargadosEliminacionLog)
                .WithRequired(e => e.DocumentosCargados)
                .HasForeignKey(e => e.DocumentoCargado_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentosCargadosEliminacionLog>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.aPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.aMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.codSexo)
                .IsFixedLength();

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.codEstado)
                .IsFixedLength();

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.curp)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.nss)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.puesto)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.emailMacc)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.lada)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.num1)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.cel1)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.idBanco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.cuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.cuentaClabe)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.idEmpleadoJefe)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.usrRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.usrModifico)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRH>()
                .Property(e => e.usrBaja)
                .IsUnicode(false);

            modelBuilder.Entity<empresaClientes>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<empresaClientes>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaGrupo>()
                .Property(e => e.CveEmpresaGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaGrupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresas>()
                .Property(e => e.empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ENTIDAD_FEDERATIVA>()
                .Property(e => e.id_codigo_iso_pais)
                .IsUnicode(false);

            modelBuilder.Entity<ENTIDAD_FEDERATIVA>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ENTIDAD_FEDERATIVA>()
                .Property(e => e.abreviatura)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioDocumentacionMovimientos>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioDocumentacionStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioDocumentacionStatus>()
                .HasMany(e => e.DOCUMENTACIONENVIO)
                .WithOptional(e => e.EnvioDocumentacionStatus)
                .HasForeignKey(e => e.EnvioStatus_Id)
                .WillCascadeOnDelete();

            modelBuilder.Entity<EnvioDocumentacionStatus>()
                .HasMany(e => e.EnvioDocumentacionMovimientos)
                .WithRequired(e => e.EnvioDocumentacionStatus)
                .HasForeignKey(e => e.StatusEnvioDocumentacion_Id);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_VF>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_VF>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorCFDI>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<ErrorCFDI>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Especialidad1)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Articulo_con_Retencion)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Articulo_sin_Retencion)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .HasMany(e => e.Recursos_Medicos)
                .WithRequired(e => e.Especialidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EspecialidadDental>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Estado1)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.CodZona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Afiliado>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Afiliado>()
                .Property(e => e.EstatusAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Afiliado>()
                .HasMany(e => e.Derhabs)
                .WithRequired(e => e.Estatus_Afiliado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstatusCargaProveedor>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusCargaProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<estatusCirugiaProramada>()
                .Property(e => e.estatusSeguimiento)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusDocumentacionSoporte>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusDocumentacionSoporte>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusDocumentacionSoporte>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFactura>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFactura>()
                .Property(e => e.EstatusFactura1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFactura>()
                .HasMany(e => e.Facturas)
                .WithRequired(e => e.EstatusFactura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstatusFacturaRemesa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFacturaRemesaSAT>()
                .Property(e => e.idEstatusFacturaRemesaSAT)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFacturaRemesaSAT>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<estatusProveedor>()
                .Property(e => e.codEstatusProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<estatusProveedor>()
                .Property(e => e.estatusProveedor1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusReembolso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusReembolso>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusReembolso>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusRemesas>()
                .Property(e => e.EstatusRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<EtiquetaPago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<EtiquetaPago>()
                .HasMany(e => e.Operacion_Compl)
                .WithRequired(e => e.EtiquetaPago)
                .HasForeignKey(e => e.EtiquetaPago_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ExcludedProceduresByTipoGasto>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<ExcludedProceduresByTipoGasto>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.RFCEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.XML)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.PDF)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.TotalFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.SubtotalFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.DescuentoFactura)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.idEstatusFacturaRemesaSAT)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaRemesa>()
                .HasMany(e => e.FacturaxRemesa)
                .WithRequired(e => e.FacturaRemesa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<facturaRemesasMediaccess>()
                .Property(e => e.serie)
                .IsFixedLength();

            modelBuilder.Entity<facturaRemesasMediaccess>()
                .Property(e => e.cve_empresa)
                .IsFixedLength();

            modelBuilder.Entity<facturaRemesasMediaccess>()
                .Property(e => e.factura)
                .IsUnicode(false);

            modelBuilder.Entity<facturaRemesasMediaccess>()
                .Property(e => e.codEstatusFactura)
                .IsFixedLength();

            modelBuilder.Entity<facturaRemesasMediaccess>()
                .Property(e => e.usrGenero)
                .IsFixedLength();

            modelBuilder.Entity<Facturas>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.LugarIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.CaptureChangeLog)
                .WithRequired(e => e.Facturas)
                .HasForeignKey(e => e.MacSequenceReturned)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.CaptureChangeLog1)
                .WithRequired(e => e.Facturas1)
                .HasForeignKey(e => e.MacSequenceCapture)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.controlElegibilidadesAfiliados)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.derhabsesp)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.tb_BillFileRecipient)
                .WithOptional(e => e.Facturas)
                .HasForeignKey(e => e.Sequence);

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.controlFoliosCapturados)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.FacturasLOG)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.facturasNotaCredito)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.HistoricoContador_Especiales_Bancomext)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Layout_SHF_Ope)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.movimientosFacturas)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.OP_VF_BANRURAL_Carga)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.OP_VF_Bansefi_Carga)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Operacion)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Operacion_Compl)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Operacion_Log)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.RecursosPemex)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.sustitucionFacturas)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.tb_TF_Fac)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.tb_TF_FacDet)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Transferencias_TB_Facturas)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Transferencias_TB_LogFacturas)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.Transferencias_TB_PagosLOG)
                .WithOptional(e => e.Facturas)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Facturas>()
                .HasMany(e => e.FacturaTypeService)
                .WithRequired(e => e.Facturas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Facturas_HWS>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_HWS>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_HWS>()
                .Property(e => e.num_episodio)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_HWS>()
                .Property(e => e.edo_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaxRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaxRemesa>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<FechasSecuencias>()
                .Property(e => e.Cve_Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<FechasSecuencias>()
                .Property(e => e.SubEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<FechasSecuencias>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<FechasSecuencias>()
                .Property(e => e.RGA)
                .IsUnicode(false);

            modelBuilder.Entity<FechasSecuencias>()
                .Property(e => e.EstatusSistema)
                .IsUnicode(false);

            modelBuilder.Entity<FechasSecuencias>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TBL_LayoutPagosRealizados>()
                .Property(e => e.NombreArchivo)
                .IsFixedLength();

            modelBuilder.Entity<FIN_TBL_LayoutPagosRealizados>()
                .Property(e => e.ClaveArchivo)
                .IsFixedLength();

            modelBuilder.Entity<FirmasDocumentos>()
                .Property(e => e.ClaveFormato)
                .IsUnicode(false);

            modelBuilder.Entity<FirmasDocumentos>()
                .Property(e => e.Persona)
                .IsUnicode(false);

            modelBuilder.Entity<FirmasDocumentos>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<FirmasDocumentos>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<FirmasDocumentos>()
                .Property(e => e.usu_alta)
                .IsUnicode(false);

            modelBuilder.Entity<FirmasDocumentos>()
                .Property(e => e.usu_cambio)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosConceptos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosConceptos>()
                .HasMany(e => e.DetallesFoliosConceptos)
                .WithRequired(e => e.FoliosConceptos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.PrecioMac)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Copago)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FoliosReceta>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosRemesa>()
                .Property(e => e.FolioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GroupersHospital>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<GroupersHospital>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<GynecologySpeciality>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<GynecologySpeciality>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HospitalCopayLog>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<HospitalCopayStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<HospitalCopayStatus>()
                .HasMany(e => e.CopayApplied)
                .WithRequired(e => e.HospitalCopayStatus)
                .HasForeignKey(e => e.HospitalCopayStatus_Id);

            modelBuilder.Entity<HospitalCopayStatus>()
                .HasMany(e => e.HospitalCopayLog)
                .WithRequired(e => e.HospitalCopayStatus)
                .HasForeignKey(e => e.HospitalCopayStatus_Id);

            modelBuilder.Entity<LogFacturasConError>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<metodoPago>()
                .Property(e => e.metodo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<metodoPago>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoRechazoDocumentacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoRechazoDocumentacion>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoRechazoDocumentacion>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoReclamacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoSolicitudReembolso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.codestatusfactura)
                .IsFixedLength();

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.codConcepto)
                .IsFixedLength();

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<movimientosFacturas>()
                .HasMany(e => e.ConceptosMovimiento)
                .WithRequired(e => e.movimientosFacturas)
                .HasForeignKey(e => e.Movimiento_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<muestra_estatus>()
                .Property(e => e.condiones)
                .IsUnicode(false);

            modelBuilder.Entity<muestra_estatus>()
                .Property(e => e.resultados)
                .IsUnicode(false);

            modelBuilder.Entity<muestra_estatus>()
                .Property(e => e.comando)
                .IsFixedLength();

            modelBuilder.Entity<muestra_estatus>()
                .Property(e => e.usuario_cambios)
                .IsUnicode(false);

            modelBuilder.Entity<NivelesdeServicio>()
                .Property(e => e.HorasNivelServicio)
                .HasPrecision(8, 2);

            modelBuilder.Entity<NivelesdeServicio>()
                .Property(e => e.PorcentajeTolerancia)
                .HasPrecision(4, 2);

            modelBuilder.Entity<NivelesdeServicio>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<NivelesdeServicio>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.XML)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.PDF)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.NombreEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.TotalFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.SubtotalFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.DescuentoFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.ImpuestosFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.FolioFactura)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.FolioNotaCredito)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.ArchivoNotaCredito)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.ArchivoNotaCreditoPDF)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .Property(e => e.Periodo)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCredito>()
                .HasMany(e => e.NotaCreditoDetalle)
                .WithRequired(e => e.NotaCredito)
                .HasForeignKey(e => e.IdNotaCredito)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.RemesaSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.Monto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.IVA)
                .HasPrecision(10, 2);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.CveEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<NotaCreditoDetalle>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.TransmitterRFC)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.Subtotal)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.IVA)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.Total)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.Discount)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.TransmitterRFC)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.Subtotal)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.IVA)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.Total)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.Discount)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2018>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.TransmitterRFC)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.Subtotal)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.IVA)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.Total)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.Discount)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2019>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.TransmitterRFC)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.Subtotal)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.IVA)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.Total)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.Discount)
                .HasPrecision(15, 4);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<NotFounded_UUID_2020>()
                .Property(e => e.BillNumber)
                .IsUnicode(false);

            modelBuilder.Entity<NotificacionDiagnostico>()
                .Property(e => e.cveCie)
                .IsUnicode(false);

            modelBuilder.Entity<NotificacionDiagnostico>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<NuevoTabuladorFarmacia_R>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<NuevoTabuladorFarmacia_R>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<NuevoTabuladorFarmacia_R>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.CveEmpresaGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<NumeroRemesa>()
                .Property(e => e.ClaveSistema)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.NUR)
                .IsUnicode(false);

            modelBuilder.Entity<NUR_ECE>()
                .Property(e => e.CIE10)
                .IsUnicode(false);

            modelBuilder.Entity<ObservacionesConcepto>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ObservacionesConcepto>()
                .HasMany(e => e.ObservacionConcepto_Operacion)
                .WithRequired(e => e.ObservacionesConcepto)
                .HasForeignKey(e => e.ObservacionConcepto_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador>()
                .Property(e => e.CodEmp)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador>()
                .Property(e => e.Cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Cve_Prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.No_Fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.F_sapi)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Guia)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.F_Envio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.F_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Recibe)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.StFactura)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Dias_Trans)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Uinsert)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_Recepcion>()
                .Property(e => e.Uupdate)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.F_sapi)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.Guia)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.F_Envio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.F_Entrega)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.Recibe)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.StFactura)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.Dias_Trans)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PEMEX_RecepcionLog>()
                .Property(e => e.Usr)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_COSTOS>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_COSTOS>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_TabuladorFarmaciaMLOTNAL>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_TabuladorFarmaciaMLOTNAL>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_TabuladorFarmaciaMLOTNAL>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<OpeDetalleST>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OpeDetalleST>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OpeDetalleST>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OpeDetalleST>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.Num_Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_cie_egreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .Property(e => e.cve_cie_segdiag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.ConceptosMovimiento)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.ObservacionConcepto_Operacion)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.Observations)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.OperationsMovementsLog)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.OperationsDisabledLog)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.Operacion_Compl)
                .WithOptional(e => e.Operacion)
                .HasForeignKey(e => e.OperationID);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.OperationRollbackCopayHospital)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.Operations_Error_Log)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.OperationsDuplicated)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.OperationId);

            modelBuilder.Entity<Operacion>()
                .HasMany(e => e.OperationsCoverage)
                .WithRequired(e => e.Operacion)
                .HasForeignKey(e => e.Operation_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.cve_cie_egreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.cve_cie_segdiag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.Dsc_Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.Incremento)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.seglogin_captura)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.ElegOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.TicketFarmacia)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Compl>()
                .Property(e => e.NUR)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_NotaCredito>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_NotaCredito>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Operations_Error_Log>()
                .Property(e => e.CorrectionUser)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsCoverage>()
                .Property(e => e.Cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsDuplicated>()
                .Property(e => e.UserAuthorize)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsDuplicated>()
                .Property(e => e.UserCancelation)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.Elegibility)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.Authorization)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.CIE10)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.CIE10_2)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.OriginProvider)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.CodeAffiliate)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.Coverage)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.Concept)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.CodeConcept)
                .IsUnicode(false);

            modelBuilder.Entity<OperationsMovementsLog>()
                .Property(e => e.CIE10_Egress)
                .IsUnicode(false);

            modelBuilder.Entity<Parametros>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<ParametrosXRFC>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<ParametrosXRFC>()
                .Property(e => e.notificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.cve_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.parentesco1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .HasMany(e => e.Derhabs)
                .WithRequired(e => e.Parentesco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.cve_provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.DescripcionEAN)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormato>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<PediatricSpeciality>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<PediatricSpeciality>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<PermisoDocumentoAfiliado>()
                .Property(e => e.Agrupacion)
                .IsUnicode(false);

            modelBuilder.Entity<planes>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProducto>()
                .Property(e => e.DescripcionMAc)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf>()
                .Property(e => e.NumeroRegistroCondusef)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf>()
                .Property(e => e.DescripcionPlan)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf>()
                .Property(e => e.PlanCob)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf>()
                .Property(e => e.IdTipoSeg)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf>()
                .Property(e => e.NUMAUTORTIPSEG)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf_Log>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<PlanProductoAdssyf_Log>()
                .Property(e => e.PlanCode)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.Poblacion1)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .HasMany(e => e.Recursos_Medicos)
                .WithRequired(e => e.Poblacion)
                .HasForeignKey(e => new { e.CodEstado, e.CodPoblacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.NumeroPolizaUnico)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.StsPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.DescripcionPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.CodAgente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.ApellidoPaternoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.ApellidoMaternoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.IdTipoSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.DescripcionPlan)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.NUMAUTORTIPSEG)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.NumeroRegistroCondusef)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.CODRAMO)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf>()
                .Property(e => e.MOTIVANUL)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.PolizaRenovacion)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.MailContratante)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.MailAgente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.MailPromotor)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.MailEjecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaCorreosEnvio>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<procedimientOdontologico>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<procedimientOdontologico>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoMembrete>()
                .Property(e => e.ClaveProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoMembrete>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoMembrete>()
                .Property(e => e.Membrete)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoMembrete>()
                .Property(e => e.ReporteCredencial)
                .IsUnicode(false);

            modelBuilder.Entity<ProvCargaEspecial>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<ProvCargaEspecial>()
                .Property(e => e.codPymeColectivo)
                .IsUnicode(false);

            modelBuilder.Entity<ProvidersExceedsDays>()
                .Property(e => e.CodeProvider)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProvidersExceedsDays>()
                .Property(e => e.UserRegisterProvider)
                .IsUnicode(false);

            modelBuilder.Entity<ProvidersExceedsDays>()
                .Property(e => e.UserCancelationProvider)
                .IsUnicode(false);

            modelBuilder.Entity<ProvidersWithoutCopay>()
                .Property(e => e.CodeProvider)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReasonRejectedFolio>()
                .HasMany(e => e.ValidatedFileDetails)
                .WithRequired(e => e.ReasonRejectedFolio)
                .HasForeignKey(e => e.ReasonRejectedFolio_Id);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.RecursoMedico)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.clabe)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.lada)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.nombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.nombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .HasMany(e => e.Facturas)
                .WithRequired(e => e.Recursos_Medicos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .HasMany(e => e.OP_PEMEX_Recepcion)
                .WithRequired(e => e.Recursos_Medicos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .HasMany(e => e.ProvidersExceedsDays)
                .WithRequired(e => e.Recursos_Medicos)
                .HasForeignKey(e => e.CodeProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .HasMany(e => e.ProvidersWithoutCopay)
                .WithRequired(e => e.Recursos_Medicos)
                .HasForeignKey(e => e.CodeProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .HasMany(e => e.SARSCoV2_Letters)
                .WithRequired(e => e.Recursos_Medicos)
                .HasForeignKey(e => e.CodeProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .HasMany(e => e.SIS_CTLF_Folios)
                .WithRequired(e => e.Recursos_Medicos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ReglasStatusProcesoConcepto>()
                .Property(e => e.codEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<ReglasStatusProcesoConcepto>()
                .Property(e => e.codConceptoOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<ReglasStatusProcesoConcepto>()
                .Property(e => e.codConceptoDestino)
                .IsUnicode(false);

            modelBuilder.Entity<ReglasStatusProcesoConcepto>()
                .HasMany(e => e.RolReglasStatusProcesoConcepto)
                .WithRequired(e => e.ReglasStatusProcesoConcepto)
                .HasForeignKey(e => e.idReglasStatusProcesoConcepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.Modulo)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.Aux1)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.Aux2)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.Aux3)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionDireccion>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<RelationFacturasWithoutUuid_Log>()
                .Property(e => e.CurrentUser)
                .IsUnicode(false);

            modelBuilder.Entity<RelationFacturasWithoutUuid_Log>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<RelationFacturasWithoutUuid_Log>()
                .Property(e => e.CancelationUser)
                .IsUnicode(false);

            modelBuilder.Entity<relReporteUsuario>()
                .Property(e => e.cve_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.FolioRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<RemittanceStatus>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<RemittanceStatus>()
                .HasMany(e => e.ValidatedFiles)
                .WithRequired(e => e.RemittanceStatus)
                .HasForeignKey(e => e.RemittanceStatus_Id);

            modelBuilder.Entity<RemittanceStatus>()
                .HasMany(e => e.ValidatedFilesLog)
                .WithRequired(e => e.RemittanceStatus)
                .HasForeignKey(e => e.RemittanceStatus_Id);

            modelBuilder.Entity<RolConceptosEmpresas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Roles>()
                .Property(e => e.Rol)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_Reportes_AreasCaptura>()
                .Property(e => e.DescripcionSubArea)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_Reportes_AreasCaptura>()
                .HasMany(e => e.Sami_Reportes_UsuariosCaptura)
                .WithRequired(e => e.Sami_Reportes_AreasCaptura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.N_Factura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.N_Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.RFC_Emisor)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.RFC_Receptor)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.XML_uuid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Uuid)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.F_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Importe)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Iva)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Isr)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Ivaret)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Imcd)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Total)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.A_Xml)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.A_pdf)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Xusrinsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Xusrupdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_FacturaXMLP>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<SARSCoV2_Letters>()
                .Property(e => e.CodeProvider)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SARSCoV2_Letters>()
                .Property(e => e.CodeConcept)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoProcesos>()
                .Property(e => e.UsuarioOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoProcesos>()
                .Property(e => e.UsuarioDestino)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoProcesos>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoProcesos>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoProcesos>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoStatus>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoStatus>()
                .Property(e => e.statusConceptos)
                .IsUnicode(false);

            modelBuilder.Entity<sepomex>()
                .Property(e => e.codigopostal)
                .IsUnicode(false);

            modelBuilder.Entity<sepomex>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<sepomex>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<sepomex>()
                .Property(e => e.municipio)
                .IsUnicode(false);

            modelBuilder.Entity<sepomex>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.d_codigo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.d_asenta)
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.d_CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.c_estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.c_oficina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.c_CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.c_tipo_asenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.c_mnpio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.id_asenta_cpcons)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SEPOMEX_CP>()
                .Property(e => e.c_cve_ciudad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_EstatusFolios>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_EstatusFolios>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_EstatusFolios>()
                .HasMany(e => e.SIS_CTLF_Folios)
                .WithRequired(e => e.SIS_CTLF_EstatusFolios)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.guia)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.lote)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.usr_asigno)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.usr_recibio)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.usr_entrego)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Folios>()
                .Property(e => e.usr_reg_salida)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Stock>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Stock>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Stock>()
                .Property(e => e.usr_cargo)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_CTLF_Stock>()
                .HasMany(e => e.SIS_CTLF_Folios)
                .WithRequired(e => e.SIS_CTLF_Stock)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sistema>()
                .Property(e => e.ClaveSistema)
                .IsUnicode(false);

            modelBuilder.Entity<Sistema>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SISTEMAS>()
                .Property(e => e.SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<SISTEMAS>()
                .HasMany(e => e.USUARIO_SISTEMAS)
                .WithRequired(e => e.SISTEMAS)
                .HasForeignKey(e => e.SISTEMA)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.Comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.Soporte)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.usu_alta)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .Property(e => e.usu_cambio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPago>()
                .HasMany(e => e.SolicitudesPagoDetalle)
                .WithRequired(e => e.SolicitudesPago)
                .HasForeignKey(e => e.IdSolicitudesPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SolicitudesPagoDetalle>()
                .Property(e => e.RGA)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPagoDetalle>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPagoDetalle>()
                .Property(e => e.usu_alta)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudesPagoDetalle>()
                .Property(e => e.usu_cambio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.XML)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.PDF)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.NombreEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.TotalFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.SubtotalFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.DescuentoFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.ImpuestosFactura)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.FolioFactura)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.FolioNotaCredito)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.ArchivoNotaCredito)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.ArchivoNotaCreditoPDF)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.usu_alta)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .Property(e => e.usu_cambio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacion>()
                .HasMany(e => e.SolicitudFacturacionDetalle)
                .WithRequired(e => e.SolicitudFacturacion)
                .HasForeignKey(e => e.IdSolicitudFacturacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SolicitudFacturacionDetalle>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacionDetalle>()
                .Property(e => e.RemesaSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacionDetalle>()
                .Property(e => e.CveEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacionDetalle>()
                .Property(e => e.usu_alta)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudFacturacionDetalle>()
                .Property(e => e.usu_cambio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.AfiliadoId)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.PolizaId)
                .IsFixedLength();

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.EMail)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.CLABE)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.MontoReclamado)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.MontoPagado)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.SubCodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.ManagedKey)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.ManagedIV)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolso>()
                .Property(e => e.FolioCallCenter)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolsoxMotivoRechazoId>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<SolicitudReembolsoxMotivoSolicitudReembolso>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<StatusProcesoConcepto>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<StatusProcesoConcepto>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<StatusProcesoConcepto>()
                .Property(e => e.nombrePresentacion)
                .IsUnicode(false);

            modelBuilder.Entity<StatusProcesoConcepto>()
                .HasMany(e => e.RolStatusProcesoConcepto)
                .WithRequired(e => e.StatusProcesoConcepto)
                .HasForeignKey(e => e.idStatusProcesoConcepto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SustitucionDeFactura>()
                .Property(e => e.segLogin)
                .IsUnicode(false);

            modelBuilder.Entity<SustitucionDeFactura>()
                .Property(e => e.datoRelacion)
                .IsUnicode(false);

            modelBuilder.Entity<SustitucionDeFactura>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<SustitucionDeFactura>()
                .Property(e => e.sustituyeA)
                .IsUnicode(false);

            modelBuilder.Entity<SustitucionDeFactura>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<SustitucionDeFactura>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<sustitucionFacturas>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<sustitucionFacturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<sustitucionFacturas>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<sustitucionFacturas>()
                .Property(e => e.no_facNueva)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .Property(e => e.Aplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Perfil_no)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_App)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Menu)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_App)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Usr)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_App)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Ctrl)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_App)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_App>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Perfil)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_App)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Ctrl>()
                .Property(e => e.Controls)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Ctrl>()
                .Property(e => e.ControlCtrl)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Menu>()
                .Property(e => e.Menu)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Menu>()
                .Property(e => e.ControlApp)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Menu>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Ctrl)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Menu>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_MenuSub)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_Menu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_MenuSub>()
                .Property(e => e.MenuSub)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_MenuSub>()
                .Property(e => e.ControlSub)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_MenuSub>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Ctrl)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_MenuSub)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Perfil_no>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Perfil_no>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Ctrl)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_Perfil_no)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Perfil_no>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Menu)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_Perfil_no)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Perfil_no>()
                .HasMany(e => e.Sys_Mediaccess_Acceso_Usr)
                .WithRequired(e => e.Sys_Mediaccess_Acceso_Perfil_no)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr>()
                .Property(e => e.Usuario_I)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr>()
                .Property(e => e.Usuario_U)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_EventosRegistrosTablas>()
                .HasMany(e => e.TabuladorProveedor_Log)
                .WithRequired(e => e.sys_mediaccess_EventosRegistrosTablas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TabuladorConsulta>()
                .Property(e => e.CodZona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorConsulta>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorCPT>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorCPT>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorCPT>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorEspecial>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorEspecial>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorEspecialidadPoblacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorEspecialidadPoblacion>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorEspecialidadPoblacion>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmacia>()
                .Property(e => e.CodigoEAN)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmacia>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmacia>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaE>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaE>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaE>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaExcelLog>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaExcelLog>()
                .Property(e => e.año)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaExcelLog>()
                .Property(e => e.mes)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaExcelLog>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaExcelLog>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaExcelLog>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaM>()
                .Property(e => e.farmaco)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM>()
                .Property(e => e.codTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorFarmaciaMpromedio>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorFarmaciaMpromedio>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorPoblacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorPoblacion>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.codDescripcion)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.xusrInsert)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedor>()
                .Property(e => e.anioAplicacion)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.codDescripcion)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.xusrInsert)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedorPruebaAlta>()
                .Property(e => e.anioAplicacion)
                .IsFixedLength();

            modelBuilder.Entity<Tb_Sanos_RecFile>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFile>()
                .HasMany(e => e.Tb_Sanos_RecFileDetail)
                .WithRequired(e => e.Tb_Sanos_RecFile)
                .HasForeignKey(e => e.ID_RecFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Derechohabiente)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Medico)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Nivel_de_Atencion)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Fecha_Consulta)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.d_v_idx)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Pase)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Sanos_RecFileDetail>()
                .Property(e => e.Tipo_Servicio_o_Diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_CatCargo>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_CatCargo>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_FacDet>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_FacDet>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_FacDet>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_FacDet>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_FacFile>()
                .HasMany(e => e.tb_TF_FacDet)
                .WithRequired(e => e.tb_TF_FacFile)
                .HasForeignKey(e => e.Id_Event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.observacion)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.numeroRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.metodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.comprobanteNumCheque)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.numeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.nomina)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.estado)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.lugarSevicio)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.cveCie)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.clavePrestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.prestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.tipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.precioPublico)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.descuento)
                .HasPrecision(16, 7);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.importe)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.iva)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.isr)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.retiva)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.impCedular)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.codEan)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.medicamento)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.tipoProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.cveEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.empresa)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.aseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.aseguradoraPorAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.icodAsegurado)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.codTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.codConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.remesaSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.cveEmpresaOperacion)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.cveProc)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.ImpCopago)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.PorCopago)
                .HasPrecision(16, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Precio_MAC_Unitario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Precio_MAC_Cantidad)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Importe_Desc_Unitario)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Importe_Desc_Cantidad)
                .HasPrecision(10, 2);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.numeroFacturaSAPI)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.ClaveEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.ReglaCopagoTipo)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.AfiliadoReal)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.StatusPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Periodo)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.ValidacionSat)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.FoliosElegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.CodAgente)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Cve_ProbOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.Esp_ProbOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.FolioSASS)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.EtiquetaPago)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.TicketFarmacia)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.NUR)
                .IsUnicode(false);

            modelBuilder.Entity<TemporalLayout>()
                .Property(e => e.ObservacionesEtiquetaPago)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoDocumento>()
                .HasMany(e => e.DocumentosCargados)
                .WithRequired(e => e.TipoDocumento)
                .HasForeignKey(e => e.TipoDocumento_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGasto>()
                .Property(e => e.TipoGasto1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoGasto>()
                .HasMany(e => e.Especialidad)
                .WithRequired(e => e.TipoGasto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGasto>()
                .HasMany(e => e.ExcludedProceduresByTipoGasto)
                .WithRequired(e => e.TipoGasto)
                .HasForeignKey(e => e.CodeExpenseType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGasto>()
                .HasMany(e => e.TipoGastoListaPrecios)
                .WithRequired(e => e.TipoGasto)
                .HasForeignKey(e => e.TipoGastoID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGastoListaPrecios>()
                .Property(e => e.Porcentaje)
                .HasPrecision(18, 4);

            modelBuilder.Entity<TipoGastoListaPrecios>()
                .Property(e => e.TipoCaracter)
                .IsUnicode(false);

            modelBuilder.Entity<TipoGastoListaPrecios>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TipoGastoListaPrecios>()
                .Property(e => e.Justificacion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRemesa>()
                .Property(e => e.TipoRemesa1)
                .IsUnicode(false);

            modelBuilder.Entity<TiposReembolso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TiposReembolso>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<TiposReembolso>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<TKM_Prospectos>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TKM_Prospectos>()
                .Property(e => e.a_paterno)
                .IsUnicode(false);

            modelBuilder.Entity<TKM_Prospectos>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<TKM_Prospectos>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Cargo>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Cargo>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.suc)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.abono)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.saldo)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.interbancaria)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_PagosLOG>()
                .Property(e => e.Xuser)
                .IsUnicode(false);

            modelBuilder.Entity<TypeMovement>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TypeMovement>()
                .HasMany(e => e.OperationsMovementsLog)
                .WithRequired(e => e.TypeMovement)
                .HasForeignKey(e => e.TypeMovement_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TypeMovement_AfiliadoAddsyf>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TypeMovementPlanProducto>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<TypeMovementPlanProducto>()
                .HasMany(e => e.PlanProductoAdssyf_Log)
                .WithRequired(e => e.TypeMovementPlanProducto)
                .HasForeignKey(e => e.TypeMovement_Id);

            modelBuilder.Entity<TypeService>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<TypeService>()
                .HasMany(e => e.FacturaTypeService)
                .WithRequired(e => e.TypeService)
                .HasForeignKey(e => e.TypeService_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Unauthorized_Medicines>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<Unauthorized_Medicines>()
                .Property(e => e.Commercial_Name)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.Afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.Managedkey)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.ManagedIV)
                .IsUnicode(false);

            modelBuilder.Entity<UserApp>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.Afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.NoExt)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.NoInt)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.NoCelular)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.NoFijo)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<UserAppDatos>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioDatosAdicionales>()
                .Property(e => e.Afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UsuarioRol>()
                .Property(e => e.UsuarioId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.nom_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.nivel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.spass)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.usuarioCreo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.usuarioModifico)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios_ws>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios_ws>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usuarios_ws>()
                .Property(e => e.sistema)
                .IsFixedLength();

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.Observation)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.Copago)
                .HasPrecision(16, 4);

            modelBuilder.Entity<ValidatedFileDetails>()
                .Property(e => e.CopagoEn)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.FolioVal)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.Usuario_Carga)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.CodeProvider)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.LeftOvers)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFiles>()
                .HasMany(e => e.ValidatedFileDetails)
                .WithOptional(e => e.ValidatedFiles)
                .HasForeignKey(e => e.ValidatedFile_Id);

            modelBuilder.Entity<ValidatedFiles>()
                .HasMany(e => e.ValidatedFilesLog)
                .WithRequired(e => e.ValidatedFiles)
                .HasForeignKey(e => e.ValidatedFiles_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ValidatedFilesLog>()
                .Property(e => e.CurrentUser)
                .IsUnicode(false);

            modelBuilder.Entity<WebModules>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<WebModules>()
                .HasMany(e => e.OperationsDuplicated)
                .WithRequired(e => e.WebModules)
                .HasForeignKey(e => e.Module_Id);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.sello)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.formaDePago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.certificado)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.condicionesDePago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.tipoDeComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.metodoDePago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.LugarExpedicion)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.rfcEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.nombreEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.calleFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noExteriorFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noInteriorFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.coloniaFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.localidadFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.municipioFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.estadoFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.paisFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.codigoPostalFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.calleExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noExteriorExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noInteriorExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.coloniaExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.localidadExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.municipioExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.estadoExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.paisExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.codigoPostalExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.regimenFiscalEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.rfcReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.nombreReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.calleReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noExteriorReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noInteriorReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.coloniaReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.localidadReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.municipioReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.estadoReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.paisReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.codigoPostalReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.impuesto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.selloCFD)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.noCertificadoSAT)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.selloSAT)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.lugardeexpedicion)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.UUIDRelacionado)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .Property(e => e.TipoRelacion)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML>()
                .HasMany(e => e.concepto_WSFacturaXML)
                .WithRequired(e => e.WSFacturaXML)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<WSFacturaXML_UUIDRelacionado>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML_UUIDRelacionado>()
                .Property(e => e.UUIDRelacionado)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXML_UUIDRelacionado>()
                .Property(e => e.TipoRelacion)
                .IsUnicode(false);

            modelBuilder.Entity<Zona>()
                .Property(e => e.CodZona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Zona>()
                .Property(e => e.Zona1)
                .IsUnicode(false);

            modelBuilder.Entity<Formato>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Formato>()
                .Property(e => e.Formato1)
                .IsUnicode(false);

            modelBuilder.Entity<Formato>()
                .HasMany(e => e.CopiaFormato)
                .WithRequired(e => e.Formato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<R_REPOSITORY_LOG>()
                .Property(e => e.REP_VERSION)
                .IsUnicode(false);

            modelBuilder.Entity<R_REPOSITORY_LOG>()
                .Property(e => e.LOG_USER)
                .IsUnicode(false);

            modelBuilder.Entity<R_REPOSITORY_LOG>()
                .Property(e => e.OPERATION_DESC)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillAccount>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillAccount>()
                .HasMany(e => e.tb_BillCatCargo)
                .WithRequired(e => e.tb_BillAccount)
                .HasForeignKey(e => e.tb_BillAccount_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BillCatCargo>()
                .Property(e => e.CompanyKey)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillCatCargo>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFile>()
                .Property(e => e.Interbank)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFile>()
                .Property(e => e.SameBank)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFile>()
                .HasMany(e => e.tb_BillFileRecipient)
                .WithRequired(e => e.tb_BillFile)
                .HasForeignKey(e => e.tb_BillFile_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BillFile>()
                .HasMany(e => e.tb_BillStateLog)
                .WithRequired(e => e.tb_BillFile)
                .HasForeignKey(e => e.tb_BillFile_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BillFile>()
                .HasMany(e => e.tb_PaymentsFileRecipient)
                .WithOptional(e => e.tb_BillFile)
                .HasForeignKey(e => e.tb_BillFile_id);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.Bill)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.Remittance)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.CompanyKey)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.BillKey)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.BillConcept)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.Uuid)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.ProviderAccount)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.ProviderCode)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .Property(e => e.Message)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .HasMany(e => e.tb_BillFileRecipientDetail)
                .WithRequired(e => e.tb_BillFileRecipient)
                .HasForeignKey(e => e.tb_BillFilerecipient_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BillFileRecipient>()
                .HasMany(e => e.tb_PaymentsFileRecipient)
                .WithOptional(e => e.tb_BillFileRecipient)
                .HasForeignKey(e => e.tb_BillFileRecipient_id);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Consecutive)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.FormatCode)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.FormatCopyCode)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.CompanyKey)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.AffiliateCode)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Ciekey)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.SpecialityKey)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.ProcedureKey)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Article)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.TabKey)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.CostCenter)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.authorization)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Subsidiary)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.OriginProvider)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.EmployeeType)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Eligibility)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Productkey)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.Num_Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.cve_cie_egreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillFileRecipientDetail>()
                .Property(e => e.cve_cie_segdiag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillState>()
                .HasMany(e => e.tb_BillFile)
                .WithRequired(e => e.tb_BillState)
                .HasForeignKey(e => e.tb_BillState_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BillState>()
                .HasMany(e => e.tb_BillStateLog)
                .WithRequired(e => e.tb_BillState)
                .HasForeignKey(e => e.tb_BillState_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_BillState>()
                .HasMany(e => e.tb_BillStateLog1)
                .WithRequired(e => e.tb_BillState1)
                .HasForeignKey(e => e.tb_BillState_NewId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_PaymentsFile>()
                .HasMany(e => e.tb_PaymentsFileRecipient)
                .WithRequired(e => e.tb_PaymentsFile)
                .HasForeignKey(e => e.tb_PaymentsFile_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.Bill)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.ProcessDate)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.ProcessTime)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.Branch)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.MovementType)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.Reference)
                .IsUnicode(false);

            modelBuilder.Entity<tb_PaymentsFileRecipient>()
                .Property(e => e.ProviderAccount)
                .IsUnicode(false);

            modelBuilder.Entity<activos>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<activos>()
                .Property(e => e.nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<activos>()
                .Property(e => e.nombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<activos>()
                .Property(e => e.parentesco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ActualizaTabuladorProveedor>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ActualizaTabuladorProveedor>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ActualizaTabuladorProveedor>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<ActualizaTabuladorProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ActualizaTabuladorProveedor>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<ActualizaTabuladorProveedor>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ActualizaFacturasLog>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ActualizaFacturasLog>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_ActualizaFacturasLog>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Medico)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Consecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Paciente)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.FolioFactura)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.FolioMediaccess)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.CodigoEAN)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.CodigoEAN2)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.PrecioBruto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.ImpteDescto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.ImpteIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.PrecioNeto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ADM_TBL_lineasLoteNalValidadas>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<afiliado_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados25_>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados26_>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.FechaNacimiento)
                .HasPrecision(3);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.FechaInicioServicio)
                .HasPrecision(3);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.FechaFinServicio)
                .HasPrecision(3);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.FechaCargaMediaccess)
                .HasPrecision(3);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.FechaAntiguedad)
                .HasPrecision(3);

            modelBuilder.Entity<AfilSicas>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.clav)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.clabe)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.cte)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.codestatusfactura)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.no_Fac)
                .IsUnicode(false);

            modelBuilder.Entity<altaCuentasRemesasLOG>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.Tabulador)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.CodDescripción)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_CLP_ListaProveedores>()
                .Property(e => e.ErrorMsg)
                .IsUnicode(false);

            modelBuilder.Entity<archivoRemesas>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<archivoRemesas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<archivoRemesas>()
                .Property(e => e.usr)
                .IsUnicode(false);

            modelBuilder.Entity<archivoRemesas>()
                .Property(e => e.ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<archivoRemesas>()
                .Property(e => e.caja)
                .IsUnicode(false);

            modelBuilder.Entity<archivoRemesas>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<asignacionCoberturaGrupoEmpresa>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<asignacionPlanEmpresaGrupo>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesGuate>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesGuate>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<ayuda>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayuda>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<ayudaproveedores>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudaproveedores>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ayudaproveedores>()
                .Property(e => e.nombrecompleto)
                .IsUnicode(false);

            modelBuilder.Entity<ayudaproveedores>()
                .Property(e => e.RecursoMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cve_provMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.descDental)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt1)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt2)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt3)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt4)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt5)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt6)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt7)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cpt8)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cie1)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cie2)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.cve_provRealiza)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.datosExploracion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.obsAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.indicacionesMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.indicacionesPaciente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.indicacionesHospital)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaDental>()
                .Property(e => e.observacionPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cve_provMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.descProgramacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cpt1)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cpt2)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cpt3)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cie1)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cie2)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cve_provHosp)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.horaProgramacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.responsable)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.contacto)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.horaIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.datosExploracion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.estudiosLaboratorio)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.estudiosGabinete)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.obsAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.honCirujano)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.honAnestesiologo)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.hon1erAyud)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.hon2doAyud)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.indicacionesMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.indicacionesPaciente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.indicacionesHospital)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.observacionPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.folioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaProgramacion>()
                .Property(e => e.cve_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cve_provMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.descProgramacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cpt1)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cpt2)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cpt3)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cie1)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cie2)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cve_provHosp)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.horaProgramacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.responsable)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.contacto)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.horaIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.datosExploracion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.estudiosLaboratorio)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.estudiosGabinete)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.obsAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.honCirujano)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.honAnestesiologo)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.hon1erAyud)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.hon2doAyud)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.indicacionesMedico)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.indicacionesPaciente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.indicacionesHospital)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.observacionPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.folioReceta)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.cve_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<bandejaprogramacionLog>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<cambioStatusMAC>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<cambioStatusMAC>()
                .Property(e => e.statusReal)
                .IsUnicode(false);

            modelBuilder.Entity<Capitas_>()
                .Property(e => e.nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Cat_Codigo_Tabulador>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<Cat_Codigo_Tabulador>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Medicamentos_SASE>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.cve_ent)
                .IsUnicode(false);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.cve_mun)
                .IsUnicode(false);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.cve_loc)
                .IsUnicode(false);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.nom_loc)
                .IsUnicode(false);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.lat_decimal)
                .HasPrecision(18, 10);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.lon_decimal)
                .HasPrecision(18, 10);

            modelBuilder.Entity<CatLocalidades>()
                .Property(e => e.altitud)
                .IsUnicode(false);

            modelBuilder.Entity<catLugaresIngreso>()
                .Property(e => e.lugIngrCode)
                .IsUnicode(false);

            modelBuilder.Entity<catLugaresIngreso>()
                .Property(e => e.lugIngrDesc)
                .IsUnicode(false);

            modelBuilder.Entity<centrosCostoSantander>()
                .Property(e => e.nomina)
                .IsUnicode(false);

            modelBuilder.Entity<centrosCostoSantander>()
                .Property(e => e.centrocosto)
                .IsUnicode(false);

            modelBuilder.Entity<Cobertura_TipoGasto>()
                .Property(e => e.Cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasTipoGasto>()
                .Property(e => e.coaseguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasTipoGasto>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<concentradoPagado30112009_>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<concentradox>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<concentradox>()
                .Property(e => e.codestatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConfigTraceProcedimientos>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<controlFoliosCapturados>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<controlFoliosCapturados>()
                .Property(e => e.usrCapturo)
                .IsUnicode(false);

            modelBuilder.Entity<controlFoliosCapturados>()
                .Property(e => e.cve_prov)
                .IsFixedLength();

            modelBuilder.Entity<controlFoliosCapturados>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<controlFoliosCapturados>()
                .Property(e => e.codTabulador)
                .IsFixedLength();

            modelBuilder.Entity<controlFoliosCapturados>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CPT_CVEPROV_TIPOGASTO4>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CPT_CVEPROV_TIPOGASTO4>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<CPT_CVEPROV_TIPOGASTO4>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<cptCirugia>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<cptCirugia>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<cptCirugia>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<cptCirugia>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cptCirugia>()
                .Property(e => e.Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<cptCirugia>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<cptgeneral_log>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuadroBasicoM>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<CuadroBasicoM_>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodTipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.RestoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.ApellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.ApellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.flgIguala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.SGPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.cedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta>()
                .Property(e => e.certificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CodTipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.RestoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.ApellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.ApellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.flgIguala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.SGPassword)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.cedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaMediaccess>()
                .Property(e => e.certificacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.NOMBRECOMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.RAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.TELFEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.E_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.INCREMENTOANUAL)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.VIGENCIADEINICIO)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.TERMINO)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DatoscuentaNafin>()
                .Property(e => e.CIUDAD)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.NOMBRECOMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.RAZONSOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.TELFEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.E_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.INCREMENTOANUAL)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.VIGENCIADEINICIO)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.TERMINO)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.CIUDAD)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.CODIGODESERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<DATOSFINALESNAFIN>()
                .Property(e => e.NOMBRE_DESCRIPCIONSERVICIO)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<derhabssicas>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.Nombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.Edad)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.cve_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.Tipo_emp)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.cve_derhab)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.codPropiedad)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<derhabsspcnova>()
                .Property(e => e.codAseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<DescuentoProveedor>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.codestatus)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<dhx>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidadessinpase>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidadessinpase>()
                .Property(e => e.nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ElegSinPE>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ElegSinPE>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.aPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.aMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.codSexo)
                .IsFixedLength();

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.codEstado)
                .IsFixedLength();

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.curp)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.nss)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.puesto)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.emailMacc)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.lada)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.num1)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.cel1)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.idBanco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.cuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.cuentaClabe)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.idEmpleadoJefe)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.usrRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.usrModifico)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.usrBaja)
                .IsUnicode(false);

            modelBuilder.Entity<empleadosRHLOG>()
                .Property(e => e.usrModificoLOG)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.NombreEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.NombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.CodEstatusEmpresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<empresa14_>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasFacturaAfiliado>()
                .Property(e => e.cveEmpresa_Afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasFacturaAfiliado>()
                .Property(e => e.cveEmpresa_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasFacturaAfiliado>()
                .Property(e => e.UsrAlta)
                .IsUnicode(false);

            modelBuilder.Entity<empresassicas>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<empresassicas>()
                .Property(e => e.empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.EstatusAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Parentesco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Nombre_por_apellidos)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.dbo_Derhabs_CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_prov__5_)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.dbo_Recursos_Medicos_CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.RecursoMedico)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.nombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.nombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.REG_FISCAL)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Diagnostico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Descripción_de_CPT)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Medicamentos)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.TIpo_de_procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Proveedor_Origen__NComercial_)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Proveedor_Origen__NFiscal_)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Origen_de_la_Devolución)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.Motivo_de_Devolución)
                .IsUnicode(false);

            modelBuilder.Entity<Envío_a_pago>()
                .Property(e => e.ElegOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadSASS>()
                .Property(e => e.TipoCosto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacRes>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacRes>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_cambio>()
                .Property(e => e.LugarIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<facturas_prueba>()
                .Property(e => e.LugarIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasEmail>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasEmail>()
                .Property(e => e.Atencion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.qusr)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOGcambioestatus>()
                .Property(e => e.qusr)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasNAFIN>()
                .Property(e => e.LugarIngreso)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.uuid_ant)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<facturasNotaCredito>()
                .Property(e => e.lugardeexpedicion)
                .IsUnicode(false);

            modelBuilder.Entity<farmacias_>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<farmacias_>()
                .Property(e => e.recursomedico)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TB_FacturasLayout>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TB_FacturasLayout>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TB_FacturasLayout>()
                .Property(e => e.secuenciaMac)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TB_FacturasLayout>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TB_FacturasLayout>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<FIN_TB_FacturasLayout>()
                .Property(e => e.NoLote)
                .IsUnicode(false);

            modelBuilder.Entity<folios>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<foliosBloqueadosBoletinados>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<foliosBloqueadosBoletinados>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<generacionOrdenPago>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<generacionOrdenPago>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<generacionOrdenPago>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<generacionOrdenPago>()
                .Property(e => e.usr)
                .IsUnicode(false);

            modelBuilder.Entity<generacionOrdenPago>()
                .Property(e => e.ordenPago)
                .IsUnicode(false);

            modelBuilder.Entity<grupos>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<grupos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext>()
                .Property(e => e.CVE_PROV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext>()
                .Property(e => e.NOMINA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext_respaldo>()
                .Property(e => e.CVE_PROV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext_respaldo>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext_respaldo>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext_respaldo>()
                .Property(e => e.NOMINA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext_respaldo>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HistoricoContador_Especiales_Bancomext_respaldo>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.H_ST_Serv)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.H_fec_Serv)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.H_Empl_Serv)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.metodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.ComprobanteNumCheque)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.Datestado)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.parentesco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.fechaPago)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.LugarSevicio)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.diagnostico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.ClavePrestadorCobra)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.PrestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.tipogasto)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.tasa)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.CodEan)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.Medicamento)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.TipoProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.codtabulador)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.Descripcion_Monto)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Entrega>()
                .Property(e => e.Identy)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.RecursoMedico)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_fac>()
                .Property(e => e.EstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.H_ST_Serv)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Parentesco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Diagnostico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.Descripcion_Monto)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Layout_SHF_Ope>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LISTAPRECIOSESPECIALES>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<LISTAPRECIOSESPECIALES>()
                .Property(e => e.tipogasto)
                .IsUnicode(false);

            modelBuilder.Entity<LISTAPRECIOSESPECIALES>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<LISTAPRECIOSESPECIALES>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<LISTAPRECIOSESPECIALES>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<LISTAPRECIOSESPECIALES>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<listaspreciosFarmacias>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<listaspreciosFarmacias>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<listaspreciosFarmacias>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Log_Parametros>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<Log_Parametros>()
                .Property(e => e.segLogin)
                .IsFixedLength();

            modelBuilder.Entity<Log_ParametrosXRFC>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Log_ParametrosXRFC>()
                .Property(e => e.notificacion)
                .IsUnicode(false);

            modelBuilder.Entity<Log_ParametrosXRFC>()
                .Property(e => e.segLogin)
                .IsFixedLength();

            modelBuilder.Entity<Log_ParametrosXRFC>()
                .Property(e => e.tipoMovimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Login_paso>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Login_paso>()
                .Property(e => e.SegPass)
                .IsUnicode(false);

            modelBuilder.Entity<Login_paso>()
                .Property(e => e.spass)
                .IsUnicode(false);

            modelBuilder.Entity<Login_paso>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Login_paso>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LogProcedimientos>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<LogProcedimientos>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<LogProcedimientos>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<LogProcedimientos>()
                .Property(e => e.Total)
                .HasPrecision(10, 2);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentsAuthorized>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.secuenciaMac)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.Proveedor_origen)
                .IsUnicode(false);

            modelBuilder.Entity<MemoOperacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<nomina_>()
                .Property(e => e.nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas>()
                .Property(e => e.Cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Catalogo>()
                .Property(e => e.CodEmp)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Catalogo>()
                .Property(e => e.Cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Catalogo>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Devueltas>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Devueltas>()
                .Property(e => e.Cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Devueltas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Devueltas>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.CodEmp)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.Cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.UsrProceso)
                .IsUnicode(false);

            modelBuilder.Entity<OP_Factura_Remesas_Foliador_LOG>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_PEMEX_RemesasLog>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_PEMEX_RemesasLog>()
                .Property(e => e.MsgError)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_LogValidaciones>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_LogValidaciones>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_LogValidaciones>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.cve_provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.DescripcionEAN)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.ValidacionRechazo)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_PasoFarmaciasNuevoFormatoLog>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.cve_provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.DescripcionEAN)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.ERROR)
                .IsUnicode(false);

            modelBuilder.Entity<OP_PE_VF_TemporalPFNF>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_CPT>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TBL_CPT>()
                .Property(e => e.TipoTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.metodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.ComprobanteNumCheque)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.LugarSevicio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.PrestadorOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.ClavePrestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.PrestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.CodEan)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.cantidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.TipoProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.secuenciamac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.empresa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Aseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.AseguradoraPorAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.icodAsegurado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Codproducto)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_Remesas_Paso>()
                .Property(e => e.Usuario)
                .IsFixedLength();

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.metodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.ComprobanteNumCheque)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.LugarSevicio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.PrestadorOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.ClavePrestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.PrestadorCobra)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.CodEan)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.cantidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.TipoProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.secuenciamac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.empresa)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.Aseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.AseguradoraPorAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.icodAsegurado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_TP_RemesasNova_Paso>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.Nombre_Medico)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.nombre_afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_BANRURAL_Carga>()
                .Property(e => e.Valmsg)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.Nombre_Medico)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.nombre_afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_Bansefi_Carga>()
                .Property(e => e.Valmsg)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.secuenciaMac)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.Nombre_Medico)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.nombre_afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<OP_VF_pemex_Carga>()
                .Property(e => e.Valmsg)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.Num_Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_cie_egreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacion_Autorizaciones>()
                .Property(e => e.cve_cie_segdiag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.UsuarioCambio)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<Operacion_Log>()
                .Property(e => e.StatusFac)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_notacredito_log>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_notacredito_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_notacredito_log>()
                .Property(e => e.usuarioP)
                .IsUnicode(false);

            modelBuilder.Entity<operacion_notacredito_log>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.Num_Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_cie_egreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<operacionElegibilidad>()
                .Property(e => e.cve_cie_segdiag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.Num_Certificado)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_cie_egreso)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.cve_cie_segdiag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<OperacionI>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaSegundo>()
                .Property(e => e.Codempresa)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaSegundo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaSegundo>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaSegundo>()
                .Property(e => e.PaseEspecialista)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaSegundo>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.codproducto)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.secuenciamac)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.consecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatocamposnuevos>()
                .Property(e => e.usr)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.cve_provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.DescripcionEAN)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasNuevoFormatoI>()
                .Property(e => e.Id)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.cve_provOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.DescripcionEAN)
                .IsUnicode(false);

            modelBuilder.Entity<PasoFarmaciasTest>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.codTipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<pasoTabuladorProveedor>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.NumeroPolizaUnico)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.StsPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.DescripcionPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.CodAgente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.NombreCliente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.ApellidoPaternoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.ApellidoMaternoCliente)
                .IsUnicode(false);

            modelBuilder.Entity<PolizaAdssyf_130522>()
                .Property(e => e.IdTipoSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<preReemboslsosFacturas>()
                .Property(e => e.uuid)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Producto1)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.consecutivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.CodFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.CodCopiaFormato)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.articulo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.obs)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores_TB_ArchivoTXT>()
                .Property(e => e.Validatxt)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresBloqueados2014>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresBloqueados2014>()
                .Property(e => e.codEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedoresfarmacialistaprecios>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMismoRFCDiffClaveProveedor>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMismoRFCDiffClaveProveedor>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<R_CuadroBasicoM>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.RecursoMedico)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.clabe)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.lada)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.nombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_MedicosLOG>()
                .Property(e => e.nombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBANRURAL>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBANRURAL>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBANRURAL>()
                .Property(e => e.secuenciaMac)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBANRURAL>()
                .Property(e => e.ProvOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBANRURAL>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBANRURAL>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBansefi>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBansefi>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBansefi>()
                .Property(e => e.secuenciaMac)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBansefi>()
                .Property(e => e.ProvOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBansefi>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosBansefi>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosPemex>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosPemex>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosPemex>()
                .Property(e => e.ProvOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosPemex>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<RecursosPemex>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.Red1)
                .IsUnicode(false);

            modelBuilder.Entity<red_cuenta>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<red_cuenta>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<red_cuenta>()
                .Property(e => e.Prioridad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.cve_provMedico)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.descDental)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.cve_provRealiza)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.datosExploracion)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.obsAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.indicacionesMedico)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.indicacionesPaciente)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.indicacionesHospital)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.observacionPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<RESPALDOBANDEJASTATUSPENDIENTE>()
                .Property(e => e.cve_cie)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_Reportes_Listado>()
                .Property(e => e.NombreReporte)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_Reportes_Listado>()
                .Property(e => e.DescripcionReporte)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_Reportes_UsuariosCaptura>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sami_Reportes_UsuariosCapturaBCK11022021>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.C_Proveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.N_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.Uuid)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.Serie)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.N_Xml)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.R_Pdf)
                .IsUnicode(false);

            modelBuilder.Entity<Sami_TB_Factura>()
                .Property(e => e.U_Insert)
                .IsUnicode(false);

            modelBuilder.Entity<Samiweb_Devoluciones_Email>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Samiweb_Devoluciones_Email>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<Samiweb_Devoluciones_Email>()
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Samiweb_Devoluciones_Email>()
                .Property(e => e.Cc)
                .IsUnicode(false);

            modelBuilder.Entity<Samiweb_Devoluciones_Email>()
                .Property(e => e.Cco)
                .IsUnicode(false);

            modelBuilder.Entity<seguimientoCiruriaProgramada>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<seguimientoCiruriaProgramada>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<seguimientoCiruriaProgramada>()
                .Property(e => e.personaContactada)
                .IsUnicode(false);

            modelBuilder.Entity<seguimientoIncidencias>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<seguimientoIncidencias>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<seguimientoIncidencias>()
                .Property(e => e.personaContactada)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Movimientos)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.No)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Mandato)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.NEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Apaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Amaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Codestado)
                .IsUnicode(false);

            modelBuilder.Entity<SIS_SAE_Padron>()
                .Property(e => e.Codpoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista>()
                .Property(e => e.PaseEspecialista)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista>()
                .Property(e => e.Clinica)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista_completo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista_completo>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista_completo>()
                .Property(e => e.PaseEspecialista)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista_completo>()
                .Property(e => e.Clinica)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_PaseEspecialista_completo>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Perfil>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Perfil_>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_SubPerfil>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_SubPerfil>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr_Bajas>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr_Bajas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr_Bajas>()
                .Property(e => e.Usuario_I)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr_Bajas>()
                .Property(e => e.Usuario_U)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usr_Bajas>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usuarios>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usuarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usuarios>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usuarios>()
                .Property(e => e.Usuario_I)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Acceso_Usuarios>()
                .Property(e => e.Usuario_U)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cambio_Monto_Captura>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cambio_Monto_Captura>()
                .Property(e => e.UsrAlta)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cambio_Monto_Captura>()
                .Property(e => e.UsrActualizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_EmpresasFacturaAfiliado>()
                .Property(e => e.cveEmpresa_Afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_EmpresasFacturaAfiliado>()
                .Property(e => e.cveEmpresa_Factura)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_EmpresasFacturaAfiliado>()
                .Property(e => e.UsrAlta)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_ExcentoCopago>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_ExcentoCopago>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_ExcentoCopago>()
                .Property(e => e.UsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_LogSami>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_LogSami>()
                .Property(e => e.Action)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_PermisosEspeciales_Aplicativos>()
                .Property(e => e.Permiso)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_PermisosEspeciales_Aplicativos>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_PermisosEspeciales_Usuarios>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_PermisosEspeciales_Usuarios>()
                .Property(e => e.User_Alta)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_PermisosEspeciales_Usuarios>()
                .Property(e => e.User_Cambio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_PermisosEspeciales_Usuarios>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_ProcesosLog>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_ProcesosLog>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_ProcesosLog>()
                .Property(e => e.MsgError)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.NombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.Especialidad_orig)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.tipogasto)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.clasificacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.TipoProv)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPClasi>()
                .Property(e => e.TipoProv_DSC)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPCliente>()
                .Property(e => e.TipoProveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_OP_TPCliente>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Movimientos)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.No)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Mandato)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.NEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Apaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Amaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Codestado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron>()
                .Property(e => e.Codpoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Movimientos)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.No)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Mandato)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.NEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Apaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Amaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Codestado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_Padron_>()
                .Property(e => e.Codpoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Movimientos)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Mandato)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.NEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Apaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Amaterno)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Codestado)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.Codpoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronJ_>()
                .Property(e => e.pyme)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronLog>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronLog>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronLog>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronLog_>()
                .Property(e => e.archivo)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronLog_>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SAE_PadronLog_>()
                .Property(e => e.usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmacia_Tmp>()
                .Property(e => e.CodigoEAN)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmacia_Tmp>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmacia_Tmp>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaEmail>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaEmail>()
                .Property(e => e.Atencion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaEmail>()
                .Property(e => e.tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTP>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTP>()
                .Property(e => e.mes)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTP>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTP>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTPLog>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTPLog>()
                .Property(e => e.año)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTPLog>()
                .Property(e => e.mes)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTPLog>()
                .Property(e => e.dia)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTPLog>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaFTPLog>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_CargaRechazosLog>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_CargaRechazosLog>()
                .Property(e => e.usrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_CargaRechazosLog>()
                .Property(e => e.fechaBusqueda)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_CargaRechazosLog>()
                .Property(e => e.finsertBusqueda)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_CargaRechazosLog>()
                .Property(e => e.tipotabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_ReplicaLog>()
                .Property(e => e.fechaReplica)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_ReplicaLog>()
                .Property(e => e.fechaReplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_ReplicaLog>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_ReplicaLog>()
                .Property(e => e.usrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_E_ReplicaLog>()
                .Property(e => e.tipotabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_log>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_log>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_log>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaM_log>()
                .Property(e => e.farmaco)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_log>()
                .Property(e => e.codTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_log>()
                .Property(e => e.xUsrInsertEvento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.diaVigencia)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.mesVigencia)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.anioVigencia)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.farmaco)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.Rechazo)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaM_R>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMM>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMM>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMM>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaMPromedio_>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMpromedio_log>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMpromedio_log>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tabuladorFarmaciaMpromedio_log_modificaciones>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorFarmaciaMpromedio_log_modificaciones>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioLOG>()
                .Property(e => e.PASO)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioLOG>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioLOG>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioReciente>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioReciente>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioRecienteNEW>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioRecienteNEW>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioRecienteNEW>()
                .Property(e => e.precioMAC)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.IdCodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.CveProv)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.CveEspec)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.CodZona)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral>()
                .Property(e => e.codPyme)
                .HasPrecision(10, 0);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.IdCodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.CveProv)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.CveEspec)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.CodZona)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorGeneral_LOG>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.codDescripcion)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.xusrInsert)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.anioAplicacion)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedor_Log>()
                .Property(e => e.xUsrInsertEvento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.codDescripcion)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.xusrInsert)
                .IsFixedLength();

            modelBuilder.Entity<TabuladorProveedorM>()
                .Property(e => e.anioAplicacion)
                .IsFixedLength();

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.CodDescripción)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso2012>()
                .Property(e => e.Usuarioqueactualizo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.f_factura)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.nombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Nivel_de_Atencion)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Fecha)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.TipoServicio_Diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.CPT_Pase)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.importe)
                .HasPrecision(13, 2);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.ImporteDescuento)
                .HasPrecision(27, 4);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.MesPago)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Tipo_DerechoHabiente)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Parentesco)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Clave_Articulo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Tipo_medicamento)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Laboratorio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.DescuentoFH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Importe_DESCTO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Descripcion_Monto)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Expediente_FH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Derechohabiente_FH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Tipo_DerechoHabiente_FH)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Expediente_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Estatus_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Especialidad_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Nivel_de_Atencion_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Fecha_Consulta_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.d_v_idx_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Pase_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Tipo_de_Servicio_o_Diagnostico_Gpo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_OP_Bansefi_Remesa>()
                .Property(e => e.Diagnostico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sami_Control>()
                .Property(e => e.XusrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sami_UsrAdmin>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sami_UsrAdmin>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sami_UsrAdmin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sami_UsrAdmin>()
                .Property(e => e.xusrinsert)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Sami_UsrAdmin>()
                .Property(e => e.xusractual)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_CatTransf>()
                .Property(e => e.cve_banco)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Fac>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Fac>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Fac>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Fac>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Fac>()
                .Property(e => e.Xuser)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.suc)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.abono)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.saldo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_Pag>()
                .Property(e => e.Xuser)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.FechadeFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.FechadeRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.FechadeEnvioaPago)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.No_fac)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Recursomedico)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.EstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Secuencia)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.F_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.F_Regresada)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Fechadepago)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.MsgValida)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin>()
                .Property(e => e.Xuser)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Remesa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.FechadeFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.FechadeRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.FechadeEnvioaPago)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.No_fac)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Recursomedico)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.EstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Secuencia)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.F_Pago)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.F_Regresada)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Fechadepago)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.MsgValida)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagFin_log>()
                .Property(e => e.Xuser)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.hora)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.suc)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.cargo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.abono)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.saldo)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.concepto)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.msgvalida)
                .IsUnicode(false);

            modelBuilder.Entity<tb_TF_PagLOG>()
                .Property(e => e.Xuser)
                .IsUnicode(false);

            modelBuilder.Entity<tbHospicheckDetail>()
                .Property(e => e.CIE_ING)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbHospicheckDetail>()
                .Property(e => e.CVE_CIE)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tbHospicheckDetail>()
                .Property(e => e.IMPORTE_DESCUENTO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tbHospicheckDetail>()
                .Property(e => e.IMPCOPAGO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tbHospicheckDetail>()
                .Property(e => e.DEDUCIBLE_COPAGO)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tbHospicheckDetail>()
                .Property(e => e.ERRORES)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_OP_TP_Remesas>()
                .Property(e => e.fechaPago)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_OP_TP_Remesas>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_OP_TP_Remesas>()
                .Property(e => e.estatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<TBL_OP_TP_Remesas>()
                .Property(e => e.importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TBL_OP_TP_Remesas>()
                .Property(e => e.total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TBL_OP_TP_Remesas>()
                .Property(e => e.totalFactura)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.TipoCuenta1)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_CPT>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_CPT>()
                .Property(e => e.DescripcionCorta)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_CPT>()
                .Property(e => e.DescripcionLarga)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_CPT>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TMP_CPT>()
                .Property(e => e.Lugar)
                .IsUnicode(false);

            modelBuilder.Entity<TMP_CPT>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Cargo23122021>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Cargo23122021>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_CargoLOG>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_CargoLOG>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_CargoLOG>()
                .Property(e => e.operacion)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_CargoLOG>()
                .Property(e => e.usuarioCambio)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Facturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Facturas>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Facturas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_Facturas>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_LogFacturas>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_LogFacturas>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_LogFacturas>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Transferencias_TB_LogFacturas>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado14_>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado25_>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado26_>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionesArchivo>()
                .Property(e => e.ubicacionArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionesArchivo>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionesArchivo>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionesArchivo>()
                .Property(e => e.responsable)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO_SISTEMAS>()
                .Property(e => e.USUARIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.nom_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.nivel)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.contrasena)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.spass)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.usuarioCreo)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.usuarioModifico)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios_Bajas>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.FolioVal)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.Usuario_Carga)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.CodeProvider)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.LeftOvers)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.CodTabulador)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ValidatedFilesMovimientosLog>()
                .Property(e => e.Movimiento)
                .IsUnicode(false);

            modelBuilder.Entity<WebService_ProveedorDiasHabiles>()
                .Property(e => e.datosEntrada)
                .IsUnicode(false);

            modelBuilder.Entity<WebService_ProveedorDiasHabiles>()
                .Property(e => e.datosSalida)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.Proveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.sello)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.formaDePago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.certificado)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.condicionesDePago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.tipoDeComprobante)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.metodoDePago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.LugarExpedicion)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.NumCtaPago)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.rfcEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.nombreEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.calleFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noExteriorFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noInteriorFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.coloniaFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.localidadFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.municipioFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.estadoFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.paisFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.codigoPostalFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.calleExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noExteriorExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noInteriorExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.coloniaExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.localidadExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.municipioExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.estadoExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.paisExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.codigoPostalExpedido)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.regimenFiscalEmisor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.rfcReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.nombreReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.calleReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noExteriorReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noInteriorReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.coloniaReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.localidadReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.municipioReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.estadoReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.paisReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.codigoPostalReceptor)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.impuesto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.UUID)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.selloCFD)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.noCertificadoSAT)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.selloSAT)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<WSFacturaXMLJunior>()
                .Property(e => e.serie)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Cedula)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Medico)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Expediente)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Consecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Paciente)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.FolioFactura)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.FolioMediaccess)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Cliente)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.CodigoEAN)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.CodigoEAN2)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.PrecioBruto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.ImpteDescto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.ImpteIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.PrecioNeto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ZADM_TBL_lineasLoteNalValidadasrespaldo>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliados14_1>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.Autoriza)
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.Nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CargaMasivaFarmacia>()
                .Property(e => e.cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<gastoTOtalLentes_>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<gastoTOtalLentes_>()
                .Property(e => e.NOMINA)
                .IsUnicode(false);

            modelBuilder.Entity<gastoTOtalLentes_>()
                .Property(e => e.TITULAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gastoTOtalLentes_>()
                .Property(e => e.BENEFICIARIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gastoTOtalLentes_>()
                .Property(e => e.PARENTESCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gastoTotalReembolsos>()
                .Property(e => e.NOMINA)
                .IsUnicode(false);

            modelBuilder.Entity<gastoTotalReembolsos>()
                .Property(e => e.TITULAR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gastoTotalReembolsos>()
                .Property(e => e.BENEFICIARIO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<gastoTotalReembolsos>()
                .Property(e => e.PARENTESCO)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.Nombre)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.Edad)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.cve_parent)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.Tipo_emp)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.cve_derhab)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.codPropiedad)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Maric>()
                .Property(e => e.codAseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso>()
                .Property(e => e.CodigoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<tabuladorProveedorPaso>()
                .Property(e => e.Autorizacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.codempresa)
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.xusrinsert)
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.fechaRegistro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<autorizacionesMI_>()
                .Property(e => e.autorizacionMI)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.TextoCoberturaSelect)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.copagoen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.limiteSuperior)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.limiteInferior)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.numeroEventos)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasProductos>()
                .Property(e => e.cubiertoen)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.TextoCoberturaSelect)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.copagoen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.limiteSuperior)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.limiteInferior)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.numeroEventos)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosIIBSL200NONO0715>()
                .Property(e => e.cubiertoen)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.TextoCoberturaSelect)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.copagoen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.limiteSuperior)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.limiteInferior)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.numeroEventos)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasproductosTMP>()
                .Property(e => e.cubiertoen)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillCatTransf>()
                .Property(e => e.Giro)
                .IsUnicode(false);

            modelBuilder.Entity<tb_BillCatTransf>()
                .Property(e => e.TransferKey)
                .IsUnicode(false);
        }
    }
}
