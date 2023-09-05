namespace Bsase_Datos_Model.NUR
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TB_HistClin_Asma
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdFicha { get; set; }

        [StringLength(255)]
        public string AbuelosMaternos { get; set; }

        [StringLength(255)]
        public string AbuelosPaternos { get; set; }

        [StringLength(255)]
        public string Padre { get; set; }

        [StringLength(255)]
        public string Madre { get; set; }

        [StringLength(255)]
        public string Hermanos { get; set; }

        [StringLength(255)]
        public string Hijos { get; set; }

        [StringLength(255)]
        public string Alcoholismo { get; set; }

        [StringLength(255)]
        public string Tabaquismo { get; set; }

        [StringLength(255)]
        public string Ejercicio { get; set; }

        [StringLength(255)]
        public string EnfCongenitas { get; set; }

        [StringLength(255)]
        public string EnfAdquiridas { get; set; }

        [StringLength(255)]
        public string Hospitalizaciones { get; set; }

        [StringLength(255)]
        public string Traumatismos { get; set; }

        [StringLength(255)]
        public string Transfusiones { get; set; }

        [StringLength(150)]
        public string Menarca { get; set; }

        [StringLength(150)]
        public string FUM { get; set; }

        [StringLength(150)]
        public string Ritmo { get; set; }

        [StringLength(150)]
        public string Menopausia { get; set; }

        public int? Embarazos { get; set; }

        public int? Partos { get; set; }

        public int? Cesareas { get; set; }

        public int? Abortos { get; set; }

        [StringLength(255)]
        public string ComplEmbarazo { get; set; }

        [StringLength(150)]
        public string MetAnticonceptivo { get; set; }

        public int? Sistolica { get; set; }

        public int? Distolica { get; set; }

        [StringLength(20)]
        public string Temperatura { get; set; }

        [StringLength(20)]
        public string FC { get; set; }

        [StringLength(20)]
        public string FR { get; set; }

        [StringLength(150)]
        public string CabezaCuello { get; set; }

        [StringLength(150)]
        public string ToraxAntPost { get; set; }

        [StringLength(150)]
        public string Abdomen { get; set; }

        [StringLength(150)]
        public string Extremidades { get; set; }

        [StringLength(150)]
        public string Neurologico { get; set; }

        [StringLength(150)]
        public string Cardiovascular { get; set; }

        [StringLength(150)]
        public string Gastrointestinal { get; set; }

        [StringLength(150)]
        public string Osteomuscular { get; set; }

        [StringLength(150)]
        public string Genitourinario { get; set; }

        [StringLength(150)]
        public string Ginecologico { get; set; }

        [Column(TypeName = "ntext")]
        public string Evaluacion { get; set; }

        [Column(TypeName = "ntext")]
        public string Indicaciones { get; set; }
    }
}
