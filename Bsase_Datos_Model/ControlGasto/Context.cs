using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.ControlGasto
{
    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context2")
        {
        }

        public virtual DbSet<GastoCoberturas> GastoCoberturas { get; set; }
        public virtual DbSet<GastoCoberturasDetalle> GastoCoberturasDetalle { get; set; }
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
