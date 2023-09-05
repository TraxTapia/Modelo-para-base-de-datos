namespace Bsase_Datos_Model.Bases_De_Datos.back
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ConsultaElectronicaHSANoFacturado")]
    public partial class ConsultaElectronicaHSANoFacturado
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string autorizacion { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codempresa { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(100)]
        public string CodProducto { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int coddetalle { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string cpt { get; set; }

        public string Descripcion { get; set; }

        [StringLength(10)]
        public string codtabulador { get; set; }

        public DateTime? xDateInsert { get; set; }

        public int AntPagadoFacturado { get; set; }

        public int PagadoFacturado { get; set; }
    }
}
