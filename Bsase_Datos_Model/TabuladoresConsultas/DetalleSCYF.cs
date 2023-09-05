namespace Bsase_Datos_Model.TabuladoresConsultas
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetalleSCYF")]
    public partial class DetalleSCYF
    {
        public int Id { get; set; }

        public int IdFile { get; set; }

        [Required]
        [StringLength(30)]
        public string CodProducto { get; set; }

        [Required]
        [StringLength(50)]
        public string NomProducto { get; set; }

        public int CodEmpresa { get; set; }

        [Required]
        [StringLength(50)]
        public string Empresa { get; set; }

        [Required]
        [StringLength(30)]
        public string NroNomina { get; set; }

        [Required]
        [StringLength(30)]
        public string Comentario { get; set; }

        public int Edad { get; set; }

        [Required]
        [StringLength(20)]
        public string RFC { get; set; }

        public int CodParentesco { get; set; }

        public int Clave { get; set; }

        [Required]
        [StringLength(20)]
        public string Estado { get; set; }

        [Required]
        [StringLength(100)]
        public string Colonia { get; set; }

        [Required]
        [StringLength(100)]
        public string Ciudad { get; set; }

        [Required]
        [StringLength(180)]
        public string Calle { get; set; }

        [Required]
        [StringLength(15)]
        public string Numero { get; set; }

        [Required]
        [StringLength(10)]
        public string CodPostal { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombres { get; set; }

        [Required]
        [StringLength(50)]
        public string EstadoCivil { get; set; }

        [Required]
        [StringLength(50)]
        public string ApPaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string ApMaterno { get; set; }

        [Required]
        [StringLength(50)]
        public string Nacionalidad { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(40)]
        public string TelCasa { get; set; }

        [Required]
        [StringLength(40)]
        public string Sexo { get; set; }

        [Required]
        [StringLength(20)]
        public string FNacimiento { get; set; }

        [Required]
        [StringLength(20)]
        public string FInicioServicio { get; set; }

        [Required]
        [StringLength(20)]
        public string FFinServicio { get; set; }

        [Required]
        [StringLength(10)]
        public string Vip { get; set; }

        [Required]
        [StringLength(20)]
        public string FAntiguedad { get; set; }

        [Required]
        [StringLength(1)]
        public string Estatus { get; set; }

        [Required]
        [StringLength(20)]
        public string NroPoliza { get; set; }

        [Required]
        [StringLength(25)]
        public string NroAfiliado { get; set; }

        public bool Procesado { get; set; }

        [Required]
        [StringLength(200)]
        public string TextoError { get; set; }

        public virtual FileScyfFtp FileScyfFtp { get; set; }
    }
}
