using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.Bases_De_Datos.ISS
{
    public partial class DBContext : DbContext
    {
        public DBContext()
            : base("name=DBContext2")
        {
        }

        public virtual DbSet<Acreedor> Acreedor { get; set; }
        public virtual DbSet<Admin_EdoCuenta> Admin_EdoCuenta { get; set; }
        public virtual DbSet<AdminAgenda> AdminAgenda { get; set; }
        public virtual DbSet<AdminAplicativo> AdminAplicativo { get; set; }
        public virtual DbSet<AdminUsers> AdminUsers { get; set; }
        public virtual DbSet<AE_Acceso_Perfil> AE_Acceso_Perfil { get; set; }
        public virtual DbSet<AE_Acceso_Usuarios> AE_Acceso_Usuarios { get; set; }
        public virtual DbSet<Afiliado> Afiliado { get; set; }
        public virtual DbSet<Afiliados> Afiliados { get; set; }
        public virtual DbSet<AfiliadoSeguro> AfiliadoSeguro { get; set; }
        public virtual DbSet<Aplicaciones> Aplicaciones { get; set; }
        public virtual DbSet<AreaTrabajo> AreaTrabajo { get; set; }
        public virtual DbSet<Aseguradoras> Aseguradoras { get; set; }
        public virtual DbSet<Asegurados> Asegurados { get; set; }
        public virtual DbSet<Autorizaciones> Autorizaciones { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<BandejaEntrada> BandejaEntrada { get; set; }
        public virtual DbSet<Campania> Campania { get; set; }
        public virtual DbSet<CargaArchivos> CargaArchivos { get; set; }
        public virtual DbSet<Catalogo_Moneda> Catalogo_Moneda { get; set; }
        public virtual DbSet<CatalogoEstudio> CatalogoEstudio { get; set; }
        public virtual DbSet<CatAutorizacion> CatAutorizacion { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<CatRegimenFiscal> CatRegimenFiscal { get; set; }
        public virtual DbSet<Clasificacion> Clasificacion { get; set; }
        public virtual DbSet<ClasificacionxProducto> ClasificacionxProducto { get; set; }
        public virtual DbSet<Coberturas_Ficha_Tecnica> Coberturas_Ficha_Tecnica { get; set; }
        public virtual DbSet<CodPymesWELLNES> CodPymesWELLNES { get; set; }
        public virtual DbSet<CodSeguro> CodSeguro { get; set; }
        public virtual DbSet<Colonia> Colonia { get; set; }
        public virtual DbSet<Comision> Comision { get; set; }
        public virtual DbSet<ContactoAfiliado> ContactoAfiliado { get; set; }
        public virtual DbSet<ContactoEmpresa> ContactoEmpresa { get; set; }
        public virtual DbSet<ContactoProveedor> ContactoProveedor { get; set; }
        public virtual DbSet<ContactoVendedor> ContactoVendedor { get; set; }
        public virtual DbSet<CoverageFilter> CoverageFilter { get; set; }
        public virtual DbSet<CuadroBasico> CuadroBasico { get; set; }
        public virtual DbSet<Devolucion> Devolucion { get; set; }
        public virtual DbSet<Divisa> Divisa { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<DocumentoProveedor> DocumentoProveedor { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<EMI_Tarjetas_Catalogo> EMI_Tarjetas_Catalogo { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<EmpresaPeriodo> EmpresaPeriodo { get; set; }
        public virtual DbSet<EmpresaProducto> EmpresaProducto { get; set; }
        public virtual DbSet<EmpresaRedes> EmpresaRedes { get; set; }
        public virtual DbSet<EmpresaRegla> EmpresaRegla { get; set; }
        public virtual DbSet<EmpresaRestriccion> EmpresaRestriccion { get; set; }
        public virtual DbSet<Entrega> Entrega { get; set; }
        public virtual DbSet<Error_Log_SQL> Error_Log_SQL { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<EspecialidadNegocio> EspecialidadNegocio { get; set; }
        public virtual DbSet<EspecialidadxProducto> EspecialidadxProducto { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Estatus> Estatus { get; set; }
        public virtual DbSet<EstatusAfiliado> EstatusAfiliado { get; set; }
        public virtual DbSet<EstatusArchivo> EstatusArchivo { get; set; }
        public virtual DbSet<EstatusBandeja> EstatusBandeja { get; set; }
        public virtual DbSet<EstatusFolio> EstatusFolio { get; set; }
        public virtual DbSet<EstatusImpresion> EstatusImpresion { get; set; }
        public virtual DbSet<EstatusPago> EstatusPago { get; set; }
        public virtual DbSet<FacturaEstatus> FacturaEstatus { get; set; }
        public virtual DbSet<FacturaFranquicia> FacturaFranquicia { get; set; }
        public virtual DbSet<Facturas_> Facturas_ { get; set; }
        public virtual DbSet<Ficha_Tecnica> Ficha_Tecnica { get; set; }
        public virtual DbSet<Folio> Folio { get; set; }
        public virtual DbSet<FolioAfiliado> FolioAfiliado { get; set; }
        public virtual DbSet<FolioMembresia> FolioMembresia { get; set; }
        public virtual DbSet<FoliosFacturas> FoliosFacturas { get; set; }
        public virtual DbSet<Gender> Gender { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<GrupoAfiliado> GrupoAfiliado { get; set; }
        public virtual DbSet<GruposFacturacion> GruposFacturacion { get; set; }
        public virtual DbSet<ICD> ICD { get; set; }
        public virtual DbSet<Login> Login { get; set; }
        public virtual DbSet<LogMovimientosCatLabGab> LogMovimientosCatLabGab { get; set; }
        public virtual DbSet<LOTE> LOTE { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<MotivoConsulta> MotivoConsulta { get; set; }
        public virtual DbSet<MotivoDevolucion> MotivoDevolucion { get; set; }
        public virtual DbSet<MotivoIncapacidad> MotivoIncapacidad { get; set; }
        public virtual DbSet<MotivoLlamada> MotivoLlamada { get; set; }
        public virtual DbSet<MovimientosEspecialidad> MovimientosEspecialidad { get; set; }
        public virtual DbSet<NivelEspecialidad> NivelEspecialidad { get; set; }
        public virtual DbSet<OperacionBancaria> OperacionBancaria { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<PaseEspecialista> PaseEspecialista { get; set; }
        public virtual DbSet<PasoAfiliado> PasoAfiliado { get; set; }
        public virtual DbSet<Pendiente> Pendiente { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Periodo> Periodo { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<planes_log> planes_log { get; set; }
        public virtual DbSet<Poblacion> Poblacion { get; set; }
        public virtual DbSet<PolizasOxxoVigencia> PolizasOxxoVigencia { get; set; }
        public virtual DbSet<Procedimiento> Procedimiento { get; set; }
        public virtual DbSet<ProcedimientoEspecialidad> ProcedimientoEspecialidad { get; set; }
        public virtual DbSet<ProdMedControlados> ProdMedControlados { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoAseguradora> ProductoAseguradora { get; set; }
        public virtual DbSet<Productos_Vigentes> Productos_Vigentes { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Recibo> Recibo { get; set; }
        public virtual DbSet<Red> Red { get; set; }
        public virtual DbSet<RedProveedor> RedProveedor { get; set; }
        public virtual DbSet<Regla> Regla { get; set; }
        public virtual DbSet<RelacionCartaMP> RelacionCartaMP { get; set; }
        public virtual DbSet<Restriccion> Restriccion { get; set; }
        public virtual DbSet<SeguLogin> SeguLogin { get; set; }
        public virtual DbSet<SeguPerfil> SeguPerfil { get; set; }
        public virtual DbSet<SeguPersona> SeguPersona { get; set; }
        public virtual DbSet<SeguSession> SeguSession { get; set; }
        public virtual DbSet<Sentido> Sentido { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<ServicioGeneral> ServicioGeneral { get; set; }
        public virtual DbSet<ServicioReferido> ServicioReferido { get; set; }
        public virtual DbSet<SSA> SSA { get; set; }
        public virtual DbSet<SSR> SSR { get; set; }
        public virtual DbSet<StaffMedico> StaffMedico { get; set; }
        public virtual DbSet<Subcategoria> Subcategoria { get; set; }
        public virtual DbSet<SubEspecialidad> SubEspecialidad { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Cuadros> sys_mediaccess_Cat_Cuadros { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Especialidades> sys_mediaccess_Cat_Especialidades { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Grupos> sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Laboratorios> sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<Sys_Mediaccess_Cat_Medicina_Preventiva> Sys_Mediaccess_Cat_Medicina_Preventiva { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Sal> sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos> sys_mediaccess_Medicamentos { get; set; }
        public virtual DbSet<Sys_Mediaccess_Medicina_Preventiva_Folios> Sys_Mediaccess_Medicina_Preventiva_Folios { get; set; }
        public virtual DbSet<SYS_Mediaccess_Producto_Autorizado> SYS_Mediaccess_Producto_Autorizado { get; set; }
        public virtual DbSet<Sys_Mediaccess_SAB_AplicativoConsume> Sys_Mediaccess_SAB_AplicativoConsume { get; set; }
        public virtual DbSet<SYS_Mediaccess_SAB_MetodosWS> SYS_Mediaccess_SAB_MetodosWS { get; set; }
        public virtual DbSet<SYS_Mediaccess_SAB_PerfilesWS> SYS_Mediaccess_SAB_PerfilesWS { get; set; }
        public virtual DbSet<SYS_Mediaccess_SAB_UsuarioWS> SYS_Mediaccess_SAB_UsuarioWS { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TABLARELACIOINFONAVIT> TABLARELACIOINFONAVIT { get; set; }
        public virtual DbSet<Tabulador> Tabulador { get; set; }
        public virtual DbSet<TB_AfiliadoVentas> TB_AfiliadoVentas { get; set; }
        public virtual DbSet<TB_Programacion> TB_Programacion { get; set; }
        public virtual DbSet<TB_REL_POLIZA_ENDOSOS> TB_REL_POLIZA_ENDOSOS { get; set; }
        public virtual DbSet<TipoCliente> TipoCliente { get; set; }
        public virtual DbSet<TipoConsulta> TipoConsulta { get; set; }
        public virtual DbSet<TipoContacto> TipoContacto { get; set; }
        public virtual DbSet<TipoContribuyente> TipoContribuyente { get; set; }
        public virtual DbSet<TipoCopago> TipoCopago { get; set; }
        public virtual DbSet<TipoFormato> TipoFormato { get; set; }
        public virtual DbSet<TipoGasto> TipoGasto { get; set; }
        public virtual DbSet<TipoGastoCopago> TipoGastoCopago { get; set; }
        public virtual DbSet<TipoMovimientoEspecialidad> TipoMovimientoEspecialidad { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<TipoResponsable> TipoResponsable { get; set; }
        public virtual DbSet<TipoServicioReferido> TipoServicioReferido { get; set; }
        public virtual DbSet<TipoTabulador> TipoTabulador { get; set; }
        public virtual DbSet<TipoUbicacion> TipoUbicacion { get; set; }
        public virtual DbSet<TipoVendedor> TipoVendedor { get; set; }
        public virtual DbSet<UbicacionAfiliado> UbicacionAfiliado { get; set; }
        public virtual DbSet<UbicacionEmpresa> UbicacionEmpresa { get; set; }
        public virtual DbSet<UbicacionProveedor> UbicacionProveedor { get; set; }
        public virtual DbSet<UbicacionVendedor> UbicacionVendedor { get; set; }
        public virtual DbSet<usuarioApp> usuarioApp { get; set; }
        public virtual DbSet<UsuariosSistemas> UsuariosSistemas { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }
        public virtual DbSet<ventasSistemaCartera> ventasSistemaCartera { get; set; }
        public virtual DbSet<ViaCarga> ViaCarga { get; set; }
        public virtual DbSet<wsTransaccionLog> wsTransaccionLog { get; set; }
        public virtual DbSet<xmlproveedores_Web> xmlproveedores_Web { get; set; }
        public virtual DbSet<xmlproveedores_Web_> xmlproveedores_Web_ { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }
        public virtual DbSet<A_Afiliado> A_Afiliado { get; set; }
        public virtual DbSet<A_Afiliado_log> A_Afiliado_log { get; set; }
        public virtual DbSet<A_Mediaccess_Afiliado> A_Mediaccess_Afiliado { get; set; }
        public virtual DbSet<A_UbicacionAfiliado> A_UbicacionAfiliado { get; set; }
        public virtual DbSet<AE_Acceso_Usuarios_Bajas> AE_Acceso_Usuarios_Bajas { get; set; }
        public virtual DbSet<Afiliado_log> Afiliado_log { get; set; }
        public virtual DbSet<Afiliado_log_BC> Afiliado_log_BC { get; set; }
        public virtual DbSet<Afiliado_logM> Afiliado_logM { get; set; }
        public virtual DbSet<afiliadoBancomextmasivo> afiliadoBancomextmasivo { get; set; }
        public virtual DbSet<afiliadoBancomextmasivoRESULTADO> afiliadoBancomextmasivoRESULTADO { get; set; }
        public virtual DbSet<AfiliadoBMX_log> AfiliadoBMX_log { get; set; }
        public virtual DbSet<afiliadoNAFINmasivo> afiliadoNAFINmasivo { get; set; }
        public virtual DbSet<afiliadoNAFINmasivo12062018> afiliadoNAFINmasivo12062018 { get; set; }
        public virtual DbSet<Afiliados_codEmpresa954> Afiliados_codEmpresa954 { get; set; }
        public virtual DbSet<Afiliadosactualizacion_operaciones> Afiliadosactualizacion_operaciones { get; set; }
        public virtual DbSet<AfiliadosAseguradora> AfiliadosAseguradora { get; set; }
        public virtual DbSet<AfiliadoSHFLOG> AfiliadoSHFLOG { get; set; }
        public virtual DbSet<ALZ_SASS_PV_CambioProveedores> ALZ_SASS_PV_CambioProveedores { get; set; }
        public virtual DbSet<AngendaCampañas> AngendaCampañas { get; set; }
        public virtual DbSet<AnotacionesExtras_LOG> AnotacionesExtras_LOG { get; set; }
        public virtual DbSet<asignacionCoberturaGrupoEmpresa> asignacionCoberturaGrupoEmpresa { get; set; }
        public virtual DbSet<AutorizacionesConsultadas> AutorizacionesConsultadas { get; set; }
        public virtual DbSet<BandejaEntradaPaso> BandejaEntradaPaso { get; set; }
        public virtual DbSet<Cat_Parentesco_Sicas> Cat_Parentesco_Sicas { get; set; }
        public virtual DbSet<CertificadoIncapacidad> CertificadoIncapacidad { get; set; }
        public virtual DbSet<Coberturas> Coberturas { get; set; }
        public virtual DbSet<coberturasTipoGasto> coberturasTipoGasto { get; set; }
        public virtual DbSet<CuentaAut> CuentaAut { get; set; }
        public virtual DbSet<CuentaHist> CuentaHist { get; set; }
        public virtual DbSet<DatoscuentaNafin> DatoscuentaNafin { get; set; }
        public virtual DbSet<DatosIvr> DatosIvr { get; set; }
        public virtual DbSet<datosrpt> datosrpt { get; set; }
        public virtual DbSet<datosrptcmb> datosrptcmb { get; set; }
        public virtual DbSet<EMI_Afiliados_Alta> EMI_Afiliados_Alta { get; set; }
        public virtual DbSet<EMI_Afiliados_Baja> EMI_Afiliados_Baja { get; set; }
        public virtual DbSet<EMI_Afiliados_Renovacion> EMI_Afiliados_Renovacion { get; set; }
        public virtual DbSet<EMI_Impresion_LogImpresion> EMI_Impresion_LogImpresion { get; set; }
        public virtual DbSet<EMI_Tarjetas_Producto> EMI_Tarjetas_Producto { get; set; }
        public virtual DbSet<empresaspymesicas> empresaspymesicas { get; set; }
        public virtual DbSet<EMPRESAVIRTUAL> EMPRESAVIRTUAL { get; set; }
        public virtual DbSet<EnvioCorreosProcesos> EnvioCorreosProcesos { get; set; }
        public virtual DbSet<estados> estados { get; set; }
        public virtual DbSet<Estatus_Cuenta> Estatus_Cuenta { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<FICHA_PRODUCTO> FICHA_PRODUCTO { get; set; }
        public virtual DbSet<Ficha_Tecnica_3> Ficha_Tecnica_3 { get; set; }
        public virtual DbSet<Ficha_Tecnica151221> Ficha_Tecnica151221 { get; set; }
        public virtual DbSet<grupos> grupos { get; set; }
        public virtual DbSet<hospitalcede> hospitalcede { get; set; }
        public virtual DbSet<iss_sys_mediaccess_producto_autorizado> iss_sys_mediaccess_producto_autorizado { get; set; }
        public virtual DbSet<LogAutorizacionesConsultadas> LogAutorizacionesConsultadas { get; set; }
        public virtual DbSet<LogAutorizacionesConsultadasM> LogAutorizacionesConsultadasM { get; set; }
        public virtual DbSet<Operacion> Operacion { get; set; }
        public virtual DbSet<Oxxoceti> Oxxoceti { get; set; }
        public virtual DbSet<Oxxoceti2> Oxxoceti2 { get; set; }
        public virtual DbSet<PEMEX_CE_CuentaHistProcesados> PEMEX_CE_CuentaHistProcesados { get; set; }
        public virtual DbSet<PEMEX_CE_DatosAdicionalesProveedor> PEMEX_CE_DatosAdicionalesProveedor { get; set; }
        public virtual DbSet<PolizasOxxo> PolizasOxxo { get; set; }
        public virtual DbSet<ProcesosCorreos> ProcesosCorreos { get; set; }
        public virtual DbSet<Producto_log> Producto_log { get; set; }
        public virtual DbSet<productofalta> productofalta { get; set; }
        public virtual DbSet<ProductoImpresion> ProductoImpresion { get; set; }
        public virtual DbSet<ProductoxClasificacion> ProductoxClasificacion { get; set; }
        public virtual DbSet<PublicacionREM> PublicacionREM { get; set; }
        public virtual DbSet<RepEmailEstatus_TB> RepEmailEstatus_TB { get; set; }
        public virtual DbSet<RepEmailLog_TB> RepEmailLog_TB { get; set; }
        public virtual DbSet<retroactivas> retroactivas { get; set; }
        public virtual DbSet<SYS_IVR_PaseEspecialista> SYS_IVR_PaseEspecialista { get; set; }
        public virtual DbSet<SYS_Mediacces_EstadoCuenta_Agrupa> SYS_Mediacces_EstadoCuenta_Agrupa { get; set; }
        public virtual DbSet<SYS_Mediacces_Formato> SYS_Mediacces_Formato { get; set; }
        public virtual DbSet<Sys_Mediaccess_Afiliados_Consulta_RedMedica> Sys_Mediaccess_Afiliados_Consulta_RedMedica { get; set; }
        public virtual DbSet<Sys_Mediaccess_Cat_Grupo_Medicina_Preventiva> Sys_Mediaccess_Cat_Grupo_Medicina_Preventiva { get; set; }
        public virtual DbSet<Sys_Mediaccess_Cat_Oftalmologia> Sys_Mediaccess_Cat_Oftalmologia { get; set; }
        public virtual DbSet<sys_mediaccess_cat_producto_rangos_Medicina_Preventiva> sys_mediaccess_cat_producto_rangos_Medicina_Preventiva { get; set; }
        public virtual DbSet<Sys_Mediaccess_Cat_TipoEmpleado> Sys_Mediaccess_Cat_TipoEmpleado { get; set; }
        public virtual DbSet<Sys_Mediaccess_Estudios_Medicina_Preventiva> Sys_Mediaccess_Estudios_Medicina_Preventiva { get; set; }
        public virtual DbSet<Sys_Mediaccess_Grupo_Plan> Sys_Mediaccess_Grupo_Plan { get; set; }
        public virtual DbSet<Sys_Mediaccess_Medicina_Preventiva_Folios_log> Sys_Mediaccess_Medicina_Preventiva_Folios_log { get; set; }
        public virtual DbSet<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico> Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico { get; set; }
        public virtual DbSet<Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO> Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO { get; set; }
        public virtual DbSet<Sys_Mediaccess_ProcesosLog> Sys_Mediaccess_ProcesosLog { get; set; }
        public virtual DbSet<SYS_Mediaccess_Pyme_Colectiva> SYS_Mediaccess_Pyme_Colectiva { get; set; }
        public virtual DbSet<Sys_Mediaccess_Rangos_Medicina_Preventiva> Sys_Mediaccess_Rangos_Medicina_Preventiva { get; set; }
        public virtual DbSet<Sys_Mediaccess_Rangos_Medicina_Preventiva_anterior> Sys_Mediaccess_Rangos_Medicina_Preventiva_anterior { get; set; }
        public virtual DbSet<Sys_Medired_AfiliadosABC> Sys_Medired_AfiliadosABC { get; set; }
        public virtual DbSet<Sys_Medired_AfiliadosABC_log> Sys_Medired_AfiliadosABC_log { get; set; }
        public virtual DbSet<Sys_Medired_AfiliadosABC_logMasivo> Sys_Medired_AfiliadosABC_logMasivo { get; set; }
        public virtual DbSet<SYS_RE_Clinica_Catalogo> SYS_RE_Clinica_Catalogo { get; set; }
        public virtual DbSet<SYS_SICAS_Endosos> SYS_SICAS_Endosos { get; set; }
        public virtual DbSet<SysMediaccess_LogMP> SysMediaccess_LogMP { get; set; }
        public virtual DbSet<TB_CONFPAMMODULARDET> TB_CONFPAMMODULARDET { get; set; }
        public virtual DbSet<TB_Endosos_PDF> TB_Endosos_PDF { get; set; }
        public virtual DbSet<TB_PolizasAdssyf> TB_PolizasAdssyf { get; set; }
        public virtual DbSet<TB_ProgramacionDoc> TB_ProgramacionDoc { get; set; }
        public virtual DbSet<TB_ProgramacionProcDiag> TB_ProgramacionProcDiag { get; set; }
        public virtual DbSet<TB_WS_AfiliadosSICAS> TB_WS_AfiliadosSICAS { get; set; }
        public virtual DbSet<TB_WS_AfiliadosSICASABC> TB_WS_AfiliadosSICASABC { get; set; }
        public virtual DbSet<TB_WS_AfiliadosSICASABC_log> TB_WS_AfiliadosSICASABC_log { get; set; }
        public virtual DbSet<TB_WS_AfiliadosSICASB> TB_WS_AfiliadosSICASB { get; set; }
        public virtual DbSet<TB_WS_AfiliadosSICASC> TB_WS_AfiliadosSICASC { get; set; }
        public virtual DbSet<TBAFILAFICASNP> TBAFILAFICASNP { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TipoExamen> TipoExamen { get; set; }
        public virtual DbSet<tmp_afiliado_log> tmp_afiliado_log { get; set; }
        public virtual DbSet<UbicacionAfiliado_log> UbicacionAfiliado_log { get; set; }
        public virtual DbSet<ubicacionafiliadoBancomextmasivo> ubicacionafiliadoBancomextmasivo { get; set; }
        public virtual DbSet<ubicacionafiliadoBancomextmasivoRESULTADO> ubicacionafiliadoBancomextmasivoRESULTADO { get; set; }
        public virtual DbSet<UbicacionAfiliadoMasivo> UbicacionAfiliadoMasivo { get; set; }
        public virtual DbSet<UbicacionAfiliadoNAFINMasivo> UbicacionAfiliadoNAFINMasivo { get; set; }
        public virtual DbSet<UbicacionAfiliadoNAFINMasivo12062018> UbicacionAfiliadoNAFINMasivo12062018 { get; set; }
        public virtual DbSet<UbicacionAfiliados_codEmpresa954> UbicacionAfiliados_codEmpresa954 { get; set; }
        public virtual DbSet<Usuario_Asig_Sistema> Usuario_Asig_Sistema { get; set; }
        public virtual DbSet<ValElegibilidad> ValElegibilidad { get; set; }
        public virtual DbSet<vLayoutAfiliadosSass_Log> vLayoutAfiliadosSass_Log { get; set; }
        public virtual DbSet<wsTransaccionLogBK> wsTransaccionLogBK { get; set; }
        public virtual DbSet<XML_SistemaProveedores> XML_SistemaProveedores { get; set; }
        public virtual DbSet<Xmlcadena> Xmlcadena { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Acreedor>()
                .Property(e => e.Acreedor1)
                .IsUnicode(false);

            modelBuilder.Entity<Acreedor>()
                .HasMany(e => e.Recibo)
                .WithRequired(e => e.Acreedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AdminAgenda>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<AdminUsers>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Perfil>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios>()
                .Property(e => e.Usuario_I)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios>()
                .Property(e => e.Usuario_U)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSeguro>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicaciones>()
                .Property(e => e.NombreAplicativo)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicaciones>()
                .Property(e => e.DescripcionAplicativo)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicaciones>()
                .Property(e => e.UsrAltaAplicativo)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicaciones>()
                .Property(e => e.UsrBajaAplicativo)
                .IsUnicode(false);

            modelBuilder.Entity<Aplicaciones>()
                .HasOptional(e => e.Aplicaciones1)
                .WithRequired(e => e.Aplicaciones2);

            modelBuilder.Entity<AreaTrabajo>()
                .Property(e => e.NombreArea)
                .IsUnicode(false);

            modelBuilder.Entity<AreaTrabajo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Aseguradoras>()
                .Property(e => e.Aseguragora)
                .IsUnicode(false);

            modelBuilder.Entity<Asegurados>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Banco1)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.LOTE)
                .WithRequired(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.SSA)
                .WithRequired(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Banco>()
                .HasMany(e => e.SSR)
                .WithRequired(e => e.Banco)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.QuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodMotivoQueja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.codMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.Observacion1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.Observacion2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<Campania>()
                .Property(e => e.Campania1)
                .IsUnicode(false);

            modelBuilder.Entity<Campania>()
                .Property(e => e.CodEstatusCampania)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Campania>()
                .HasMany(e => e.Empresa)
                .WithRequired(e => e.Campania)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CargaArchivos>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<CargaArchivos>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<CargaArchivos>()
                .Property(e => e.CodEstatusArchivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Moneda>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Catalogo_Moneda>()
                .HasMany(e => e.Ficha_Tecnica)
                .WithRequired(e => e.Catalogo_Moneda)
                .HasForeignKey(e => e.Id_Moneda)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CatalogoEstudio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoEstudio>()
                .Property(e => e.Precio)
                .HasPrecision(18, 4);

            modelBuilder.Entity<CatalogoEstudio>()
                .Property(e => e.CveEstudio)
                .IsUnicode(false);

            modelBuilder.Entity<CatalogoEstudio>()
                .HasMany(e => e.ClasificacionxProducto)
                .WithRequired(e => e.CatalogoEstudio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CatAutorizacion>()
                .Property(e => e.Clave)
                .IsUnicode(false);

            modelBuilder.Entity<CatAutorizacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatAutorizacion>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.CatalogoEstudio)
                .WithRequired(e => e.Categoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CatRegimenFiscal>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatRegimenFiscal>()
                .Property(e => e.Fisica)
                .IsUnicode(false);

            modelBuilder.Entity<CatRegimenFiscal>()
                .Property(e => e.Moral)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Clasificacion>()
                .HasMany(e => e.ProductoxClasificacion)
                .WithRequired(e => e.Clasificacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ClasificacionxProducto>()
                .Property(e => e.CveAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .Property(e => e.Cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .Property(e => e.CodAgrupador)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .HasMany(e => e.CoverageFilter)
                .WithRequired(e => e.Coberturas_Ficha_Tecnica)
                .HasForeignKey(e => e.Cobertura_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Coberturas_Ficha_Tecnica>()
                .HasMany(e => e.Ficha_Tecnica)
                .WithRequired(e => e.Coberturas_Ficha_Tecnica)
                .HasForeignKey(e => e.Id_Cobertura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CodSeguro>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Colonia>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Colonia>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Colonia>()
                .Property(e => e.Colonia1)
                .IsUnicode(false);

            modelBuilder.Entity<Colonia>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colonia>()
                .Property(e => e.CPOficina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Colonia>()
                .HasMany(e => e.UbicacionEmpresa)
                .WithRequired(e => e.Colonia)
                .HasForeignKey(e => new { e.CodPais, e.CodEstado, e.CodPoblacion, e.CodColonia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colonia>()
                .HasMany(e => e.UbicacionProveedor)
                .WithRequired(e => e.Colonia)
                .HasForeignKey(e => new { e.CodPais, e.CodEstado, e.CodPoblacion, e.CodColonia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Colonia>()
                .HasMany(e => e.UbicacionVendedor)
                .WithRequired(e => e.Colonia)
                .HasForeignKey(e => new { e.CodPais, e.CodEstado, e.CodPoblacion, e.CodColonia })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Comision>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ContactoAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoAfiliado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoEmpresa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoVendedor>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoVendedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CuadroBasico>()
                .Property(e => e.CodCuadroBasico)
                .IsUnicode(false);

            modelBuilder.Entity<CuadroBasico>()
                .Property(e => e.CodigoEAN)
                .IsUnicode(false);

            modelBuilder.Entity<CuadroBasico>()
                .Property(e => e.Medicamento)
                .IsUnicode(false);

            modelBuilder.Entity<CuadroBasico>()
                .Property(e => e.SubstanciaActiva)
                .IsUnicode(false);

            modelBuilder.Entity<CuadroBasico>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Devolucion>()
                .Property(e => e.CodDevolucion)
                .IsUnicode(false);

            modelBuilder.Entity<Devolucion>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Divisa>()
                .Property(e => e.Divisa1)
                .IsUnicode(false);

            modelBuilder.Entity<Divisa>()
                .HasMany(e => e.LOTE)
                .WithRequired(e => e.Divisa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Divisa>()
                .HasMany(e => e.SSA)
                .WithRequired(e => e.Divisa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Divisa>()
                .HasMany(e => e.SSR)
                .WithRequired(e => e.Divisa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Documento1)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .HasMany(e => e.DocumentoProveedor)
                .WithRequired(e => e.Documento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DocumentoProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Catalogo>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Catalogo>()
                .HasMany(e => e.EMI_Tarjetas_Producto)
                .WithRequired(e => e.EMI_Tarjetas_Catalogo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.NombreEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.NombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CodEstatusEmpresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.CargaArchivos)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Comision)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.ContactoEmpresa)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.EmpresaRegla)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.EmpresaRestriccion)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.EmpresaPeriodo)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.EmpresaProducto)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Recibo)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.UbicacionEmpresa)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Empresa>()
                .HasMany(e => e.Vendedor)
                .WithRequired(e => e.Empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EmpresaProducto>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaRegla>()
                .Property(e => e.CodRegla)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaRegla>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaRestriccion>()
                .Property(e => e.CodRestriccion)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaRestriccion>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaRestriccion>()
                .Property(e => e.Cveg_Permiso)
                .IsUnicode(false);

            modelBuilder.Entity<EmpresaRestriccion>()
                .Property(e => e.UsuarioRegistro)
                .IsUnicode(false);

            modelBuilder.Entity<Entrega>()
                .Property(e => e.Entrega1)
                .IsUnicode(false);

            modelBuilder.Entity<Entrega>()
                .HasMany(e => e.DocumentoProveedor)
                .WithRequired(e => e.Entrega)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.CodEspecialidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.Especialidad1)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.ConRetencion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.SinRetencion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .HasMany(e => e.ProcedimientoEspecialidad)
                .WithRequired(e => e.Especialidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Especialidad>()
                .HasMany(e => e.SubEspecialidad)
                .WithRequired(e => e.Especialidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.CodigoEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.ClaveEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .HasMany(e => e.MovimientosEspecialidad)
                .WithRequired(e => e.EspecialidadNegocio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EspecialidadNegocio>()
                .HasMany(e => e.EspecialidadxProducto)
                .WithRequired(e => e.EspecialidadNegocio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EspecialidadxProducto>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<EspecialidadxProducto>()
                .Property(e => e.CodigoEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Estado1)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .HasMany(e => e.Poblacion)
                .WithRequired(e => e.Estado)
                .HasForeignKey(e => new { e.CodPais, e.CodEstado })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstadoCivil>()
                .Property(e => e.EstadoCivil1)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus>()
                .Property(e => e.Estatus1)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.Empresa)
                .WithRequired(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusEmpresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.EstatusAfiliado)
                .WithRequired(e => e.Estatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.Proveedor)
                .WithRequired(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusProveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.RedProveedor)
                .WithRequired(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusRedProveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.Servicio)
                .WithRequired(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.StaffMedico)
                .WithRequired(e => e.Estatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.UbicacionAfiliado)
                .WithRequired(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.UbicacionEmpresa)
                .WithRequired(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Estatus>()
                .HasMany(e => e.UbicacionProveedor)
                .WithOptional(e => e.Estatus)
                .HasForeignKey(e => e.CodEstatusUbicacion);

            modelBuilder.Entity<EstatusAfiliado>()
                .Property(e => e.EstatusAfiliado1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusAfiliado>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EstatusArchivo>()
                .Property(e => e.CodEstatusArchivo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EstatusArchivo>()
                .Property(e => e.EstatusArchivo1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusArchivo>()
                .HasMany(e => e.CargaArchivos)
                .WithRequired(e => e.EstatusArchivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstatusBandeja>()
                .Property(e => e.EstatusBandeja1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFolio>()
                .Property(e => e.CodEstatusFolio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFolio>()
                .Property(e => e.EstatusFolio1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusFolio>()
                .HasMany(e => e.FoliosFacturas)
                .WithRequired(e => e.EstatusFolio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstatusImpresion>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EstatusImpresion>()
                .Property(e => e.EstatusImpresion1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusPago>()
                .Property(e => e.CodEstatusPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EstatusPago>()
                .Property(e => e.EstatusPago1)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusPago>()
                .HasMany(e => e.FacturaFranquicia)
                .WithRequired(e => e.EstatusPago1)
                .HasForeignKey(e => e.EstatusPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EstatusPago>()
                .HasMany(e => e.SSR)
                .WithRequired(e => e.EstatusPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FacturaEstatus>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaEstatus>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaEstatus>()
                .Property(e => e.CodEstatusFactura)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacturaEstatus>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaFranquicia>()
                .Property(e => e.NoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturaFranquicia>()
                .Property(e => e.EstatusPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.CodEstatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.CodConcepto)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.comprobante)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.StickerRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.StickerEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.CodControl)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.Metodo)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.cve_empresa)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas_>()
                .Property(e => e.remesa)
                .IsUnicode(false);

            modelBuilder.Entity<Ficha_Tecnica>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Ficha_Tecnica>()
                .Property(e => e.Especificaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Folio>()
                .Property(e => e.Folio1)
                .IsUnicode(false);

            modelBuilder.Entity<Folio>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Folio>()
                .Property(e => e.Exadmin)
                .IsUnicode(false);

            modelBuilder.Entity<Folio>()
                .Property(e => e.Ccostos)
                .IsUnicode(false);

            modelBuilder.Entity<FolioAfiliado>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<FolioAfiliado>()
                .Property(e => e.FolioMembresia)
                .IsUnicode(false);

            modelBuilder.Entity<FolioAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<FolioMembresia>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<FolioMembresia>()
                .Property(e => e.InicioFolioMembresia)
                .IsUnicode(false);

            modelBuilder.Entity<FolioMembresia>()
                .Property(e => e.FinFolioMembresaia)
                .IsUnicode(false);

            modelBuilder.Entity<FolioMembresia>()
                .HasMany(e => e.FolioAfiliado)
                .WithRequired(e => e.FolioMembresia1)
                .HasForeignKey(e => new { e.CodVendedor, e.NoEntrega })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FoliosFacturas>()
                .Property(e => e.Referencia)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosFacturas>()
                .Property(e => e.CodTipoFormato)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosFacturas>()
                .Property(e => e.CodEstatusFolio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FoliosFacturas>()
                .Property(e => e.FolioInicial)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosFacturas>()
                .Property(e => e.FolioFinal)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosFacturas>()
                .Property(e => e.ReferenciaEntrega)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosFacturas>()
                .HasMany(e => e.FoliosFacturas1)
                .WithOptional(e => e.FoliosFacturas2)
                .HasForeignKey(e => e.ReferenciaEntrega);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<Gender>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Grupo1)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .HasMany(e => e.GrupoAfiliado)
                .WithRequired(e => e.Grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GrupoAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<GruposFacturacion>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<GruposFacturacion>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<GruposFacturacion>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<GruposFacturacion>()
                .Property(e => e.Grupo)
                .IsUnicode(false);

            modelBuilder.Entity<GruposFacturacion>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<GruposFacturacion>()
                .Property(e => e.RazonSocial)
                .IsUnicode(false);

            modelBuilder.Entity<ICD>()
                .Property(e => e.ICD1)
                .IsUnicode(false);

            modelBuilder.Entity<ICD>()
                .Property(e => e.Diagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.SegLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.SegPass)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Login>()
                .HasMany(e => e.CargaArchivos)
                .WithRequired(e => e.Login)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogMovimientosCatLabGab>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<LOTE>()
                .Property(e => e.NoLote)
                .IsUnicode(false);

            modelBuilder.Entity<LOTE>()
                .Property(e => e.CodSentido)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOTE>()
                .HasMany(e => e.SSR)
                .WithRequired(e => e.LOTE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MetodoPago>()
                .Property(e => e.CodMetodoPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<MetodoPago>()
                .Property(e => e.MetodoPago1)
                .IsUnicode(false);

            modelBuilder.Entity<MetodoPago>()
                .HasMany(e => e.Proveedor)
                .WithRequired(e => e.MetodoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoConsulta>()
                .Property(e => e.MotivoConsulta1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoDevolucion>()
                .Property(e => e.MotivoDevolucion1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoDevolucion>()
                .HasMany(e => e.LOTE)
                .WithRequired(e => e.MotivoDevolucion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoDevolucion>()
                .HasMany(e => e.SSR)
                .WithRequired(e => e.MotivoDevolucion)
                .HasForeignKey(e => e.CodDevolucion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoIncapacidad>()
                .Property(e => e.MotivoIncapacidad1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoIncapacidad>()
                .HasMany(e => e.CertificadoIncapacidad)
                .WithRequired(e => e.MotivoIncapacidad)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MotivoLlamada>()
                .Property(e => e.MotivoLlamada1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoLlamada>()
                .HasMany(e => e.Servicio)
                .WithRequired(e => e.MotivoLlamada)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MovimientosEspecialidad>()
                .Property(e => e.CodigoEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientosEspecialidad>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<NivelEspecialidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionBancaria>()
                .Property(e => e.OperacionBancaria1)
                .IsUnicode(false);

            modelBuilder.Entity<OperacionBancaria>()
                .HasMany(e => e.LOTE)
                .WithRequired(e => e.OperacionBancaria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .Property(e => e.Pais1)
                .IsUnicode(false);

            modelBuilder.Entity<Pais>()
                .HasMany(e => e.Estado)
                .WithRequired(e => e.Pais)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.Parentesco1)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialista>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialista>()
                .Property(e => e.MotivoReferencia)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialista>()
                .Property(e => e.CodEspecialidadReferida)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialista>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<PasoAfiliado>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Pendiente>()
                .Property(e => e.CodPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<Pendiente>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .Property(e => e.Perfil1)
                .IsUnicode(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Login)
                .WithRequired(e => e.Perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Perfil>()
                .HasMany(e => e.Proveedor)
                .WithRequired(e => e.Perfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Periodo>()
                .Property(e => e.Periodo1)
                .IsUnicode(false);

            modelBuilder.Entity<Periodo>()
                .HasMany(e => e.Empresa)
                .WithRequired(e => e.Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Periodo>()
                .HasMany(e => e.EmpresaPeriodo)
                .WithRequired(e => e.Periodo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<planes>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<planes_log>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<planes_log>()
                .Property(e => e.xUsrInsertEvento)
                .IsUnicode(false);

            modelBuilder.Entity<planes_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.Poblacion1)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.Procedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.CodTipoTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.CodCuadroBasico)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .HasMany(e => e.ProcedimientoEspecialidad)
                .WithRequired(e => e.Procedimiento)
                .HasForeignKey(e => e.CodProcedimeinto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProcedimientoEspecialidad>()
                .Property(e => e.CodEspecialidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProcedimientoEspecialidad>()
                .Property(e => e.CodProcedimeinto)
                .IsUnicode(false);

            modelBuilder.Entity<ProcedimientoEspecialidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ProcedimientoEspecialidad>()
                .HasMany(e => e.Tabulador)
                .WithRequired(e => e.ProcedimientoEspecialidad)
                .HasForeignKey(e => new { e.CodEspecialidad, e.CodProcedimiento })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProdMedControlados>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<ProdMedControlados>()
                .Property(e => e.xUsrinsert)
                .IsUnicode(false);

            modelBuilder.Entity<ProdMedControlados>()
                .Property(e => e.xUsrUpdate)
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

            modelBuilder.Entity<ProductoAseguradora>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Productos_Vigentes>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.NombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.CodMetodoPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.CodEspecialidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.CodEstatusProveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.LGProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .Property(e => e.PSProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.DocumentoProveedor)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.RedProveedor)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.ServicioGeneral)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.StaffMedico)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Proveedor>()
                .HasMany(e => e.UbicacionProveedor)
                .WithRequired(e => e.Proveedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Recibo>()
                .Property(e => e.NoRecibo)
                .IsUnicode(false);

            modelBuilder.Entity<Recibo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Recibo>()
                .Property(e => e.NoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Recibo>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recibo>()
                .HasOptional(e => e.SSR)
                .WithRequired(e => e.Recibo);

            modelBuilder.Entity<Red>()
                .Property(e => e.Red1)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.NombreLargo)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .HasMany(e => e.Empresa)
                .WithRequired(e => e.Red)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Red>()
                .HasMany(e => e.RedProveedor)
                .WithRequired(e => e.Red)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RedProveedor>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<RedProveedor>()
                .Property(e => e.CodEstatusRedProveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RedProveedor>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<RedProveedor>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<RedProveedor>()
                .HasMany(e => e.Tabulador)
                .WithRequired(e => e.RedProveedor)
                .HasForeignKey(e => new { e.CodRed, e.CodProveedor })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regla>()
                .Property(e => e.CodRegla)
                .IsUnicode(false);

            modelBuilder.Entity<Regla>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Regla>()
                .HasMany(e => e.EmpresaRegla)
                .WithRequired(e => e.Regla)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RelacionCartaMP>()
                .Property(e => e.producto)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionCartaMP>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionCartaMP>()
                .Property(e => e.carta)
                .IsUnicode(false);

            modelBuilder.Entity<RelacionCartaMP>()
                .Property(e => e.talon)
                .IsUnicode(false);

            modelBuilder.Entity<Restriccion>()
                .Property(e => e.CodRestriccion)
                .IsUnicode(false);

            modelBuilder.Entity<Restriccion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Restriccion>()
                .Property(e => e.Cveg_Tipo_Entidad)
                .IsUnicode(false);

            modelBuilder.Entity<Restriccion>()
                .HasMany(e => e.EmpresaRestriccion)
                .WithRequired(e => e.Restriccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeguLogin>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<SeguLogin>()
                .Property(e => e.ClaveAcceso)
                .IsUnicode(false);

            modelBuilder.Entity<SeguLogin>()
                .Property(e => e.TipoUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SeguLogin>()
                .HasMany(e => e.SeguSession)
                .WithRequired(e => e.SeguLogin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeguPerfil>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPerfil>()
                .HasMany(e => e.SeguLogin)
                .WithRequired(e => e.SeguPerfil)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .HasMany(e => e.SeguLogin)
                .WithRequired(e => e.SeguPersona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SeguSession>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<SeguSession>()
                .Property(e => e.CodSession)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SeguSession>()
                .Property(e => e.IPSession)
                .IsUnicode(false);

            modelBuilder.Entity<Sentido>()
                .Property(e => e.CodSentido)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sentido>()
                .Property(e => e.Sentido1)
                .IsUnicode(false);

            modelBuilder.Entity<Sentido>()
                .HasMany(e => e.LOTE)
                .WithRequired(e => e.Sentido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Servicio1)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.CodEstatusServicio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.Autorizaciones)
                .WithRequired(e => e.Servicio)
                .HasForeignKey(e => new { e.CodMotivoLlamada, e.CodServicio })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicioGeneral>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioGeneral>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioGeneral>()
                .Property(e => e.Presion)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioGeneral>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioGeneral>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioGeneral>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioGeneral>()
                .HasMany(e => e.PaseEspecialista)
                .WithRequired(e => e.ServicioGeneral)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicioGeneral>()
                .HasMany(e => e.ServicioReferido)
                .WithRequired(e => e.ServicioGeneral)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ServicioReferido>()
                .Property(e => e.CIE)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioReferido>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioReferido>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioReferido>()
                .Property(e => e.Cantidad)
                .IsUnicode(false);

            modelBuilder.Entity<ServicioReferido>()
                .Property(e => e.medicamento)
                .IsUnicode(false);

            modelBuilder.Entity<SSA>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<SSA>()
                .Property(e => e.NoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SSR>()
                .Property(e => e.NoRecibo)
                .IsUnicode(false);

            modelBuilder.Entity<SSR>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<SSR>()
                .Property(e => e.NoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SSR>()
                .Property(e => e.CodEstatusPago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SSR>()
                .Property(e => e.NoLote)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodEspecialidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Subcategoria>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Subcategoria>()
                .HasMany(e => e.CatalogoEstudio)
                .WithRequired(e => e.Subcategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubEspecialidad>()
                .Property(e => e.CodEspecialidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SubEspecialidad>()
                .Property(e => e.SubEspecialidad1)
                .IsUnicode(false);

            modelBuilder.Entity<SubEspecialidad>()
                .HasMany(e => e.Proveedor)
                .WithRequired(e => e.SubEspecialidad)
                .HasForeignKey(e => new { e.CodEspecialidad, e.CodSubEspecialidad })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SubEspecialidad>()
                .HasMany(e => e.StaffMedico)
                .WithRequired(e => e.SubEspecialidad)
                .HasForeignKey(e => new { e.CodEspecialidad, e.CodSubEspecialidad })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Cuadros>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Especialidades>()
                .Property(e => e.DscEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Medicina_Preventiva>()
                .Property(e => e.PlanPreventivo)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Medicina_Preventiva>()
                .Property(e => e.ClavePlan)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Medicina_Preventiva>()
                .HasMany(e => e.Sys_Mediaccess_Estudios_Medicina_Preventiva)
                .WithRequired(e => e.Sys_Mediaccess_Cat_Medicina_Preventiva)
                .HasForeignKey(e => e.IdPlanPreventivo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Medicina_Preventiva>()
                .HasMany(e => e.Sys_Mediaccess_Rangos_Medicina_Preventiva)
                .WithOptional(e => e.Sys_Mediaccess_Cat_Medicina_Preventiva)
                .HasForeignKey(e => e.idPlanPreventivo);

            modelBuilder.Entity<sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios>()
                .Property(e => e.poliza)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.CodServicio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.PU)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.Total)
                .HasPrecision(12, 2);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_Producto_Autorizado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_SAB_AplicativoConsume>()
                .Property(e => e.Aplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_SAB_AplicativoConsume>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_SAB_MetodosWS>()
                .Property(e => e.DscMetodo)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_SAB_PerfilesWS>()
                .Property(e => e.DscPerfil)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.CODAFILIADO)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.ELEGIBILIDAD_INCORRECTA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.ELEGIBILIDAD_CORRECTA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.AUTORIZACION_INCORRECTA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.AUTORIZACION_CORRECTA)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.ARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.FOLIO)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.ESTUDIO)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.Elegibilidad2)
                .IsUnicode(false);

            modelBuilder.Entity<TABLARELACIOINFONAVIT>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.CodEspecialidad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.CodTipoTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.CodEstatusProcedimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.Codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.CostoUnitario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.CostoNeto)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.DerechoPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.RecargoPago)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.Agente)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.Promotora)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.Proyecto)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.Oficina)
                .IsUnicode(false);

            modelBuilder.Entity<TB_AfiliadoVentas>()
                .Property(e => e.DireccionComercialAg)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.OrigenLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.NombreQuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.CorreoQuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.TelQuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.Motivo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.Servicio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.HonorariosCirujano)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.HonorariosAnestesiologo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.HonorariosAyudante1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.HonorariosAyudante2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.deducible)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.CopagoEn)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.Siniestro)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.MotivoPendiente)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.DescripcionSiniestro)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.correoHospital)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.correoMedicoTratante)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.correoPaciente)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.MedDictaminador)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Programacion>()
                .Property(e => e.descripcionCirugia)
                .IsUnicode(false);

            modelBuilder.Entity<TB_REL_POLIZA_ENDOSOS>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_REL_POLIZA_ENDOSOS>()
                .Property(e => e.nombrecomercial)
                .IsUnicode(false);

            modelBuilder.Entity<TB_REL_POLIZA_ENDOSOS>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_REL_POLIZA_ENDOSOS>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_REL_POLIZA_ENDOSOS>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_REL_POLIZA_ENDOSOS>()
                .Property(e => e.Origen)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCliente>()
                .Property(e => e.TipoCliente1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoConsulta>()
                .Property(e => e.TipoConsulta1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContacto>()
                .Property(e => e.TipoContacto1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContacto>()
                .HasMany(e => e.ContactoAfiliado)
                .WithRequired(e => e.TipoContacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContacto>()
                .HasMany(e => e.ContactoEmpresa)
                .WithRequired(e => e.TipoContacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContacto>()
                .HasMany(e => e.ContactoProveedor)
                .WithRequired(e => e.TipoContacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContacto>()
                .HasMany(e => e.ContactoVendedor)
                .WithRequired(e => e.TipoContacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContribuyente>()
                .Property(e => e.TipoContribuyente1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContribuyente>()
                .HasMany(e => e.FacturaFranquicia)
                .WithRequired(e => e.TipoContribuyente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoContribuyente>()
                .HasMany(e => e.Proveedor)
                .WithRequired(e => e.TipoContribuyente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoCopago>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCopago>()
                .HasMany(e => e.Ficha_Tecnica)
                .WithRequired(e => e.TipoCopago)
                .HasForeignKey(e => e.Id_TipoCopago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoFormato>()
                .Property(e => e.CodTipoFormato)
                .IsUnicode(false);

            modelBuilder.Entity<TipoFormato>()
                .Property(e => e.TipoFormato1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoFormato>()
                .HasMany(e => e.FoliosFacturas)
                .WithRequired(e => e.TipoFormato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGasto>()
                .Property(e => e.TipoGasto1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoGasto>()
                .HasMany(e => e.CoverageFilter)
                .WithRequired(e => e.TipoGasto)
                .HasForeignKey(e => e.TipoGasto_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGasto>()
                .HasMany(e => e.Especialidad)
                .WithRequired(e => e.TipoGasto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoGastoCopago>()
                .Property(e => e.DescripcionGasto)
                .IsUnicode(false);

            modelBuilder.Entity<TipoGastoCopago>()
                .HasMany(e => e.Ficha_Tecnica)
                .WithRequired(e => e.TipoGastoCopago)
                .HasForeignKey(e => e.IdTipoGasto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoMovimientoEspecialidad>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoMovimientoEspecialidad>()
                .HasMany(e => e.MovimientosEspecialidad)
                .WithRequired(e => e.TipoMovimientoEspecialidad)
                .HasForeignKey(e => e.TipoMovimiento_Id);

            modelBuilder.Entity<TipoPago>()
                .Property(e => e.TipoPago1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoPago>()
                .HasMany(e => e.SSA)
                .WithRequired(e => e.TipoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoPago>()
                .HasMany(e => e.SSR)
                .WithRequired(e => e.TipoPago)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoResponsable>()
                .Property(e => e.TipoResponsable1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoResponsable>()
                .HasMany(e => e.FoliosFacturas)
                .WithRequired(e => e.TipoResponsable)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoServicioReferido>()
                .Property(e => e.ServicioReferido)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicioReferido>()
                .HasMany(e => e.ServicioReferido1)
                .WithRequired(e => e.TipoServicioReferido)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoTabulador>()
                .Property(e => e.CodTipoTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoTabulador>()
                .Property(e => e.TipoTabulador1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTabulador>()
                .HasMany(e => e.Procedimiento)
                .WithRequired(e => e.TipoTabulador)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoUbicacion>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoUbicacion>()
                .Property(e => e.TipoUbicacion1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUbicacion>()
                .HasMany(e => e.UbicacionAfiliado)
                .WithRequired(e => e.TipoUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoUbicacion>()
                .HasMany(e => e.UbicacionEmpresa)
                .WithRequired(e => e.TipoUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoUbicacion>()
                .HasMany(e => e.UbicacionProveedor)
                .WithRequired(e => e.TipoUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoUbicacion>()
                .HasMany(e => e.UbicacionVendedor)
                .WithRequired(e => e.TipoUbicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoVendedor>()
                .Property(e => e.TipoVendedor1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoVendedor>()
                .HasMany(e => e.Comision)
                .WithRequired(e => e.TipoVendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoVendedor>()
                .HasMany(e => e.Vendedor)
                .WithRequired(e => e.TipoVendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionEmpresa>()
                .Property(e => e.Horario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.HorarioAtencion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionProveedor>()
                .HasMany(e => e.ContactoProveedor)
                .WithRequired(e => e.UbicacionProveedor)
                .HasForeignKey(e => new { e.CodProveedor, e.CodUbicacion })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<UbicacionVendedor>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionVendedor>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionVendedor>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionVendedor>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionVendedor>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionVendedor>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.CodAfiliadoUnico)
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.cambioPassword)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.correo)
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.celular)
                .IsUnicode(false);

            modelBuilder.Entity<usuarioApp>()
                .Property(e => e.correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.NombreUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.ApellidoPaternoUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.ApellidoMaternoUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.NombreJefeInmediato)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.ApellidoPaternoJefeInmediato)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.ApellidoMaternoJefeInmediato)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.UsrAlta)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.UsrBaja)
                .IsUnicode(false);

            modelBuilder.Entity<UsuariosSistemas>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.NombreVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.CodVendedorSuperior)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .Property(e => e.SGClave)
                .IsUnicode(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.ContactoVendedor)
                .WithRequired(e => e.Vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.FolioMembresia)
                .WithRequired(e => e.Vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.UbicacionVendedor)
                .WithRequired(e => e.Vendedor)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vendedor>()
                .HasMany(e => e.Vendedor1)
                .WithOptional(e => e.Vendedor2)
                .HasForeignKey(e => e.CodVendedorSuperior);

            modelBuilder.Entity<ventasSistemaCartera>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ventasSistemaCartera>()
                .Property(e => e.comisionEn)
                .IsUnicode(false);

            modelBuilder.Entity<ventasSistemaCartera>()
                .Property(e => e.xusrCarga)
                .IsUnicode(false);

            modelBuilder.Entity<ventasSistemaCartera>()
                .Property(e => e.xsrModificacion)
                .IsUnicode(false);

            modelBuilder.Entity<ViaCarga>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<ViaCarga>()
                .Property(e => e.ViaCarga1)
                .IsUnicode(false);

            modelBuilder.Entity<ViaCarga>()
                .HasMany(e => e.Autorizaciones)
                .WithRequired(e => e.ViaCarga)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zona>()
                .Property(e => e.Zona1)
                .IsUnicode(false);

            modelBuilder.Entity<Zona>()
                .Property(e => e.Responsable)
                .IsUnicode(false);

            modelBuilder.Entity<Zona>()
                .HasMany(e => e.Poblacion)
                .WithRequired(e => e.Zona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<A_Afiliado_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.CodCalle)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.membresia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.plan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.idcontratante)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.afiliacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.producto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.cp)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.telefonos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.Recibo)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.Credencial)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.nombre_archivo)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.NuevoCodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<A_Mediaccess_Afiliado>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<A_UbicacionAfiliado>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios_Bajas>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios_Bajas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios_Bajas>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios_Bajas>()
                .Property(e => e.Usuario_I)
                .IsUnicode(false);

            modelBuilder.Entity<AE_Acceso_Usuarios_Bajas>()
                .Property(e => e.Usuario_U)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_log_BC>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_logM>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivo>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoBMX_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadoNAFINmasivo12062018>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliados_codEmpresa954>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliadosactualizacion_operaciones>()
                .Property(e => e.nomina)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliadosactualizacion_operaciones>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliadosactualizacion_operaciones>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadosAseguradora>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<AfiliadoSHFLOG>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtFolioContrato)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.lblNumProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbTipoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbSubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtNomFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtNomComercial)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtNombre)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtApPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtApMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtNomCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtRFC)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtCURP)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtObservaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbCodEstatusCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.cmbBanco)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtCuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtCLABE)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtCedulaProf)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtCedulaEsp)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtCertificacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtFechaCertificacion)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.chkIguala)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtImporteIguala)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtDescuentoPromSI)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtPrecioSerSI)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtPrecioSerMem)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.txtDescuentoMem)
                .IsUnicode(false);

            modelBuilder.Entity<ALZ_SASS_PV_CambioProveedores>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<AngendaCampañas>()
                .Property(e => e.Campaña)
                .IsUnicode(false);

            modelBuilder.Entity<AnotacionesExtras_LOG>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<AnotacionesExtras_LOG>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AnotacionesExtras_LOG>()
                .Property(e => e.FechaInsrt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<asignacionCoberturaGrupoEmpresa>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesConsultadas>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.QuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodMotivoQueja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.codMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.Observacion1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.Observacion2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaPaso>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Cat_Parentesco_Sicas>()
                .Property(e => e.codvalor)
                .IsUnicode(false);

            modelBuilder.Entity<Cat_Parentesco_Sicas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Cat_Parentesco_Sicas>()
                .Property(e => e.codEquivalencia)
                .IsUnicode(false);

            modelBuilder.Entity<CertificadoIncapacidad>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<CertificadoIncapacidad>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<CertificadoIncapacidad>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas>()
                .Property(e => e.Cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<Coberturas>()
                .Property(e => e.Descripcion)
                .IsFixedLength();

            modelBuilder.Entity<coberturasTipoGasto>()
                .Property(e => e.coaseguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaAut>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaAut>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CodTipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.RestoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.ApellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.ApellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.flgIguala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.SGPassword)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
                .Property(e => e.cedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaHist>()
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

            modelBuilder.Entity<DatosIvr>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.Compania)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.TipoSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.TipoPlan)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.inumpoliza)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.NumCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.TipoIdentifica)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.TipoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.Materno)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.FecNac)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.PolIniVig)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.PolFinVig)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.CodParent)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.NumeroEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.CodAsegurado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.IdAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.CodigoAgente)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.fechaproceso)
                .IsUnicode(false);

            modelBuilder.Entity<datosrpt>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.Compania)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.TipoSeguro)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.TipoPlan)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.inumpoliza)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.NumCertificado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.TipoIdentifica)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.TipoPersona)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.Paterno)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.Materno)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.FecNac)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.PolIniVig)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.PolFinVig)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.CodParent)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.NumeroEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.CodAsegurado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.IdAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.CodigoAgente)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.fechaproceso)
                .IsUnicode(false);

            modelBuilder.Entity<datosrptcmb>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.numPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codEstado)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.apellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.apellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.lada)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.telefonoCasa)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.telefonoCelular)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.sexo)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codAseguradora)
                .IsFixedLength();

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.codEmpPymeColectividad)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.vip)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Alta>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Baja>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Baja>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Baja>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Renovacion>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Renovacion>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Renovacion>()
                .Property(e => e.Error)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Afiliados_Renovacion>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Impresion_LogImpresion>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Impresion_LogImpresion>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Impresion_LogImpresion>()
                .Property(e => e.UserImpresion)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Producto>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Producto>()
                .Property(e => e.Campos)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Producto>()
                .Property(e => e.titulo)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Producto>()
                .Property(e => e.PFilas)
                .IsUnicode(false);

            modelBuilder.Entity<EMI_Tarjetas_Producto>()
                .Property(e => e.PColumnas)
                .IsUnicode(false);

            modelBuilder.Entity<empresaspymesicas>()
                .Property(e => e.nombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<empresaspymesicas>()
                .Property(e => e.nombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<empresaspymesicas>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAVIRTUAL>()
                .Property(e => e.CLAVECARGA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAVIRTUAL>()
                .Property(e => e.CODEMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAVIRTUAL>()
                .Property(e => e.POLIZA)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAVIRTUAL>()
                .Property(e => e.CODPYME)
                .IsUnicode(false);

            modelBuilder.Entity<EMPRESAVIRTUAL>()
                .Property(e => e.DESCRIPCION)
                .IsUnicode(false);

            modelBuilder.Entity<EnvioCorreosProcesos>()
                .Property(e => e.Correos)
                .IsUnicode(false);

            modelBuilder.Entity<estados>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<estados>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<estados>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<estados>()
                .Property(e => e.CodHSBC)
                .IsFixedLength();

            modelBuilder.Entity<Estatus_Cuenta>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Cuenta>()
                .Property(e => e.EstatusCuenta)
                .IsUnicode(false);

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

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_PRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_PLAN)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.DESCRIP)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.NOM_PRODUCTO)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.ORIGEN_TARIFA)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.ESTATUS)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COPAGO)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COPAGOEN)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.DEDUCIBLE__)
                .HasPrecision(10, 4);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_RED1)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_RED2)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_RED3)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.LIST_MED1)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.LIST_MED2)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.LIST_MED3)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.COD_ESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.LIMITE_SUPERIOR)
                .HasPrecision(10, 4);

            modelBuilder.Entity<FICHA_PRODUCTO>()
                .Property(e => e.LIMITE_INFERIOR)
                .HasPrecision(10, 4);

            modelBuilder.Entity<Ficha_Tecnica_3>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Ficha_Tecnica_3>()
                .Property(e => e.Especificaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Ficha_Tecnica151221>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<Ficha_Tecnica151221>()
                .Property(e => e.Especificaciones)
                .IsUnicode(false);

            modelBuilder.Entity<grupos>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<grupos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<hospitalcede>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.CodServicio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.PU)
                .HasPrecision(12, 2);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.Total)
                .HasPrecision(12, 2);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<iss_sys_mediaccess_producto_autorizado>()
                .Property(e => e.Descripcion)
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

            modelBuilder.Entity<PEMEX_CE_CuentaHistProcesados>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.TelResponsable)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.EmailResp)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.SupervicionSec)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.NombreCordMed)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.ApatCordMed)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.AmatCordMed)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.EmailCordMed)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.TelCordMed)
                .IsUnicode(false);

            modelBuilder.Entity<PEMEX_CE_DatosAdicionalesProveedor>()
                .Property(e => e.CelCordMed)
                .IsUnicode(false);

            modelBuilder.Entity<PolizasOxxo>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<PolizasOxxo>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<PolizasOxxo>()
                .Property(e => e.SN_Activo)
                .IsUnicode(false);

            modelBuilder.Entity<PolizasOxxo>()
                .Property(e => e.MaxFolioCerti)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesosCorreos>()
                .Property(e => e.Proceso)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesosCorreos>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto_log>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<Producto_log>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Producto_log>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Producto_log>()
                .Property(e => e.xusrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Producto_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<productofalta>()
                .Property(e => e.codproducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductoImpresion>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProductoImpresion>()
                .Property(e => e.Producto)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoImpresion>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ProductoxClasificacion>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<RepEmailEstatus_TB>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<RepEmailLog_TB>()
                .Property(e => e.Excel)
                .IsUnicode(false);

            modelBuilder.Entity<RepEmailLog_TB>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<retroactivas>()
                .Property(e => e.MSGValida)
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

            modelBuilder.Entity<SYS_Mediacces_EstadoCuenta_Agrupa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediacces_Formato>()
                .Property(e => e.Formato)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediacces_Formato>()
                .Property(e => e.Columnas)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediacces_Formato>()
                .Property(e => e.Tabla)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediacces_Formato>()
                .Property(e => e.Sqlcmd)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediacces_Formato>()
                .Property(e => e.Parametros)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Afiliados_Consulta_RedMedica>()
                .Property(e => e.AfiliadoComodin)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Afiliados_Consulta_RedMedica>()
                .Property(e => e.codproducto)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Afiliados_Consulta_RedMedica>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Afiliados_Consulta_RedMedica>()
                .Property(e => e.UsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Grupo_Medicina_Preventiva>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Oftalmologia>()
                .Property(e => e.Concepto)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_Oftalmologia>()
                .Property(e => e.Reglas)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_cat_producto_rangos_Medicina_Preventiva>()
                .Property(e => e.UsrAlta)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Cat_TipoEmpleado>()
                .Property(e => e.TipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Estudios_Medicina_Preventiva>()
                .Property(e => e.Estudio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios_log>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios_log>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios_log>()
                .Property(e => e.poliza)
                .HasPrecision(10, 0);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios_log>()
                .Property(e => e.xusrinsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Medicina_Preventiva_Folios_log>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.MioIzq)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.MioDer)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.Hipizq)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.HipDer)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.AstIz)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.AstDer)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.EjeIzq)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.EjeDer)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.AdiIzq)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.AdiDer)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Diagnostico_Log_historico>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_MediAccess_Oftalmologia_Servicios_Log_hISTORICO>()
                .Property(e => e.Observaciones)
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

            modelBuilder.Entity<SYS_Mediaccess_Pyme_Colectiva>()
                .Property(e => e.nombreFiscal)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Rangos_Medicina_Preventiva>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Rangos_Medicina_Preventiva>()
                .Property(e => e.codproducto)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Rangos_Medicina_Preventiva>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Rangos_Medicina_Preventiva_anterior>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_log>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Medired_AfiliadosABC_logMasivo>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_RE_Clinica_Catalogo>()
                .Property(e => e.CodTipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_SICAS_Endosos>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<SysMediaccess_LogMP>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<SysMediaccess_LogMP>()
                .Property(e => e.Operacion)
                .IsUnicode(false);

            modelBuilder.Entity<SysMediaccess_LogMP>()
                .Property(e => e.Formato)
                .IsUnicode(false);

            modelBuilder.Entity<SysMediaccess_LogMP>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<SysMediaccess_LogMP>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<TB_CONFPAMMODULARDET>()
                .Property(e => e.Codproducto)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Endosos_PDF>()
                .Property(e => e.Endoso)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Endosos_PDF>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Endosos_PDF>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Endosos_PDF>()
                .Property(e => e.Codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Endosos_PDF>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Endosos_PDF>()
                .Property(e => e.UsuarioCarga)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PolizasAdssyf>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PolizasAdssyf>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_PolizasAdssyf>()
                .Property(e => e.idPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ProgramacionDoc>()
                .Property(e => e.Id)
                .IsFixedLength();

            modelBuilder.Entity<TB_WS_AfiliadosSICAS>()
                .Property(e => e.cadenaentrada)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICAS>()
                .Property(e => e.cadenasalida)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICAS>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASABC_log>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASB>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.Movimiento)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.UsuarioProceso)
                .IsUnicode(false);

            modelBuilder.Entity<TB_WS_AfiliadosSICASC>()
                .Property(e => e.MSGValida)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchCodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.iCodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchCodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchColonia)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchDireccion)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchCodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchNombres)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchEmail)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchTelefonoCasa)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchSexo)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchFechaNacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchFechaInicioServicio)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchFechaFinServicio)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.iCodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchFechaInicioSeg)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchFechaFinSeg)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchVip)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchFecAntiguedad)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchestatus)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.vchNumSocio)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.iClasificacion)
                .IsUnicode(false);

            modelBuilder.Entity<TBAFILAFICASNP>()
                .Property(e => e.MsgError)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.TipoCuenta1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoExamen>()
                .Property(e => e.TipExaDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoExamen>()
                .Property(e => e.Notas)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<tmp_afiliado_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado_log>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivo>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacionafiliadoBancomextmasivoRESULTADO>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoMasivo>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliadoNAFINMasivo12062018>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.Domicilio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.CodPais)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliados_codEmpresa954>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario_Asig_Sistema>()
                .Property(e => e.UsrAltaAsignacion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario_Asig_Sistema>()
                .Property(e => e.UsrBajaAsignacion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario_Asig_Sistema>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ValElegibilidad>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ValElegibilidad>()
                .Property(e => e.Codtipocuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ValElegibilidad>()
                .Property(e => e.xUsrtInsert)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Clave_de_afiliado)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Póliza)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.RFC_Documento)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Apellido_paterno)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Apellido_materno)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Teléfono)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Teléfono_2)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Dirección)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Marca)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Modelo)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Año_vehículo)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Chasis)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Placa)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Peso)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Color_vehículo)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.tipo_vehículo)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.ID_cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.ID_plan)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Observación_especial)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Correo_electrónico)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Localidad)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Codigo_Postal)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Beneficiario)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Nombre_Mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Especie_Mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Sexo_Mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Raza_mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Color_mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Año_mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Meses_mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.Señas_mascota)
                .IsUnicode(false);

            modelBuilder.Entity<vLayoutAfiliadosSass_Log>()
                .Property(e => e.USR)
                .IsUnicode(false);

            modelBuilder.Entity<Xmlcadena>()
                .Property(e => e.proceso)
                .IsUnicode(false);
        }
    }
}
