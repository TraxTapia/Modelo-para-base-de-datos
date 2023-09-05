using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.TabuladoresConsultas
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context4")
        {
        }

        public virtual DbSet<BMXTMP> BMXTMP { get; set; }
        public virtual DbSet<CartasWellnessExterno> CartasWellnessExterno { get; set; }
        public virtual DbSet<CartasWellnessInterno> CartasWellnessInterno { get; set; }
        public virtual DbSet<CatFormaFarmaceutica> CatFormaFarmaceutica { get; set; }
        public virtual DbSet<CatUnidaddeMedidas> CatUnidaddeMedidas { get; set; }
        public virtual DbSet<CatUnidades> CatUnidades { get; set; }
        public virtual DbSet<CatViaAdmUnidades> CatViaAdmUnidades { get; set; }
        public virtual DbSet<CoberturaProducto> CoberturaProducto { get; set; }
        public virtual DbSet<ConsultaElectronicaHSA> ConsultaElectronicaHSA { get; set; }
        public virtual DbSet<ConsultaElectronicaHSADetalle> ConsultaElectronicaHSADetalle { get; set; }
        public virtual DbSet<ControlGasto> ControlGasto { get; set; }
        public virtual DbSet<CptConsulta> CptConsulta { get; set; }
        public virtual DbSet<DetalleSCYF> DetalleSCYF { get; set; }
        public virtual DbSet<Error_Log_SQL> Error_Log_SQL { get; set; }
        public virtual DbSet<FileScyfFtp> FileScyfFtp { get; set; }
        public virtual DbSet<LogFileSCYF> LogFileSCYF { get; set; }
        public virtual DbSet<LogHistoricoTabuladores> LogHistoricoTabuladores { get; set; }
        public virtual DbSet<LogProductosEmision> LogProductosEmision { get; set; }
        public virtual DbSet<MedikitFTPFile> MedikitFTPFile { get; set; }
        public virtual DbSet<MedikitFtpFileDetail> MedikitFtpFileDetail { get; set; }
        public virtual DbSet<Moneda> Moneda { get; set; }
        public virtual DbSet<ProductosEmision> ProductosEmision { get; set; }
        public virtual DbSet<ResumenGasto> ResumenGasto { get; set; }
        public virtual DbSet<sys_mediaccess_Agrupacion_Productos> sys_mediaccess_Agrupacion_Productos { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Cuadros> sys_mediaccess_Cat_Cuadros { get; set; }
        public virtual DbSet<sys_mediaccess_LimTCtaAgrupado> sys_mediaccess_LimTCtaAgrupado { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos> sys_mediaccess_Medicamentos { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos_Detalle> sys_mediaccess_Medicamentos_Detalle { get; set; }
        public virtual DbSet<sys_mediaccess_TipoConteo> sys_mediaccess_TipoConteo { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TabuladorConsultas> TabuladorConsultas { get; set; }
        public virtual DbSet<tblServiceAut> tblServiceAut { get; set; }
        public virtual DbSet<tblServiceAutDetails> tblServiceAutDetails { get; set; }
        public virtual DbSet<TipoCobertura> TipoCobertura { get; set; }
        public virtual DbSet<TipodeCambio> TipodeCambio { get; set; }
        public virtual DbSet<Vacantes> Vacantes { get; set; }
        public virtual DbSet<VacantesRequisitos> VacantesRequisitos { get; set; }
        public virtual DbSet<AfilBancomext> AfilBancomext { get; set; }
        public virtual DbSet<AfilNafin> AfilNafin { get; set; }
        public virtual DbSet<AutorizacionesCE> AutorizacionesCE { get; set; }
        public virtual DbSet<ayudapadron> ayudapadron { get; set; }
        public virtual DbSet<CoberturaProductoServicio> CoberturaProductoServicio { get; set; }
        public virtual DbSet<CoberturaServicio> CoberturaServicio { get; set; }
        public virtual DbSet<ConsultaElectronicaHSA_log> ConsultaElectronicaHSA_log { get; set; }
        public virtual DbSet<ConsultaElectronicaHSADetalle_log> ConsultaElectronicaHSADetalle_log { get; set; }
        public virtual DbSet<Grupos> Grupos { get; set; }
        public virtual DbSet<Mediaccess_ConsultaElectronicaHSA> Mediaccess_ConsultaElectronicaHSA { get; set; }
        public virtual DbSet<Mediaccess_ConsultaElectronicaHSADetalle> Mediaccess_ConsultaElectronicaHSADetalle { get; set; }
        public virtual DbSet<Medicamentos_BANCOMEXT> Medicamentos_BANCOMEXT { get; set; }
        public virtual DbSet<Medicamentos_KWRTH_R> Medicamentos_KWRTH_R { get; set; }
        public virtual DbSet<MedicamentosNAFBMX> MedicamentosNAFBMX { get; set; }
        public virtual DbSet<Ordenada> Ordenada { get; set; }
        public virtual DbSet<Ordenada_Ant> Ordenada_Ant { get; set; }
        public virtual DbSet<PaseEspecialistaPrimer> PaseEspecialistaPrimer { get; set; }
        public virtual DbSet<PaseEspecialistaSegundo> PaseEspecialistaSegundo { get; set; }
        public virtual DbSet<PeticionesCuadros_Log> PeticionesCuadros_Log { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Red> Red { get; set; }
        public virtual DbSet<resp01042019_sys_mediaccess_Cat_Sal> resp01042019_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp01082019_sys_mediaccess_Cat_Sal> resp01082019_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp04102019_sys_mediaccess_Cat_Especialidades> resp04102019_sys_mediaccess_Cat_Especialidades { get; set; }
        public virtual DbSet<resp04102019_sys_mediaccess_Cat_Grupos> resp04102019_sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<resp04102019_sys_mediaccess_Cat_Laboratorios> resp04102019_sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<resp04102019_sys_mediaccess_Cat_Sal> resp04102019_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp04102019_sys_mediaccess_Medicamentos> resp04102019_sys_mediaccess_Medicamentos { get; set; }
        public virtual DbSet<resp10072019_2_sys_mediaccess_Cat_Grupos> resp10072019_2_sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<resp10072019_2_sys_mediaccess_Cat_Sal> resp10072019_2_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp12062018_sys_mediaccess_Medicamentos> resp12062018_sys_mediaccess_Medicamentos { get; set; }
        public virtual DbSet<resp14052019_sys_mediaccess_Cat_Laboratorios> resp14052019_sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<resp15072019_sys_mediaccess_Cat_Especialidades> resp15072019_sys_mediaccess_Cat_Especialidades { get; set; }
        public virtual DbSet<resp15072019_sys_mediaccess_Cat_Grupos> resp15072019_sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<resp15072019_sys_mediaccess_Cat_Laboratorios> resp15072019_sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<resp15072019_sys_mediaccess_Cat_Sal> resp15072019_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp18072019_sys_mediaccess_Cat_Grupos> resp18072019_sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<resp19052020_sys_mediaccess_Cat_Laboratorios> resp19052020_sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<resp19052020_sys_mediaccess_Cat_Sal> resp19052020_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp19122019_sys_mediaccess_Cat_Sal> resp19122019_sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<resp20062019_sys_mediaccess_Cat_Laboratorios> resp20062019_sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<resp28122018_sys_mediaccess_Cat_Grupos> resp28122018_sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<RespaldoCatSal20210112> RespaldoCatSal20210112 { get; set; }
        public virtual DbSet<respaldoselectproducto> respaldoselectproducto { get; set; }
        public virtual DbSet<respSYS_IVR_PaseEspecialista2_310818> respSYS_IVR_PaseEspecialista2_310818 { get; set; }
        public virtual DbSet<SASE_ConsultaElectronicaHSA> SASE_ConsultaElectronicaHSA { get; set; }
        public virtual DbSet<SASE_ConsultaElectronicaHSADetalle> SASE_ConsultaElectronicaHSADetalle { get; set; }
        public virtual DbSet<SYS_IVR_Frecuencia> SYS_IVR_Frecuencia { get; set; }
        public virtual DbSet<SYS_IVR_PaseEspecialista> SYS_IVR_PaseEspecialista { get; set; }
        public virtual DbSet<SYS_IVR_PaseEspecialista_completo> SYS_IVR_PaseEspecialista_completo { get; set; }
        public virtual DbSet<SYS_IVR_PaseEspGpo> SYS_IVR_PaseEspGpo { get; set; }
        public virtual DbSet<sys_mediaccess_Agrupacion_Productos_log> sys_mediaccess_Agrupacion_Productos_log { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Especialidades> sys_mediaccess_Cat_Especialidades { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Especialidades_reversar> sys_mediaccess_Cat_Especialidades_reversar { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Grupos> sys_mediaccess_Cat_Grupos { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Grupos_reversar> sys_mediaccess_Cat_Grupos_reversar { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Laboratorios> sys_mediaccess_Cat_Laboratorios { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Laboratorios_reversar> sys_mediaccess_Cat_Laboratorios_reversar { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Sal> sys_mediaccess_Cat_Sal { get; set; }
        public virtual DbSet<sys_mediaccess_Cat_Sal__reversar> sys_mediaccess_Cat_Sal__reversar { get; set; }
        public virtual DbSet<sys_mediaccess_CatClaves_Autorizacion> sys_mediaccess_CatClaves_Autorizacion { get; set; }
        public virtual DbSet<sys_mediaccess_CatMensajes_ECE> sys_mediaccess_CatMensajes_ECE { get; set; }
        public virtual DbSet<Sys_Mediaccess_Consultas_Restringidas> Sys_Mediaccess_Consultas_Restringidas { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos__reversar> sys_mediaccess_Medicamentos__reversar { get; set; }
        public virtual DbSet<sys_mediaccess_Medicamentos_log> sys_mediaccess_Medicamentos_log { get; set; }
        public virtual DbSet<sys_mediaccess_Medio_Recepcion> sys_mediaccess_Medio_Recepcion { get; set; }
        public virtual DbSet<sys_mediaccess_Producto_Tabulador> sys_mediaccess_Producto_Tabulador { get; set; }
        public virtual DbSet<sys_mediaccess_TipoCuenta> sys_mediaccess_TipoCuenta { get; set; }
        public virtual DbSet<TabuladorFarmaciaMPromedioReciente> TabuladorFarmaciaMPromedioReciente { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BMXTMP>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<BMXTMP>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<BMXTMP>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessExterno>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessExterno>()
                .Property(e => e.Genero)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessExterno>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessExterno>()
                .HasMany(e => e.CartasWellnessInterno)
                .WithRequired(e => e.CartasWellnessExterno)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CartasWellnessInterno>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessInterno>()
                .Property(e => e.FolioInterno)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessInterno>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<CartasWellnessInterno>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<CatFormaFarmaceutica>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatUnidaddeMedidas>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatUnidades>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CatViaAdmUnidades>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaProducto>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaProducto>()
                .Property(e => e.limite)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.codAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.codEspecialidad)
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
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.PrecioUnitario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Copago)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Monto_Copago)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Cve_proc)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Cve_espec)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Cve_cie)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Importe)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ControlGasto>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<CptConsulta>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NomProducto)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Empresa)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NroNomina)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Colonia)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Ciudad)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Calle)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.CodPostal)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.EstadoCivil)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.ApPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.ApMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Nacionalidad)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.TelCasa)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Sexo)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FNacimiento)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FInicioServicio)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FFinServicio)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Vip)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.FAntiguedad)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NroPoliza)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.NroAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<DetalleSCYF>()
                .Property(e => e.TextoError)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Procedimiento)
                .IsUnicode(false);

            modelBuilder.Entity<Error_Log_SQL>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.ContentFile)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<FileScyfFtp>()
                .HasMany(e => e.DetalleSCYF)
                .WithRequired(e => e.FileScyfFtp)
                .HasForeignKey(e => e.IdFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LogFileSCYF>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<LogFileSCYF>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<LogHistoricoTabuladores>()
                .Property(e => e.Monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<LogHistoricoTabuladores>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.ICodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.VCHCodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.ICodCoberturaCambio)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.VCHCodProductoCambio)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<LogProductosEmision>()
                .Property(e => e.Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFTPFile>()
                .Property(e => e.NombreArchivo)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFTPFile>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFTPFile>()
                .HasMany(e => e.MedikitFtpFileDetail)
                .WithRequired(e => e.MedikitFTPFile)
                .HasForeignKey(e => e.IdFile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nur)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Paciente)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Doctor)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Dispensacion_de_medicamentos)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Creado_por)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Ultima_modificacion_por)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Estatus)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre_Medicacion)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Receta_relacionada)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre_de_Sucursal)
                .IsUnicode(false);

            modelBuilder.Entity<MedikitFtpFileDetail>()
                .Property(e => e.Nombre_de_la_cuenta_del_dispensador)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.CveMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<Moneda>()
                .Property(e => e.DescripcionMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<ProductosEmision>()
                .Property(e => e.ICodCobertura)
                .IsUnicode(false);

            modelBuilder.Entity<ProductosEmision>()
                .Property(e => e.VCHCodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ResumenGasto>()
                .Property(e => e.codAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ResumenGasto>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ResumenGasto>()
                .Property(e => e.gastoReservado)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ResumenGasto>()
                .Property(e => e.gastoReal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Cuadros>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_LimTCtaAgrupado>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_LimTCtaAgrupado>()
                .Property(e => e.Limite)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sys_mediaccess_Medicamentos>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_Detalle>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_TipoConteo>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorConsultas>()
                .Property(e => e.Monto)
                .HasPrecision(18, 4);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag1)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag2)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag3)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag4)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag5)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag6)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag7)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .Property(e => e.CodDiag8)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAut>()
                .HasMany(e => e.tblServiceAutDetails)
                .WithRequired(e => e.tblServiceAut)
                .HasForeignKey(e => e.tblServiceAut_ID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.FolioDet)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.codAut)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<tblServiceAutDetails>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCobertura>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoCobertura>()
                .Property(e => e.limite)
                .HasPrecision(19, 4);

            modelBuilder.Entity<TipoCobertura>()
                .HasMany(e => e.ControlGasto)
                .WithRequired(e => e.TipoCobertura)
                .HasForeignKey(e => e.IdTipoCobertura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoCobertura>()
                .HasMany(e => e.ResumenGasto)
                .WithRequired(e => e.TipoCobertura)
                .HasForeignKey(e => e.idTipoCobertura)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipodeCambio>()
                .Property(e => e.CveMoneda)
                .IsUnicode(false);

            modelBuilder.Entity<TipodeCambio>()
                .Property(e => e.Monto)
                .HasPrecision(19, 5);

            modelBuilder.Entity<Vacantes>()
                .Property(e => e.Puesto)
                .IsUnicode(false);

            modelBuilder.Entity<Vacantes>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Vacantes>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Vacantes>()
                .Property(e => e.UsuarioCreacion)
                .IsUnicode(false);

            modelBuilder.Entity<Vacantes>()
                .Property(e => e.UsuarioDeshabilitacion)
                .IsUnicode(false);

            modelBuilder.Entity<Vacantes>()
                .HasMany(e => e.VacantesRequisitos)
                .WithRequired(e => e.Vacantes)
                .HasForeignKey(e => e.Vacante_Id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<VacantesRequisitos>()
                .Property(e => e.Requisito)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfilBancomext>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AfilNafin>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.paciente)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.parentesco)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.nombreempresa)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Diag1)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Diag2)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Diag3)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Diag4)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.poliza)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.copago_en)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.producto)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodDiagnostico2)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodDiagnostico3)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodDiagnostico4)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.DigChk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.NombrePacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.APaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.AMaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.AutorizacionLab)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Autorizacion4to)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.AutorizacionEsp)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<AutorizacionesCE>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.Nombres)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.ApellidoPaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.ApellidoMaterno)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.Sexo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.RFC)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.DiaSemanaCorte)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodEstatusImpresion)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodVendedor)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodViaCarga)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodSeguro)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.tipoEmpleado)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.centroCostos)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.CodProductoAux)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.Poliza)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.codaseguradora)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<ayudapadron>()
                .Property(e => e.Evento)
                .IsUnicode(false);

            modelBuilder.Entity<CoberturaProductoServicio>()
                .Property(e => e.CodProducto)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSA_log>()
                .Property(e => e.xUsrInsertEvento)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.codAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.codEspecialidad)
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
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<ConsultaElectronicaHSADetalle_log>()
                .Property(e => e.xUsrInsertEvento)
                .IsUnicode(false);

            modelBuilder.Entity<Grupos>()
                .Property(e => e.cve_empresa)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Grupos>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico2)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico3)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.CodDiagnostico4)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.DigChk)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.NombrePacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.APaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.AMaternoPacienteExt)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.AutorizacionLab)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.Autorizacion2)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.Autorizacion4to)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSA>()
                .Property(e => e.AutorizacionEsp)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSADetalle>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Mediaccess_ConsultaElectronicaHSADetalle>()
                .Property(e => e.FolioDet)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_BANCOMEXT>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<Medicamentos_KWRTH_R>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.EAN)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.NombreComercial)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.FormaFarmaceutica)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.ViaAdmUnidad)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.Unidad)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.Concentracion)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.UnidaddeMedida)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.Dsc_Cuadro)
                .IsUnicode(false);

            modelBuilder.Entity<MedicamentosNAFBMX>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada>()
                .Property(e => e.ElegOrigen)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada_Ant>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada_Ant>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada_Ant>()
                .Property(e => e.Numero)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada_Ant>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<Ordenada_Ant>()
                .Property(e => e.ElegOrigen)
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

            modelBuilder.Entity<PeticionesCuadros_Log>()
                .Property(e => e.PMP)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PeticionesCuadros_Log>()
                .Property(e => e.NOMBREARCHIVO)
                .IsUnicode(false);

            modelBuilder.Entity<PeticionesCuadros_Log>()
                .Property(e => e.Tablapaso)
                .IsUnicode(false);

            modelBuilder.Entity<Planes>()
                .Property(e => e.descripcion)
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

            modelBuilder.Entity<resp01042019_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp01082019_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp04102019_sys_mediaccess_Cat_Especialidades>()
                .Property(e => e.DscEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<resp04102019_sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<resp04102019_sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<resp04102019_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp04102019_sys_mediaccess_Medicamentos>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<resp10072019_2_sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<resp10072019_2_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp12062018_sys_mediaccess_Medicamentos>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<resp14052019_sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<resp15072019_sys_mediaccess_Cat_Especialidades>()
                .Property(e => e.DscEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<resp15072019_sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<resp15072019_sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<resp15072019_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp18072019_sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<resp19052020_sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<resp19052020_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp19122019_sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<resp20062019_sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<resp28122018_sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<RespaldoCatSal20210112>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<respaldoselectproducto>()
                .Property(e => e.codproducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<respSYS_IVR_PaseEspecialista2_310818>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<respSYS_IVR_PaseEspecialista2_310818>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<respSYS_IVR_PaseEspecialista2_310818>()
                .Property(e => e.PaseEspecialista)
                .IsUnicode(false);

            modelBuilder.Entity<respSYS_IVR_PaseEspecialista2_310818>()
                .Property(e => e.Clinica)
                .IsUnicode(false);

            modelBuilder.Entity<respSYS_IVR_PaseEspecialista2_310818>()
                .Property(e => e.xUsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSA>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSA>()
                .Property(e => e.Folio)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSA>()
                .Property(e => e.CodAfiliado)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSA>()
                .Property(e => e.CodCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Elegibilidad)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.codAutorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Autorizacion)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Cpt)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.CodTabulador)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.CopagoEn)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<SASE_ConsultaElectronicaHSADetalle>()
                .Property(e => e.Indicaciones)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_Frecuencia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<SYS_IVR_Frecuencia>()
                .Property(e => e.CodEvento)
                .IsFixedLength()
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

            modelBuilder.Entity<SYS_IVR_PaseEspGpo>()
                .Property(e => e.Codempresa)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos_log>()
                .Property(e => e.codProducto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos_log>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Agrupacion_Productos_log>()
                .Property(e => e.observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Especialidades>()
                .Property(e => e.DscEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Especialidades_reversar>()
                .Property(e => e.DscEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Grupos>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Grupos_reversar>()
                .Property(e => e.DscGrupo)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Laboratorios>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Laboratorios_reversar>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Sal>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Cat_Sal__reversar>()
                .Property(e => e.DscSal)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Cve_Aut)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Comentario)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatClaves_Autorizacion>()
                .Property(e => e.Color_Aut)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatMensajes_ECE>()
                .Property(e => e.Mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_CatMensajes_ECE>()
                .Property(e => e.UsrInsert)
                .IsUnicode(false);

            modelBuilder.Entity<Sys_Mediaccess_Consultas_Restringidas>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos__reversar>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.codEspecialidad)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.TipoCambio)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.UserInsert)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medicamentos_log>()
                .Property(e => e.Observaciones)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Medio_Recepcion>()
                .Property(e => e.DscMedRecepcion)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Producto_Tabulador>()
                .Property(e => e.codProducto)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_Producto_Tabulador>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_TipoCuenta>()
                .Property(e => e.CodTipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<sys_mediaccess_TipoCuenta>()
                .Property(e => e.TipoCuenta)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioReciente>()
                .Property(e => e.descuento)
                .IsUnicode(false);

            modelBuilder.Entity<TabuladorFarmaciaMPromedioReciente>()
                .Property(e => e.pmp)
                .HasPrecision(19, 4);
        }
    }
}
