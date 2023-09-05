namespace Bsase_Datos_Model.REMESASECE.Iss
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DocumentoProveedor")]
    public partial class DocumentoProveedor
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodProveedor { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CodDocumento { get; set; }

        public int CodEntrega { get; set; }

        [StringLength(50)]
        public string Descripcion { get; set; }

        public virtual Documento Documento { get; set; }

        public virtual Entrega Entrega { get; set; }

        public virtual Proveedor Proveedor { get; set; }
    }
}
