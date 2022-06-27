using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Bsase_Datos_Model.DBNomina
{
    public partial class DBContextNomina : DbContext
    {
        public DBContextNomina()
            : base("name=DBContextNomina")
        {
            this.Database.CommandTimeout = 500;
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<CAT_APP> CAT_APP { get; set; }
        public virtual DbSet<CAT_ESTATUS_USR> CAT_ESTATUS_USR { get; set; }
        public virtual DbSet<CAT_ROL> CAT_ROL { get; set; }
        public virtual DbSet<GRUPO> GRUPO { get; set; }
        public virtual DbSet<GRUPO_OPCION_ACCION> GRUPO_OPCION_ACCION { get; set; }
        public virtual DbSet<GRUPO_OPCION_SECCION> GRUPO_OPCION_SECCION { get; set; }
        public virtual DbSet<GRUPO_PERMISO> GRUPO_PERMISO { get; set; }
        public virtual DbSet<GRUPO_ROL> GRUPO_ROL { get; set; }
        public virtual DbSet<GRUPO_URL_POST_APP> GRUPO_URL_POST_APP { get; set; }
        public virtual DbSet<GRUPO_USUARIO> GRUPO_USUARIO { get; set; }
        public virtual DbSet<MENSAJE_APP> MENSAJE_APP { get; set; }
        public virtual DbSet<MODULO_APP> MODULO_APP { get; set; }
        public virtual DbSet<OPCION_ACCION> OPCION_ACCION { get; set; }
        public virtual DbSet<OPCION_MODULO> OPCION_MODULO { get; set; }
        public virtual DbSet<OPCION_SECCION> OPCION_SECCION { get; set; }
        public virtual DbSet<ROL_OPCION> ROL_OPCION { get; set; }
        public virtual DbSet<URL_POST_APP> URL_POST_APP { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.nombre_app)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.logo)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.url_home)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.CAT_ROL)
                .WithRequired(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.CAT_ROL1)
                .WithRequired(e => e.CAT_APP1)
                .HasForeignKey(e => e.id_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.MENSAJE_APP)
                .WithRequired(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.MODULO_APP)
                .WithRequired(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_APP>()
                .HasMany(e => e.URL_POST_APP)
                .WithRequired(e => e.CAT_APP)
                .HasForeignKey(e => e.id_app)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .Property(e => e.estatus)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ESTATUS_USR>()
                .HasMany(e => e.USUARIO)
                .WithRequired(e => e.CAT_ESTATUS_USR)
                .HasForeignKey(e => e.id_estatus_usr)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.rol)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.GRUPO_PERMISO)
                .WithRequired(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol_opcion);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.GRUPO_ROL)
                .WithRequired(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.MENSAJE_APP)
                .WithRequired(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol_origen)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CAT_ROL>()
                .HasMany(e => e.ROL_OPCION)
                .WithRequired(e => e.CAT_ROL)
                .HasForeignKey(e => e.id_rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.grupo1)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO>()
                .HasMany(e => e.GRUPO_PERMISO)
                .WithRequired(e => e.GRUPO)
                .HasForeignKey(e => e.id_grupo);

            modelBuilder.Entity<GRUPO>()
                .HasMany(e => e.GRUPO_ROL)
                .WithRequired(e => e.GRUPO)
                .HasForeignKey(e => e.id_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRUPO>()
                .HasMany(e => e.GRUPO_USUARIO)
                .WithRequired(e => e.GRUPO)
                .HasForeignKey(e => e.id_grupo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GRUPO_OPCION_ACCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_OPCION_ACCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_OPCION_SECCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_OPCION_SECCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_PERMISO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_PERMISO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_ROL>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_ROL>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_URL_POST_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_URL_POST_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_USUARIO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<GRUPO_USUARIO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.mensaje)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.json_data)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<MENSAJE_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.nombre_modulo)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.url_icono)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.url_destino)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<MODULO_APP>()
                .HasMany(e => e.OPCION_MODULO)
                .WithRequired(e => e.MODULO_APP)
                .HasForeignKey(e => e.id_modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.nombre_accion)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_ACCION>()
                .HasMany(e => e.GRUPO_OPCION_ACCION)
                .WithRequired(e => e.OPCION_ACCION)
                .HasForeignKey(e => e.id_accion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.descripcion_item)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.url_destino)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.url_icono)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.OPCION_ACCION)
                .WithRequired(e => e.OPCION_MODULO)
                .HasForeignKey(e => e.id_item_modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.OPCION_ACCION1)
                .WithRequired(e => e.OPCION_MODULO1)
                .HasForeignKey(e => e.id_item_modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.OPCION_ACCION2)
                .WithRequired(e => e.OPCION_MODULO2)
                .HasForeignKey(e => e.id_item_modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.OPCION_SECCION)
                .WithRequired(e => e.OPCION_MODULO)
                .HasForeignKey(e => e.id_item_modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_MODULO>()
                .HasMany(e => e.ROL_OPCION)
                .WithRequired(e => e.OPCION_MODULO)
                .HasForeignKey(e => e.id_item_modulo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.nombre_seccion)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.version)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.ui_grupo)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.json_params)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<OPCION_SECCION>()
                .HasMany(e => e.GRUPO_OPCION_SECCION)
                .WithRequired(e => e.OPCION_SECCION)
                .HasForeignKey(e => e.id_modulo_seccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROL_OPCION>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<ROL_OPCION>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<URL_POST_APP>()
                .Property(e => e.url_post)
                .IsUnicode(false);

            modelBuilder.Entity<URL_POST_APP>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<URL_POST_APP>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.usuario1)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.llave_usuario)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.UsuAlta)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .Property(e => e.UsuCambio)
                .IsUnicode(false);

            modelBuilder.Entity<USUARIO>()
                .HasMany(e => e.GRUPO_USUARIO)
                .WithRequired(e => e.USUARIO)
                .HasForeignKey(e => e.id_usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
