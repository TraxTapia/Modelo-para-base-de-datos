using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.macmedi
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context8")
        {
        }

        public virtual DbSet<ACLARACION> ACLARACION { get; set; }
        public virtual DbSet<ACLARACION_QUEJA> ACLARACION_QUEJA { get; set; }
        public virtual DbSet<ACLARACION_SEGUIMIENTO> ACLARACION_SEGUIMIENTO { get; set; }
        public virtual DbSet<Afiliado> Afiliado { get; set; }
        public virtual DbSet<ausentismo> ausentismo { get; set; }
        public virtual DbSet<AutorizacionEspecial> AutorizacionEspecial { get; set; }
        public virtual DbSet<AutorizacionEspecialDetalle> AutorizacionEspecialDetalle { get; set; }
        public virtual DbSet<BandejaEntrada> BandejaEntrada { get; set; }
        public virtual DbSet<BandejaEntradaLog> BandejaEntradaLog { get; set; }
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<CatAplicacion> CatAplicacion { get; set; }
        public virtual DbSet<CatArchivos> CatArchivos { get; set; }
        public virtual DbSet<CF_GEN_ERROR_LOG> CF_GEN_ERROR_LOG { get; set; }
        public virtual DbSet<CLAVE_AFILIADO> CLAVE_AFILIADO { get; set; }
        public virtual DbSet<ConsultaElectronicaCitas> ConsultaElectronicaCitas { get; set; }
        public virtual DbSet<ConsultaElectronicaClinicas> ConsultaElectronicaClinicas { get; set; }
        public virtual DbSet<ConsultaElectronicaFarmacias> ConsultaElectronicaFarmacias { get; set; }
        public virtual DbSet<ConsultaElectronicaHSA> ConsultaElectronicaHSA { get; set; }
        public virtual DbSet<ConsultaElectronicaHSACodigoBarras> ConsultaElectronicaHSACodigoBarras { get; set; }
        public virtual DbSet<ConsultaElectronicaHSANoFacturado> ConsultaElectronicaHSANoFacturado { get; set; }
        public virtual DbSet<CPT4> CPT4 { get; set; }
        public virtual DbSet<Cuenta> Cuenta { get; set; }
        public virtual DbSet<CuentaLogin> CuentaLogin { get; set; }
        public virtual DbSet<CuentaLoginVersion> CuentaLoginVersion { get; set; }
        public virtual DbSet<CuentaReglas> CuentaReglas { get; set; }
        public virtual DbSet<CuentaSession> CuentaSession { get; set; }
        public virtual DbSet<Cuestionario> Cuestionario { get; set; }
        public virtual DbSet<DiagnosisCode> DiagnosisCode { get; set; }
        public virtual DbSet<Diagnostico> Diagnostico { get; set; }
        public virtual DbSet<DocumentosPorAplicacion> DocumentosPorAplicacion { get; set; }
        public virtual DbSet<Empresa> Empresa { get; set; }
        public virtual DbSet<Error_Log_SQL> Error_Log_SQL { get; set; }
        public virtual DbSet<Especialidad> Especialidad { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Estatus_Afiliado> Estatus_Afiliado { get; set; }
        public virtual DbSet<Estatus_Bandeja> Estatus_Bandeja { get; set; }
        public virtual DbSet<Estatus_ConsultaElectronica> Estatus_ConsultaElectronica { get; set; }
        public virtual DbSet<EstatusCuentaProveedor> EstatusCuentaProveedor { get; set; }
        public virtual DbSet<filesProveedores> filesProveedores { get; set; }
        public virtual DbSet<FolioXIdGastosCoberturaDetalle> FolioXIdGastosCoberturaDetalle { get; set; }
        public virtual DbSet<GastoCoberturasDetalleObservaciones> GastoCoberturasDetalleObservaciones { get; set; }
        public virtual DbSet<GastoMedicamentos> GastoMedicamentos { get; set; }
        public virtual DbSet<GpoCuestionario> GpoCuestionario { get; set; }
        public virtual DbSet<LlamadaSeguimiento> LlamadaSeguimiento { get; set; }
        public virtual DbSet<LlamadaServicio> LlamadaServicio { get; set; }
        public virtual DbSet<LlamadaTipoMotivo> LlamadaTipoMotivo { get; set; }
        public virtual DbSet<LogControlGasto> LogControlGasto { get; set; }
        public virtual DbSet<LogControlGastoManual> LogControlGastoManual { get; set; }
        public virtual DbSet<LogControlGastoMedikit> LogControlGastoMedikit { get; set; }
        public virtual DbSet<MedicinePreventiveInfonavit> MedicinePreventiveInfonavit { get; set; }
        public virtual DbSet<MedicosObispado> MedicosObispado { get; set; }
        public virtual DbSet<MotivoLlamada> MotivoLlamada { get; set; }
        public virtual DbSet<Parentesco> Parentesco { get; set; }
        public virtual DbSet<Poblacion> Poblacion { get; set; }
        public virtual DbSet<Pregunta> Pregunta { get; set; }
        public virtual DbSet<ProcedimientosRecetaElectronica> ProcedimientosRecetaElectronica { get; set; }
        public virtual DbSet<ProcesaPagos> ProcesaPagos { get; set; }
        public virtual DbSet<ProcesaPagosCodigoBarras> ProcesaPagosCodigoBarras { get; set; }
        public virtual DbSet<PRODUCTO> PRODUCTO { get; set; }
        public virtual DbSet<producto_tabulador> producto_tabulador { get; set; }
        public virtual DbSet<ProveedorCertificado> ProveedorCertificado { get; set; }
        public virtual DbSet<Red> Red { get; set; }
        public virtual DbSet<Regla> Regla { get; set; }
        public virtual DbSet<Respuesta> Respuesta { get; set; }
        public virtual DbSet<RespuestasCoordinacion> RespuestasCoordinacion { get; set; }
        public virtual DbSet<RestitucionSumasAseguradas> RestitucionSumasAseguradas { get; set; }
        public virtual DbSet<SamiEspecialidad> SamiEspecialidad { get; set; }
        public virtual DbSet<SamiEstado> SamiEstado { get; set; }
        public virtual DbSet<SamiZona> SamiZona { get; set; }
        public virtual DbSet<SeguLogin> SeguLogin { get; set; }
        public virtual DbSet<SeguPersona> SeguPersona { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<subEspecialidad> subEspecialidad { get; set; }
        public virtual DbSet<SYS_Mediaccess_RED_Cuenta> SYS_Mediaccess_RED_Cuenta { get; set; }
        public virtual DbSet<SYS_Mediaccess_RED_Cuenta_Log> SYS_Mediaccess_RED_Cuenta_Log { get; set; }
        public virtual DbSet<Sys_Mediaccess_WS> Sys_Mediaccess_WS { get; set; }
        public virtual DbSet<Sys_Mediaccess_WS_AplicativoConsume> Sys_Mediaccess_WS_AplicativoConsume { get; set; }
        public virtual DbSet<SYS_Mediaccess_WS_Usuarios> SYS_Mediaccess_WS_Usuarios { get; set; }
        public virtual DbSet<Tabulador> Tabulador { get; set; }
        public virtual DbSet<TabuladorClinicas> TabuladorClinicas { get; set; }
        public virtual DbSet<TabuladorConsulta> TabuladorConsulta { get; set; }
        public virtual DbSet<TabuladorCPT> TabuladorCPT { get; set; }
        public virtual DbSet<TabuladorEspecial> TabuladorEspecial { get; set; }
        public virtual DbSet<TabuladorEspecialidadPoblacion> TabuladorEspecialidadPoblacion { get; set; }
        public virtual DbSet<TabuladorPoblacion> TabuladorPoblacion { get; set; }
        public virtual DbSet<TB_HistClin_Asma> TB_HistClin_Asma { get; set; }
        public virtual DbSet<TipoCuenta> TipoCuenta { get; set; }
        public virtual DbSet<TipoGasto> TipoGasto { get; set; }
        public virtual DbSet<TipoLlamada> TipoLlamada { get; set; }
        public virtual DbSet<TipoPersona> TipoPersona { get; set; }
        public virtual DbSet<Ubicacion> Ubicacion { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<WsLogger> WsLogger { get; set; }
        public virtual DbSet<ContactoAfiliado> ContactoAfiliado { get; set; }
        public virtual DbSet<DescripcionTipoExamen1> DescripcionTipoExamen1 { get; set; }
        public virtual DbSet<TB_Asma> TB_Asma { get; set; }
        public virtual DbSet<TB_Cardiopatia> TB_Cardiopatia { get; set; }
        public virtual DbSet<TB_Diabetes> TB_Diabetes { get; set; }
        public virtual DbSet<TB_Fichas> TB_Fichas { get; set; }
        public virtual DbSet<TB_Hipertension> TB_Hipertension { get; set; }
        public virtual DbSet<TB_Vejez> TB_Vejez { get; set; }
        public virtual DbSet<TipoContacto> TipoContacto { get; set; }
        public virtual DbSet<TipoUbicacion1> TipoUbicacion1 { get; set; }
        public virtual DbSet<UbicacionAfiliado> UbicacionAfiliado { get; set; }
        public virtual DbSet<GastoCoberturas> GastoCoberturas { get; set; }
        public virtual DbSet<GastoCoberturasDetalle> GastoCoberturasDetalle { get; set; }
        public virtual DbSet<GastoCoberturasDetalleAuxiliar> GastoCoberturasDetalleAuxiliar { get; set; }
        public virtual DbSet<ACLARACION_BANDEJA> ACLARACION_BANDEJA { get; set; }
        public virtual DbSet<Afiliado_HSBC> Afiliado_HSBC { get; set; }
        public virtual DbSet<AFQualitas> AFQualitas { get; set; }
        public virtual DbSet<AIG> AIG { get; set; }
        public virtual DbSet<asignacionCoberturaGrupoEmpresa> asignacionCoberturaGrupoEmpresa { get; set; }
        public virtual DbSet<Autorizacion_log> Autorizacion_log { get; set; }
        public virtual DbSet<Autorizaciones> Autorizaciones { get; set; }
        public virtual DbSet<Autorizaciones_Duplicadas> Autorizaciones_Duplicadas { get; set; }
        public virtual DbSet<Autorizaciones_log> Autorizaciones_log { get; set; }
        public virtual DbSet<Autorizaciones_logNafinyBancomext> Autorizaciones_logNafinyBancomext { get; set; }
        public virtual DbSet<Banco> Banco { get; set; }
        public virtual DbSet<BandejaEntrada_Log> BandejaEntrada_Log { get; set; }
        public virtual DbSet<BandejaEntrada_pruebas> BandejaEntrada_pruebas { get; set; }
        public virtual DbSet<BandejaEntradaEM> BandejaEntradaEM { get; set; }
        public virtual DbSet<BandejaEntradaRespaldo> BandejaEntradaRespaldo { get; set; }
        public virtual DbSet<BanruralCiudades> BanruralCiudades { get; set; }
        public virtual DbSet<coberturasTipoGasto> coberturasTipoGasto { get; set; }
        public virtual DbSet<ConfiguraEspecialidadCuenta> ConfiguraEspecialidadCuenta { get; set; }
        public virtual DbSet<ConsultaElectronicaCitasLOG> ConsultaElectronicaCitasLOG { get; set; }
        public virtual DbSet<ConsultaElectronicaConvenios> ConsultaElectronicaConvenios { get; set; }
        public virtual DbSet<ConsultaElectronicaHSA_log> ConsultaElectronicaHSA_log { get; set; }
        public virtual DbSet<consultaElectronicaHSA_sase> consultaElectronicaHSA_sase { get; set; }
        public virtual DbSet<ConsultaElectronicaHSADetalle> ConsultaElectronicaHSADetalle { get; set; }
        public virtual DbSet<ConsultaElectronicaHSADetalle_log> ConsultaElectronicaHSADetalle_log { get; set; }
        public virtual DbSet<consultaElectronicaHSADetalle_sase> consultaElectronicaHSADetalle_sase { get; set; }
        public virtual DbSet<ConsultaElectronicaHSAPendientesmodificar> ConsultaElectronicaHSAPendientesmodificar { get; set; }
        public virtual DbSet<Contacto> Contacto { get; set; }
        public virtual DbSet<ContactoLOG> ContactoLOG { get; set; }
        public virtual DbSet<Cuenta_respNoBorrar> Cuenta_respNoBorrar { get; set; }
        public virtual DbSet<CuentaLOG> CuentaLOG { get; set; }
        public virtual DbSet<DatosIvr_Duplicadas> DatosIvr_Duplicadas { get; set; }
        public virtual DbSet<DescripcionTipoExamen> DescripcionTipoExamen { get; set; }
        public virtual DbSet<Documento> Documento { get; set; }
        public virtual DbSet<dtproperties> dtproperties { get; set; }
        public virtual DbSet<EdicionCierre> EdicionCierre { get; set; }
        public virtual DbSet<EmpresasSAMI> EmpresasSAMI { get; set; }
        public virtual DbSet<EncabezadoListasNafin> EncabezadoListasNafin { get; set; }
        public virtual DbSet<Escolaridad> Escolaridad { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<Estatus_Cuenta> Estatus_Cuenta { get; set; }
        public virtual DbSet<Estatus_Factura> Estatus_Factura { get; set; }
        public virtual DbSet<Estatus_Remesa> Estatus_Remesa { get; set; }
        public virtual DbSet<Facturas> Facturas { get; set; }
        public virtual DbSet<FacturasLOG> FacturasLOG { get; set; }
        public virtual DbSet<Folios> Folios { get; set; }
        public virtual DbSet<Folios_ECE_1JUL22_18MAY23> Folios_ECE_1JUL22_18MAY23 { get; set; }
        public virtual DbSet<FoliosenECE> FoliosenECE { get; set; }
        public virtual DbSet<formapago> formapago { get; set; }
        public virtual DbSet<GastoMedicamentosDetalle> GastoMedicamentosDetalle { get; set; }
        public virtual DbSet<Grupo> Grupo { get; set; }
        public virtual DbSet<Grupo_Empresa> Grupo_Empresa { get; set; }
        public virtual DbSet<grupos> grupos { get; set; }
        public virtual DbSet<GuiaForanea> GuiaForanea { get; set; }
        public virtual DbSet<Incapacidades> Incapacidades { get; set; }
        public virtual DbSet<ListadoPrecios> ListadoPrecios { get; set; }
        public virtual DbSet<MetodoPago> MetodoPago { get; set; }
        public virtual DbSet<MotivoDetencion> MotivoDetencion { get; set; }
        public virtual DbSet<MotivoDevolucion> MotivoDevolucion { get; set; }
        public virtual DbSet<MotivoQueja> MotivoQueja { get; set; }
        public virtual DbSet<motivov> motivov { get; set; }
        public virtual DbSet<NotasCredito> NotasCredito { get; set; }
        public virtual DbSet<PaseEspecialistaPrimer> PaseEspecialistaPrimer { get; set; }
        public virtual DbSet<PaseEspecialistaSegundo> PaseEspecialistaSegundo { get; set; }
        public virtual DbSet<planes> planes { get; set; }
        public virtual DbSet<Poblacion_log> Poblacion_log { get; set; }
        public virtual DbSet<Procedimiento> Procedimiento { get; set; }
        public virtual DbSet<ProcesaPagosDetalle> ProcesaPagosDetalle { get; set; }
        public virtual DbSet<productoNvoECE_> productoNvoECE_ { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<RecepcionFactura> RecepcionFactura { get; set; }
        public virtual DbSet<Recursos_Medicos> Recursos_Medicos { get; set; }
        public virtual DbSet<Red_Cuenta> Red_Cuenta { get; set; }
        public virtual DbSet<red_cuenta_> red_cuenta_ { get; set; }
        public virtual DbSet<Red_Empresa> Red_Empresa { get; set; }
        public virtual DbSet<Redescpt_SAE> Redescpt_SAE { get; set; }
        public virtual DbSet<Remesas> Remesas { get; set; }
        public virtual DbSet<ReporteProveedores> ReporteProveedores { get; set; }
        public virtual DbSet<ReporteProveedores_nafin> ReporteProveedores_nafin { get; set; }
        public virtual DbSet<Requisitos> Requisitos { get; set; }
        public virtual DbSet<Respuesta_Coordinador> Respuesta_Coordinador { get; set; }
        public virtual DbSet<Revisacopago> Revisacopago { get; set; }
        public virtual DbSet<SeguimientoLlamada> SeguimientoLlamada { get; set; }
        public virtual DbSet<SeguPerfil> SeguPerfil { get; set; }
        public virtual DbSet<SeguSession> SeguSession { get; set; }
        public virtual DbSet<ServiciosenCoberturaXAfiliado> ServiciosenCoberturaXAfiliado { get; set; }
        public virtual DbSet<Sys_Mediaccess_ServicioWebMedicamentosFALog> Sys_Mediaccess_ServicioWebMedicamentosFALog { get; set; }
        public virtual DbSet<TabuladorFarmacia> TabuladorFarmacia { get; set; }
        public virtual DbSet<TabuladorProveedor> TabuladorProveedor { get; set; }
        public virtual DbSet<TB_EDO_HSBC> TB_EDO_HSBC { get; set; }
        public virtual DbSet<TB_ESPEC_HSBC> TB_ESPEC_HSBC { get; set; }
        public virtual DbSet<TipoExamen> TipoExamen { get; set; }
        public virtual DbSet<TipoFactura> TipoFactura { get; set; }
        public virtual DbSet<TipoUbicacion> TipoUbicacion { get; set; }
        public virtual DbSet<tmpReporteProveedores> tmpReporteProveedores { get; set; }
        public virtual DbSet<Ubicacion_respNoBorrar> Ubicacion_respNoBorrar { get; set; }
        public virtual DbSet<UbicacionLOG> UbicacionLOG { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }
        public virtual DbSet<DatosIvr> DatosIvr { get; set; }
        public virtual DbSet<DatosIvr_log> DatosIvr_log { get; set; }
        public virtual DbSet<DatosIvr_LOGNafinyBancomext> DatosIvr_LOGNafinyBancomext { get; set; }
        public virtual DbSet<DatosIvr_LOGSAELYF> DatosIvr_LOGSAELYF { get; set; }
        public virtual DbSet<datosivrBCKnoBANCOMEXnafin> datosivrBCKnoBANCOMEXnafin { get; set; }
        public virtual DbSet<datosivrbk250618> datosivrbk250618 { get; set; }
        public virtual DbSet<HSBCAfiliado> HSBCAfiliado { get; set; }
        public virtual DbSet<Incapacidades1> Incapacidades1 { get; set; }
        public virtual DbSet<nomina> nomina { get; set; }
        public virtual DbSet<Recibo> Recibo { get; set; }
        public virtual DbSet<Recursos_Medicos1> Recursos_Medicos1 { get; set; }
        public virtual DbSet<RedCuenta10102006> RedCuenta10102006 { get; set; }
        public virtual DbSet<RedCuenta18082006> RedCuenta18082006 { get; set; }
        public virtual DbSet<Registros> Registros { get; set; }
        public virtual DbSet<Seguimiento_coordinadores> Seguimiento_coordinadores { get; set; }
        public virtual DbSet<afiliadosSisnova243_> afiliadosSisnova243_ { get; set; }
        public virtual DbSet<autorizaciones_> autorizaciones_ { get; set; }
        public virtual DbSet<cubiertos_> cubiertos_ { get; set; }
        public virtual DbSet<distribucionCorreosIncapacidades> distribucionCorreosIncapacidades { get; set; }
        public virtual DbSet<elegibilidades2012_> elegibilidades2012_ { get; set; }
        public virtual DbSet<GastoCoberturasbkSICAS> GastoCoberturasbkSICAS { get; set; }
        public virtual DbSet<GastoCoberturasDetalle_> GastoCoberturasDetalle_ { get; set; }
        public virtual DbSet<GastoCoberturasDetalleLog> GastoCoberturasDetalleLog { get; set; }
        public virtual DbSet<GastoCoberturasLog> GastoCoberturasLog { get; set; }
        public virtual DbSet<medicamentos_> medicamentos_ { get; set; }
        public virtual DbSet<MovimientosRedes> MovimientosRedes { get; set; }
        public virtual DbSet<PasoCargaImpresion> PasoCargaImpresion { get; set; }
        public virtual DbSet<procesoClinicas_> procesoClinicas_ { get; set; }
        public virtual DbSet<proveedores_> proveedores_ { get; set; }
        public virtual DbSet<proveedoresMicrosip_> proveedoresMicrosip_ { get; set; }
        public virtual DbSet<StaffMedico> StaffMedico { get; set; }
        public virtual DbSet<sumasporempresa_> sumasporempresa_ { get; set; }
        public virtual DbSet<temporal> temporal { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ACLARACION>()
                .Property(e => e.CodProveedor)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION>()
                .Property(e => e.NoFacturas)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION>()
                .Property(e => e.Antecedente)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION>()
                .Property(e => e.Problema)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION>()
                .Property(e => e.Solucion)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_QUEJA>()
                .Property(e => e.QuejaAclaracion)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_SEGUIMIENTO>()
                .Property(e => e.usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_SEGUIMIENTO>()
                .Property(e => e.seguimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodCalle)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.membresia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.plan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.idcontratante)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.afiliacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.producto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.cp)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.telefonos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Recibo)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Credencial)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.nombre_archivo)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.NuevoCodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<ausentismo>()
                .Property(e => e.codMotivo)
                .IsFixedLength();

            modelBuilder.Entity<ausentismo>()
                .Property(e => e.motivo)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionEspecial>()
                .Property(e => e.IdAutorizaion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AutorizacionEspecial>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionEspecial>()
                .Property(e => e.CodTipoValidacion)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionEspecial>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionEspecial>()
                .HasMany(e => e.AutorizacionEspecialDetalle)
                .WithRequired(e => e.AutorizacionEspecial)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<AutorizacionEspecialDetalle>()
                .Property(e => e.IdDetalle)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AutorizacionEspecialDetalle>()
                .Property(e => e.IdAutorizaion)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AutorizacionEspecialDetalle>()
                .Property(e => e.MensajeValidacion)
                .IsUnicode(false);

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

            modelBuilder.Entity<BandejaEntrada>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.QuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodMotivoQueja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.codMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.Observacion1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.Observacion2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaLog>()
                .Property(e => e.Operacion)
                .IsFixedLength();

            modelBuilder.Entity<Cargos>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<CatAplicacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatAplicacion>()
                .HasMany(e => e.DocumentosPorAplicacion)
                .WithRequired(e => e.CatAplicacion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CatArchivos>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CatArchivos>()
                .HasMany(e => e.filesProveedores)
                .WithRequired(e => e.CatArchivos)
                .HasForeignKey(e => e.IdCatFiles)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.Id_Evento)
                .HasPrecision(9, 0);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.CVE_APLICACION)
                .IsUnicode(false);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.PROGRAMA)
                .IsUnicode(false);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.MENSAJE)
                .IsUnicode(false);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.TIPO_EXCEPCION)
                .IsUnicode(false);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.ERROR_TRACE)
                .IsUnicode(false);

            modelBuilder.Entity<CF_GEN_ERROR_LOG>()
                .Property(e => e.CODIGO_USUARIO)
                .IsUnicode(false);

            modelBuilder.Entity<CLAVE_AFILIADO>()
                .Property(e => e.CODAFILIADO)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.CodCuenta)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitas>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaClinicas>()
                .Property(e => e.Clinica)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaClinicas>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaClinicas>()
                .Property(e => e.CodTipoClinica)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaFarmacias>()
                .Property(e => e.Farmacia)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico2)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico3)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico4)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.DigChk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.NombrePacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.APaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.AMaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.AutorizacionLab)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.Autorizacion4to)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.AutorizacionEsp)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSACodigoBarras>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSANoFacturado>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSANoFacturado>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSANoFacturado>()
                .Property(e => e.cpt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSANoFacturado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSANoFacturado>()
                .Property(e => e.codtabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CPT4>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<CPT4>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CPT4>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

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

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.SYS_Mediaccess_RED_Cuenta)
                .WithRequired(e => e.Cuenta)
                .HasForeignKey(e => e.CodCuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.SYS_Mediaccess_RED_Cuenta_Log)
                .WithRequired(e => e.Cuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.SYS_Mediaccess_RED_Cuenta1)
                .WithRequired(e => e.Cuenta1)
                .HasForeignKey(e => e.CodCuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.CuentaReglas)
                .WithRequired(e => e.Cuenta)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.MedicinePreventiveInfonavit)
                .WithRequired(e => e.Cuenta)
                .HasForeignKey(e => e.CodeProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Cuenta>()
                .HasMany(e => e.MedicinePreventiveInfonavit1)
                .WithRequired(e => e.Cuenta1)
                .HasForeignKey(e => e.GenericCodeProvider)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CuentaLogin>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLogin>()
                .Property(e => e.SitUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLogin>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLogin>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLogin>()
                .HasMany(e => e.CuentaLoginVersion)
                .WithRequired(e => e.CuentaLogin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CuentaLogin>()
                .HasMany(e => e.CuentaSession)
                .WithRequired(e => e.CuentaLogin)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CuentaLoginVersion>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLoginVersion>()
                .Property(e => e.SitUsuario)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLoginVersion>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaReglas>()
                .Property(e => e.CodRegla)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaReglas>()
                .Property(e => e.Valor)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaSession>()
                .Property(e => e.IdSession)
                .HasPrecision(9, 0);

            modelBuilder.Entity<CuentaSession>()
                .Property(e => e.IPSession)
                .IsUnicode(false);

            modelBuilder.Entity<Cuestionario>()
                .Property(e => e.nom_cues)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<DiagnosisCode>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<DiagnosisCode>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.CodDiagnostico)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Diagnostico>()
                .Property(e => e.Diagnostico1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Empresa1)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.NombreLargo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CodEstatusEmpresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Rfc)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.CodPoblacion)
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
                .Property(e => e.Correo)
                .IsUnicode(false);

            modelBuilder.Entity<Empresa>()
                .Property(e => e.tipoprod)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Especialidad>()
                .Property(e => e.TipoCosto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.Estado1)
                .IsUnicode(false);

            modelBuilder.Entity<Estado>()
                .Property(e => e.codhsbc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Afiliado>()
                .Property(e => e.EstatusAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Afiliado>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Bandeja>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Bandeja>()
                .Property(e => e.EstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_ConsultaElectronica>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_ConsultaElectronica>()
                .Property(e => e.EstatusConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusCuentaProveedor>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<EstatusCuentaProveedor>()
                .HasMany(e => e.CuentaLogin)
                .WithRequired(e => e.EstatusCuentaProveedor)
                .HasForeignKey(e => e.IdEstatus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<filesProveedores>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<filesProveedores>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<filesProveedores>()
                .Property(e => e.Archivo)
                .IsUnicode(false);

            modelBuilder.Entity<filesProveedores>()
                .HasMany(e => e.DocumentosPorAplicacion)
                .WithRequired(e => e.filesProveedores)
                .HasForeignKey(e => e.IdDocumento)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<FolioXIdGastosCoberturaDetalle>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<FolioXIdGastosCoberturaDetalle>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<FolioXIdGastosCoberturaDetalle>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleObservaciones>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleObservaciones>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentos>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentos>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentos>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentos>()
                .Property(e => e.TipoConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentos>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentos>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<GpoCuestionario>()
                .Property(e => e.nom_gpo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GpoCuestionario>()
                .Property(e => e.des_gpo)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaSeguimiento>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaSeguimiento>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaSeguimiento>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaServicio>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaServicio>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaServicio>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaTipoMotivo>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<LlamadaTipoMotivo>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGasto>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGasto>()
                .Property(e => e.CodProcedimientoInicial)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGasto>()
                .Property(e => e.CodProcedimientoFinal)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGastoManual>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGastoManual>()
                .Property(e => e.CodProcedimientoInicial)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGastoManual>()
                .Property(e => e.CodProcedimientoFinal)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGastoMedikit>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGastoMedikit>()
                .Property(e => e.CodProcedimientoInicial)
                .IsUnicode(false);

            modelBuilder.Entity<LogControlGastoMedikit>()
                .Property(e => e.CodProcedimientoFinal)
                .IsUnicode(false);

            modelBuilder.Entity<MedicinePreventiveInfonavit>()
                .Property(e => e.User)
                .IsUnicode(false);

            modelBuilder.Entity<MedicinePreventiveInfonavit>()
                .Property(e => e.UserDisabled)
                .IsUnicode(false);

            modelBuilder.Entity<MedicosObispado>()
                .Property(e => e.CodEstatus)
                .IsFixedLength();

            modelBuilder.Entity<MedicosObispado>()
                .Property(e => e.MovimientosDias)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoLlamada>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoLlamada>()
                .Property(e => e.MotivoLlamada1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoLlamada>()
                .Property(e => e.Codigo_Capacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Parentesco>()
                .Property(e => e.Parentesco1)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.CodZona)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion>()
                .Property(e => e.Poblacion1)
                .IsUnicode(false);

            modelBuilder.Entity<Pregunta>()
                .Property(e => e.pregunta1)
                .IsUnicode(false);

            modelBuilder.Entity<Pregunta>()
                .Property(e => e.tipo_resp)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Pregunta>()
                .Property(e => e.tabla)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProcedimientosRecetaElectronica>()
                .Property(e => e.codcuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ProcedimientosRecetaElectronica>()
                .Property(e => e.cpt)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.CodDiagnostico2)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.CodDiagnostico3)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.CodDiagnostico4)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.DigChk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.NombrePacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.APaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.AMaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.AutorizacionLab)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.Autorizacion4to)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagos>()
                .Property(e => e.AutorizacionEsp)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagosCodigoBarras>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<PRODUCTO>()
                .Property(e => e.costo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<producto_tabulador>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<producto_tabulador>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

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
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Red>()
                .HasMany(e => e.SYS_Mediaccess_RED_Cuenta)
                .WithRequired(e => e.Red)
                .HasForeignKey(e => e.CodRed)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Red>()
                .HasMany(e => e.SYS_Mediaccess_RED_Cuenta_Log)
                .WithRequired(e => e.Red)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Red>()
                .HasMany(e => e.SYS_Mediaccess_RED_Cuenta1)
                .WithRequired(e => e.Red1)
                .HasForeignKey(e => e.CodRed)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Regla>()
                .Property(e => e.CodRegla)
                .IsUnicode(false);

            modelBuilder.Entity<Regla>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Regla>()
                .HasMany(e => e.CuentaReglas)
                .WithRequired(e => e.Regla)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Respuesta>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Respuesta>()
                .Property(e => e.respuesta1)
                .IsUnicode(false);

            modelBuilder.Entity<RespuestasCoordinacion>()
                .Property(e => e.RespCoorDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<RespuestasCoordinacion>()
                .Property(e => e.RespCoorNotas)
                .IsUnicode(false);

            modelBuilder.Entity<SamiEspecialidad>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SamiEspecialidad>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<SamiEspecialidad>()
                .Property(e => e.Articulo_con_Retencion)
                .IsUnicode(false);

            modelBuilder.Entity<SamiEspecialidad>()
                .Property(e => e.Articulo_sin_Retencion)
                .IsUnicode(false);

            modelBuilder.Entity<SamiEstado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<SamiEstado>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<SamiEstado>()
                .Property(e => e.CodZona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SamiZona>()
                .Property(e => e.CodZona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SamiZona>()
                .Property(e => e.Zona)
                .IsUnicode(false);

            modelBuilder.Entity<SeguLogin>()
                .Property(e => e.TipoUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SeguLogin>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<SeguLogin>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Cargo)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPersona>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Servicio1)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Codigo_Capacidad)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.ausentismo)
                .WithMany(e => e.Servicio)
                .Map(m => m.ToTable("ServicioAusentismo").MapLeftKey("CodServicio").MapRightKey("CodMotivo"));

            modelBuilder.Entity<subEspecialidad>()
                .Property(e => e.CodSubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<subEspecialidad>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<subEspecialidad>()
                .Property(e => e.SubEspecialidad1)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_RED_Cuenta>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_RED_Cuenta>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_Mediaccess_RED_Cuenta_Log>()
                .Property(e => e.CodLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_WS>()
                .Property(e => e.webservices)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_WS>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_WS_AplicativoConsume>()
                .Property(e => e.Aplicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_WS_AplicativoConsume>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.CodigoCPT4)
                .IsUnicode(false);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.Costo23)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.Costo21)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.Costo18)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Tabulador>()
                .Property(e => e.Costo14)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TabuladorClinicas>()
                .Property(e => e.Tabulador)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorClinicas>()
                .HasMany(e => e.producto_tabulador)
                .WithRequired(e => e.TabuladorClinicas)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TabuladorConsulta>()
                .Property(e => e.codZona)
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

            modelBuilder.Entity<TabuladorPoblacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorPoblacion>()
                .Property(e => e.CPT)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.AbuelosMaternos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.AbuelosPaternos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Padre)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Madre)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Hermanos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Hijos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Alcoholismo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Tabaquismo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Ejercicio)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.EnfCongenitas)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.EnfAdquiridas)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Hospitalizaciones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Traumatismos)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Transfusiones)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Menarca)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.FUM)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Ritmo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Menopausia)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.ComplEmbarazo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.MetAnticonceptivo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Temperatura)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.FC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.FR)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.CabezaCuello)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.ToraxAntPost)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Abdomen)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Extremidades)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Neurologico)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Cardiovascular)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Gastrointestinal)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Osteomuscular)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Genitourinario)
                .IsUnicode(false);

            modelBuilder.Entity<TB_HistClin_Asma>()
                .Property(e => e.Ginecologico)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCuenta>()
                .Property(e => e.TipoCuenta1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoGasto>()
                .Property(e => e.TipoGasto1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoLlamada>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<TipoLlamada>()
                .Property(e => e.TipoLlamada1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoPersona>()
                .Property(e => e.TipoPersona1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodTipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.RestoCalle)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Extension1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Extension2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Celular1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Celular2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Radio)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.ClaveRadio)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.HorarioAtencion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.Restonombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.NumGNP)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.NoInterior)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion>()
                .Property(e => e.NoExterior)
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.pwd_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.nom_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Usuarios>()
                .Property(e => e.permisos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<WsLogger>()
                .Property(e => e.WebService)
                .IsUnicode(false);

            modelBuilder.Entity<WsLogger>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoAfiliado>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DescripcionTipoExamen1>()
                .Property(e => e.DesTipExaDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DescripcionTipoExamen1>()
                .Property(e => e.DesTipExaNotas)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Nomina)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Ocupación)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.LugarResid)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<TB_Fichas>()
                .Property(e => e.Usuario_Captura)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContacto>()
                .Property(e => e.TipoContacto1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoContacto>()
                .HasMany(e => e.ContactoAfiliado)
                .WithRequired(e => e.TipoContacto)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoUbicacion1>()
                .Property(e => e.CodTipoUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<TipoUbicacion1>()
                .Property(e => e.TipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUbicacion1>()
                .HasMany(e => e.UbicacionAfiliado)
                .WithRequired(e => e.TipoUbicacion1)
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
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.CP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionAfiliado>()
                .Property(e => e.Horario)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.CodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.codCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturas>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.CopagoEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.Consecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.CodigoEspecialidadOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleAuxiliar>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleAuxiliar>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_BANDEJA>()
                .Property(e => e.UsuarioEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_BANDEJA>()
                .Property(e => e.UsuarioBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_BANDEJA>()
                .Property(e => e.TipoUsuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ACLARACION_BANDEJA>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.CodParentesco)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Afiliado_HSBC>()
                .Property(e => e.Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<AFQualitas>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<AFQualitas>()
                .Property(e => e.CodCalle)
                .IsUnicode(false);

            modelBuilder.Entity<AFQualitas>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.CodCalle)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<AIG>()
                .Property(e => e.Telefonos)
                .IsUnicode(false);

            modelBuilder.Entity<asignacionCoberturaGrupoEmpresa>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Autorizacion_log>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizacion_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizacion_log>()
                .Property(e => e.UsuarioModif)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_Duplicadas>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_Duplicadas>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_Duplicadas>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_Duplicadas>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_log>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_log>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_log>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_log>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_logNafinyBancomext>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_logNafinyBancomext>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Autorizaciones_logNafinyBancomext>()
                .Property(e => e.IP)
                .IsUnicode(false);

            modelBuilder.Entity<Banco>()
                .Property(e => e.Banco1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.QuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodMotivoQueja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.codMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.Observacion1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.Observacion2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.xusrinsertLog)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_Log>()
                .Property(e => e.evento)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.QuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodMotivoQueja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.codMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.Observacion1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.Observacion2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntrada_pruebas>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.Telefono3)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.CveProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.ObservacionCita)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.UsrTermino)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.ObservacionTermino)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaEM>()
                .Property(e => e.GuiaEnvio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodEstatusBandeja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodProcedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodProcedimiento2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.QuienLlama)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.NumeroTelefono)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodServicio)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodMotivoQueja)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.codMotivo)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.CodTipoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.Observacion1)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.Observacion2)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<BandejaEntradaRespaldo>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<BanruralCiudades>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<BanruralCiudades>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<coberturasTipoGasto>()
                .Property(e => e.coaseguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguraEspecialidadCuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguraEspecialidadCuenta>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ConfiguraEspecialidadCuenta>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.CodCuenta)
                .IsFixedLength();

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.TelefonoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaCitasLOG>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaConvenios>()
                .Property(e => e.Convenio)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodDiagnostico2)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodDiagnostico3)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodDiagnostico4)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.DigChk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.NombrePacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.APaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.AMaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.AutorizacionLab)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.Autorizacion4to)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.AutorizacionEsp)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.xusrinsertLog)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.evento)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSA_sase>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSA_sase>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSA_sase>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSA_sase>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.FolioDet)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.FolioDet)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.xUsrInsertEvento)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.codAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<consultaElectronicaHSADetalle_sase>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.CodDiagnostico2)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.CodDiagnostico3)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.CodDiagnostico4)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.DigChk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.NombrePacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.APaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.AMaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.AutorizacionLab)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.Autorizacion4to)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSAPendientesmodificar>()
                .Property(e => e.AutorizacionEsp)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.TelefonoDirecto)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.CargoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Contacto>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.TelefonoDirecto)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.CargoContacto)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.EmailContacto)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<ContactoLOG>()
                .Property(e => e.TipoAccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CodTipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.RestoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.ApellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.ApellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.flgIguala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.SGPassword)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.cedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Cuenta_respNoBorrar>()
                .Property(e => e.certificacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CodTipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.RestoNombre)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.ApellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.ApellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.flgIguala)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CedulaProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.TipoAccion)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.SGLogin)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.SGPassword)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.cedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<CuentaLOG>()
                .Property(e => e.certificacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_Duplicadas>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_Duplicadas>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_Duplicadas>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_Duplicadas>()
                .Property(e => e.UsuarioModifica)
                .IsUnicode(false);

            modelBuilder.Entity<DescripcionTipoExamen>()
                .Property(e => e.DesTipExaDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DescripcionTipoExamen>()
                .Property(e => e.DesTipExaNotas)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req8)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req9)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req10)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req11)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req12)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req13)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req14)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req15)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req16)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req17)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req18)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req19)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req20)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.Req21)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X8)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X9)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X10)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X11)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X12)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X13)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X14)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X15)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X16)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X17)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.X18)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Documento>()
                .Property(e => e.ReqCompleto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperties>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<EdicionCierre>()
                .Property(e => e.UsuarioID)
                .IsUnicode(false);

            modelBuilder.Entity<EdicionCierre>()
                .Property(e => e.Pagina)
                .IsFixedLength();

            modelBuilder.Entity<EmpresasSAMI>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EmpresasSAMI>()
                .Property(e => e.empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.NOMBRE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.TELFEFONO)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.E_MAIL)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.INCREMENTO_ANUAL)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.VIGENCIA_DE_INICIO)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.TERMINO)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.CALLE)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<EncabezadoListasNafin>()
                .Property(e => e.CIUDAD)
                .IsUnicode(false);

            modelBuilder.Entity<Escolaridad>()
                .Property(e => e.des_esc)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<EstadoCivil>()
                .Property(e => e.des_civ)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Cuenta>()
                .Property(e => e.CodEstatusCuenta)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Cuenta>()
                .Property(e => e.EstatusCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Factura>()
                .Property(e => e.StatusFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Remesa>()
                .Property(e => e.CodStatusRemesa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Estatus_Remesa>()
                .Property(e => e.StatusRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.CodMotivoDevolucion)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.NumeroProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.facImporte)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.facIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.facISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.facRetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.facDescuento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.facTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.flgDetenido)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.DetenidoPor)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.DevueltoPor)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.ObservacionDetenido)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.NumeroGuiaDevolucion)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Facturas>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.CodMotivoDevolucion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.NumeroProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.facImporte)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.facIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.facISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.facRetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.facDescuento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.facTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.flgDetenido)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.DetenidoPor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.DevueltoPor)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.ObservacionDetenido)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.NumeroGuiaDevolucion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<FacturasLOG>()
                .Property(e => e.qUsr)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.NumeroFolio)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.CodTipoArticulo)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.PrecioRef)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.folImporte)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Folios>()
                .Property(e => e.folIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Folios>()
                .Property(e => e.folISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Folios>()
                .Property(e => e.folRetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Folios>()
                .Property(e => e.folDescuento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Folios>()
                .Property(e => e.folTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Folios>()
                .Property(e => e.NombreAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Folios>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosenECE>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosenECE>()
                .Property(e => e.folio)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosenECE>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<FoliosenECE>()
                .Property(e => e.codAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<formapago>()
                .Property(e => e.tipopago)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoMedicamentosDetalle>()
                .Property(e => e.Codigo)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Grupo1)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo_Empresa>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo_Empresa>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Grupo_Empresa>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<grupos>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<grupos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<GuiaForanea>()
                .Property(e => e.NumeroGuia)
                .IsUnicode(false);

            modelBuilder.Entity<GuiaForanea>()
                .Property(e => e.Remitente)
                .IsUnicode(false);

            modelBuilder.Entity<GuiaForanea>()
                .Property(e => e.QuienRecepciona)
                .IsUnicode(false);

            modelBuilder.Entity<GuiaForanea>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<GuiaForanea>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<GuiaForanea>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<ListadoPrecios>()
                .Property(e => e.NumeroProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ListadoPrecios>()
                .Property(e => e.Cve_Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<ListadoPrecios>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<ListadoPrecios>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ListadoPrecios>()
                .Property(e => e.TipoGasto)
                .IsUnicode(false);

            modelBuilder.Entity<MetodoPago>()
                .Property(e => e.CodMetodoPago)
                .IsUnicode(false);

            modelBuilder.Entity<MetodoPago>()
                .Property(e => e.MetodoPago1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoDetencion>()
                .Property(e => e.MotivoDetencion1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoDevolucion>()
                .Property(e => e.CodMotivoDevolucion)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoDevolucion>()
                .Property(e => e.MotivoDevolucion1)
                .IsUnicode(false);

            modelBuilder.Entity<MotivoQueja>()
                .Property(e => e.MotivoQueja1)
                .IsUnicode(false);

            modelBuilder.Entity<motivov>()
                .Property(e => e.CodMotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<motivov>()
                .Property(e => e.MotivoLlamada)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.NumeroFactura)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ImporteFact)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.NumeroProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.NumeroNC)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ncImporte)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ncIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ncISR)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ncRetencionIVA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ncDescuento)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.ncTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<NotasCredito>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaPrimer>()
                .Property(e => e.Codempresa)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaPrimer>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaPrimer>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<PaseEspecialistaPrimer>()
                .Property(e => e.codEspecialidad)
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

            modelBuilder.Entity<planes>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion_log>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion_log>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion_log>()
                .Property(e => e.CodZona)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion_log>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion_log>()
                .Property(e => e.xuserinsert)
                .IsUnicode(false);

            modelBuilder.Entity<Poblacion_log>()
                .Property(e => e.evento)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Procedimiento>()
                .Property(e => e.Procedimiento1)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagosDetalle>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagosDetalle>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagosDetalle>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ProcesaPagosDetalle>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<productoNvoECE_>()
                .Property(e => e.producto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.rfc_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.nom_fiscal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.nom_comercial)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Proveedores>()
                .Property(e => e.direc_fiscal)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecepcionFactura>()
                .Property(e => e.cve_prov)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecepcionFactura>()
                .Property(e => e.no_fac)
                .IsUnicode(false);

            modelBuilder.Entity<RecepcionFactura>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<RecepcionFactura>()
                .Property(e => e.CodEstatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<RecepcionFactura>()
                .Property(e => e.NoPaquete)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.cve_prov)
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
                .Property(e => e.Carga)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.HayIVA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.HayISR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.HayRetIva)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.horario)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Plaza)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Red_Cuenta>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Red_Cuenta>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Red_Cuenta>()
                .Property(e => e.Prioridad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<red_cuenta_>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<red_cuenta_>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<red_cuenta_>()
                .Property(e => e.Prioridad)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Red_Empresa>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Red_Empresa>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Red_Empresa>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Redescpt_SAE>()
                .Property(e => e.RAZON_SOCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<Redescpt_SAE>()
                .Property(e => e.TIPO_DE_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<Redescpt_SAE>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<Redescpt_SAE>()
                .Property(e => e.POBLACION)
                .IsUnicode(false);

            modelBuilder.Entity<Redescpt_SAE>()
                .Property(e => e.Red)
                .IsUnicode(false);

            modelBuilder.Entity<Redescpt_SAE>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.NumeroProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.CodStatusRemesa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.NumeroRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.NombreProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.FechaRemesa)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Remesas>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.RED)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CVE_TIPO_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.TipoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.NOMBRE_DEL_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.NOMBRE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.APELLIDO_PATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.APELLIDO_MATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.PERSONA_JURIDICA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.TIPO_MOVIMIENTO_)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CLAVE_ESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.PORCENTAJE_DE_DESCUENTO)
                .HasPrecision(22, 2);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.RFC_LETRAS)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.RFC_FECHA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.RFC_HOMOCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.FECHA_INICIO_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.FECHA_FIN_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.LADA_1)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.TELEFONO1)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.LADA_2)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.TELEFONO2)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.HORARIO_DE_ATENCION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CVE_ESTADO_PROVINCIA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.POBLACION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.NO_EXTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.NO__INTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.ZONA_QUIRURJICA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.FECHA_MODIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.TIPO_DE_PROVEEDOR___PARA_CECITEC)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.SUBESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CUENTA_BANCARIA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CLABE)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.C_CEDULA_PROFESIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CEDULA_ESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CERTIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.COSTO_CONSULTA_CONVENIDO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.Celular_1)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.Celular_2)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores>()
                .Property(e => e.Email_2)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.CVE_TIPO_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.NOMBRE_DEL_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.APELLIDO_PATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.APELLIDO_MATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.TIPO_MOVIMIENTO_)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.CLAVE_ESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.RFC_LETRAS)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.RFC_FECHA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.RFC_HOMOCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.FECHA_INICIO_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.FECHA_FIN_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.TELEFONO1)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.TELEFONO2)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.CVE_ESTADO_PROVINCIA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.POBLACION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.NO_EXTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.NO__INTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.ZONA_QUIRURJICA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.FECHA_MODIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.TIPO_DE_PROVEEDOR___PARA_CECITEC)
                .IsUnicode(false);

            modelBuilder.Entity<ReporteProveedores_nafin>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.TipoPersona)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req5)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req6)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req7)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req8)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req9)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req10)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req11)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req12)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req13)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req14)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req15)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req16)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req17)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req18)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req19)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req20)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.Req21)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Requisitos>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Respuesta_Coordinador>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Respuesta_Coordinador>()
                .Property(e => e.Nota)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.espCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.copagoen)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.cpt)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.datosentrada)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.DatosSalida)
                .IsUnicode(false);

            modelBuilder.Entity<Revisacopago>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoLlamada>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<SeguimientoLlamada>()
                .Property(e => e.Usr)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPerfil>()
                .Property(e => e.CodPerfil)
                .IsUnicode(false);

            modelBuilder.Entity<SeguPerfil>()
                .Property(e => e.Perfil)
                .IsUnicode(false);

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

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.Disponible)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.Gastado)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.UsuarioCreacion)
                .IsUnicode(false);

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.UsuarioModificacion)
                .IsUnicode(false);

            modelBuilder.Entity<ServiciosenCoberturaXAfiliado>()
                .Property(e => e.SumaAsegurada)
                .HasPrecision(18, 4);

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

            modelBuilder.Entity<TB_EDO_HSBC>()
                .Property(e => e.idMAC)
                .IsUnicode(false);

            modelBuilder.Entity<TB_EDO_HSBC>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TB_ESPEC_HSBC>()
                .Property(e => e.Espec)
                .IsUnicode(false);

            modelBuilder.Entity<TipoExamen>()
                .Property(e => e.TipExaDescripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoExamen>()
                .Property(e => e.TipExaNotas)
                .IsUnicode(false);

            modelBuilder.Entity<TipoFactura>()
                .Property(e => e.CodTipoFactura)
                .IsUnicode(false);

            modelBuilder.Entity<TipoFactura>()
                .Property(e => e.TipoFactura1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUbicacion>()
                .Property(e => e.CodTipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoUbicacion>()
                .Property(e => e.TipoUbicacion1)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.RED)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CVE_TIPO_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.TipoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.NOMBRE_DEL_PROVEEDOR)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.NOMBRE_COMERCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.APELLIDO_PATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.APELLIDO_MATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.NOMBRE)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.PERSONA_JURIDICA)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.TIPO_MOVIMIENTO_)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CLAVE_ESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.PORCENTAJE_DE_DESCUENTO)
                .HasPrecision(22, 2);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.RFC_LETRAS)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.RFC_FECHA)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.RFC_HOMOCLAVE)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.FECHA_INICIO_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.FECHA_FIN_CONVENIO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.LADA_1)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.TELEFONO1)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.LADA_2)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.TELEFONO2)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CELULAR)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.FAX)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.EMAIL)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.HORARIO_DE_ATENCION)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CVE_ESTADO_PROVINCIA)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.POBLACION)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.MUNICIPIO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.DIRECCION)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.NO_EXTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.NO__INTERIOR)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.COLONIA)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CP)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.ZONA_QUIRURJICA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.FECHA_MODIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.TIPO_DE_PROVEEDOR___PARA_CECITEC)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.SUBESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.ESTADO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CUENTA_BANCARIA)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CLABE)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.BANCO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.C_CEDULA_PROFESIONAL)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CEDULA_ESPECIALIDAD)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CERTIFICACION)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.COSTO_CONSULTA_CONVENIDO)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.Celular_1)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.Celular_2)
                .IsUnicode(false);

            modelBuilder.Entity<tmpReporteProveedores>()
                .Property(e => e.Email_2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodTipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.RestoCalle)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Extension1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Extension2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Celular1)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Celular2)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Radio)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.ClaveRadio)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.HorarioAtencion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.xDateUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.Restonombre)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<Ubicacion_respNoBorrar>()
                .Property(e => e.NumGNP)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.SubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodTipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.RestoCalle)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Extension1)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Extension2)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Lada)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Email1)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Email2)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Celular1)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Celular2)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Radio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.ClaveRadio)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.HorarioAtencion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Observacion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.CodEstatusUbicacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.xDateInsert)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.TipoAccion)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.Restonombre)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.NumGNP)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.NoInterior)
                .IsUnicode(false);

            modelBuilder.Entity<UbicacionLOG>()
                .Property(e => e.NoExterior)
                .IsUnicode(false);

            modelBuilder.Entity<Zona>()
                .Property(e => e.Zona1)
                .IsUnicode(false);

            modelBuilder.Entity<Zona>()
                .Property(e => e.Responsable)
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

            modelBuilder.Entity<DatosIvr_log>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_log>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_log>()
                .Property(e => e.xusrinsertLog)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_log>()
                .Property(e => e.evento)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_LOGNafinyBancomext>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_LOGNafinyBancomext>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_LOGNafinyBancomext>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_LOGSAELYF>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_LOGSAELYF>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DatosIvr_LOGSAELYF>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<datosivrBCKnoBANCOMEXnafin>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<datosivrBCKnoBANCOMEXnafin>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<datosivrBCKnoBANCOMEXnafin>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<datosivrbk250618>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<datosivrbk250618>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<datosivrbk250618>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.CodCalle)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.membresia)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.plan)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.idcontratante)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.afiliacion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.producto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.tipo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.cp)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.telefonos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.Recibo)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.Credencial)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.nombre_archivo)
                .IsUnicode(false);

            modelBuilder.Entity<HSBCAfiliado>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Incapacidades1>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Incapacidades1>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<nomina>()
                .Property(e => e.People)
                .IsUnicode(false);

            modelBuilder.Entity<nomina>()
                .Property(e => e.SIP)
                .IsUnicode(false);

            modelBuilder.Entity<Recibo>()
                .Property(e => e.Recibo1)
                .IsUnicode(false);

            modelBuilder.Entity<Recibo>()
                .Property(e => e.CodEmpresa)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.cve_prov)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.RecursoMedico)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Carga)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.HayIVA)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.HayISR)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.HayRetIva)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Status)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.horario)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.cve_usuario)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Plaza)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.CodEstado)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Cuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<Recursos_Medicos1>()
                .Property(e => e.CodPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<RedCuenta10102006>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<RedCuenta10102006>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<RedCuenta18082006>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<RedCuenta18082006>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<Registros>()
                .Property(e => e.People)
                .IsUnicode(false);

            modelBuilder.Entity<Registros>()
                .Property(e => e.Sip2000)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadosSisnova243_>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadosSisnova243_>()
                .Property(e => e.nombres)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadosSisnova243_>()
                .Property(e => e.apellidopaterno)
                .IsUnicode(false);

            modelBuilder.Entity<afiliadosSisnova243_>()
                .Property(e => e.apellidomaterno)
                .IsUnicode(false);

            modelBuilder.Entity<autorizaciones_>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<autorizaciones_>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<cubiertos_>()
                .Property(e => e.codafiliado)
                .IsUnicode(false);

            modelBuilder.Entity<distribucionCorreosIncapacidades>()
                .Property(e => e.CORREO)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidades2012_>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidades2012_>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidades2012_>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidades2012_>()
                .Property(e => e.nombrecompleto)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidades2012_>()
                .Property(e => e.codestado)
                .IsUnicode(false);

            modelBuilder.Entity<elegibilidades2012_>()
                .Property(e => e.uusario)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.CodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasbkSICAS>()
                .Property(e => e.codCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle_>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle_>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle_>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalle_>()
                .Property(e => e.CopagoEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleLog>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleLog>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleLog>()
                .Property(e => e.CodProcedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleLog>()
                .Property(e => e.CopagoEN)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleLog>()
                .Property(e => e.Consecutivo)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasDetalleLog>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.Correlativo)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.CodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.Estatus)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.codCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<GastoCoberturasLog>()
                .Property(e => e.usuarioBorro)
                .IsUnicode(false);

            modelBuilder.Entity<medicamentos_>()
                .Property(e => e.nombreempresa)
                .IsUnicode(false);

            modelBuilder.Entity<medicamentos_>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<medicamentos_>()
                .Property(e => e.precio)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MovimientosRedes>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientosRedes>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientosRedes>()
                .Property(e => e.TipoAccion)
                .IsUnicode(false);

            modelBuilder.Entity<MovimientosRedes>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<PasoCargaImpresion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<PasoCargaImpresion>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<PasoCargaImpresion>()
                .Property(e => e.cobertura)
                .IsUnicode(false);

            modelBuilder.Entity<PasoCargaImpresion>()
                .Property(e => e.codproductoaux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<procesoClinicas_>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<procesoClinicas_>()
                .Property(e => e.via)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.NMP)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.HB)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.CF)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.PRAXIS)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.SHENKEL)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.ZONGOLICA)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.CHROBINSON)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.NumGNP)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.rfc)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.tipopersona)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.apellidoP)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.apellidoM)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.nombrecompleto)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.restonombre)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.curp)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.email1)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.Especialidad)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.subespecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.Poblacion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.tipocuenta)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.TipoUbicacion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.fiscal)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.servicio)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.direccion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.delegación)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.cp)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.lada)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.cedulaprofesional)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.cedespecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.certificacion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.banco)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.cuentabancaria)
                .IsUnicode(false);

            modelBuilder.Entity<proveedores_>()
                .Property(e => e.clabe)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ClavePrincipal)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ClaveAlterna)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.NombreCompleto)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Contacto1)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Contacto2)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.limiteCredito)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ClaveMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ClaveCondicionPago)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ClaveTipoProveedor)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ClaveConceptoBancario)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.cobrarImpuestos)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.retenerImpuestos)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.ProveedorExtrangero)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Vacio)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.CuentaDeCuentasPorCobrar)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.CuentaAnticipos)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.CausaSuspencion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.NombreCalle)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.NumExterior)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.NumInterior)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.referencia)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.codestado)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.codPoblacion)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.codigoPostal)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Fax)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.claveViaEmbarque)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.Notas)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.fechaSuspension)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.banco)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.cuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<proveedoresMicrosip_>()
                .Property(e => e.clabe)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodEstatus)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CURP)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodBanco)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CuentaBancaria)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Clabe)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Celular)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.HorarioConsulta)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Consultorio)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CedProfesional)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CedEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CedSubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.xUsrUpdate)
                .IsUnicode(false);

            modelBuilder.Entity<StaffMedico>()
                .Property(e => e.CodSubEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sumasporempresa_>()
                .Property(e => e.nombreempresa)
                .IsUnicode(false);

            modelBuilder.Entity<sumasporempresa_>()
                .Property(e => e.autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<temporal>()
                .Property(e => e.codcuenta)
                .IsUnicode(false);

            modelBuilder.Entity<temporal>()
                .Property(e => e.xusrinsert)
                .IsUnicode(false);
        }
    }
}
