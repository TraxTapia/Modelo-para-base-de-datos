namespace Bsase_Datos_Model.Nomina
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("@AST_011")]
    public partial class C_AST_011
    {
        [Key]
        [StringLength(8)]
        public string Code { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public int DocEntry { get; set; }

        [StringLength(1)]
        public string Canceled { get; set; }

        [StringLength(20)]
        public string Object { get; set; }

        public int? LogInst { get; set; }

        public int? UserSign { get; set; }

        [StringLength(1)]
        public string Transfered { get; set; }

        public DateTime? CreateDate { get; set; }

        public short? CreateTime { get; set; }

        public DateTime? UpdateDate { get; set; }

        public short? UpdateTime { get; set; }

        [StringLength(1)]
        public string DataSource { get; set; }

        [StringLength(1)]
        public string U_STAT { get; set; }

        public string U_APEPAT { get; set; }

        public string U_APEMAT { get; set; }

        public string U_NOMP { get; set; }

        [StringLength(8)]
        public string U_TNOE { get; set; }

        [StringLength(8)]
        public string U_CAT { get; set; }

        public string U_ECI { get; set; }

        public string U_SEX { get; set; }

        public string U_IMPEST { get; set; }

        public string U_IFAVAC { get; set; }

        public short? U_EVAC { get; set; }

        public string U_TCCE { get; set; }

        public string U_HOR { get; set; }

        [StringLength(1)]
        public string U_FPA { get; set; }

        [StringLength(8)]
        public string U_BAN { get; set; }

        public string U_SUCB { get; set; }

        public string U_CTAB { get; set; }

        [StringLength(8)]
        public string U_CRE1 { get; set; }

        [StringLength(8)]
        public string U_CRE2 { get; set; }

        [StringLength(8)]
        public string U_CRE3 { get; set; }

        [StringLength(8)]
        public string U_CRE4 { get; set; }

        [StringLength(8)]
        public string U_CRE5 { get; set; }

        [StringLength(8)]
        public string U_CRE6 { get; set; }

        [StringLength(8)]
        public string U_CRE7 { get; set; }

        [StringLength(8)]
        public string U_CRE8 { get; set; }

        public DateTime? U_FIN { get; set; }

        public DateTime? U_FAN { get; set; }

        public DateTime? U_FVC { get; set; }

        public DateTime? U_FPL { get; set; }

        public DateTime? U_FAP { get; set; }

        public DateTime? U_FNAC { get; set; }

        public DateTime? U_FCS { get; set; }

        public DateTime? U_FTR { get; set; }

        public DateTime? U_FR { get; set; }

        [StringLength(8)]
        public string U_MCAM { get; set; }

        [StringLength(10)]
        public string U_TCO { get; set; }

        [StringLength(8)]
        public string U_TUR { get; set; }

        [StringLength(8)]
        public string U_CIA { get; set; }

        [StringLength(8)]
        public string U_LOC { get; set; }

        [StringLength(8)]
        public string U_DIR { get; set; }

        [StringLength(8)]
        public string U_DEP { get; set; }

        [StringLength(8)]
        public string U_PUE { get; set; }

        public short? U_NTB { get; set; }

        [StringLength(8)]
        public string U_CTSUE { get; set; }

        public string U_EMPSUP { get; set; }

        public string U_EMPSUP2 { get; set; }

        public string U_STPR { get; set; }

        public string U_NIVJ { get; set; }

        [StringLength(8)]
        public string U_CRP { get; set; }

        [StringLength(8)]
        public string U_CCOS { get; set; }

        [StringLength(8)]
        public string U_PROY { get; set; }

        public string U_ZSM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SUE { get; set; }

        public string U_TSUE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SDI { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SIST { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SFIJ { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SVAR { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_INTF { get; set; }

        public string U_CICA { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IRE1 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IRE2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_BONO { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SN { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SPRO { get; set; }

        [StringLength(13)]
        public string U_RFC { get; set; }

        [StringLength(18)]
        public string U_CURP { get; set; }

        [StringLength(11)]
        public string U_IMSS { get; set; }

        [StringLength(1)]
        public string U_TS { get; set; }

        public string U_CLNA { get; set; }

        public short? U_UMF { get; set; }

        public short? U_JR { get; set; }

        public string U_AFO { get; set; }

        public string U_NCON { get; set; }

        public string U_DOM { get; set; }

        public string U_COL { get; set; }

        public string U_DEL { get; set; }

        public string U_EDO { get; set; }

        public string U_CODP { get; set; }

        public string U_PAIS { get; set; }

        public string U_TELDOM { get; set; }

        public string U_TELCEL { get; set; }

        public string U_TELOFI { get; set; }

        public string U_TELREC { get; set; }

        public string U_EMAIL { get; set; }

        public DateTime? U_FBJ { get; set; }

        [StringLength(8)]
        public string U_MBAJ { get; set; }

        public DateTime? U_FREN { get; set; }

        public DateTime? U_FEBAJ { get; set; }

        public string U_STTER { get; set; }

        [StringLength(8)]
        public string U_NIVESC { get; set; }

        [StringLength(8)]
        public string U_PROF { get; set; }

        [StringLength(8)]
        public string U_NACIO { get; set; }

        public string U_NOMGAF { get; set; }

        public short? U_SECC { get; set; }

        public string U_LDAP { get; set; }

        public string U_PWDLDAP { get; set; }

        public string U_THOR { get; set; }

        public string U_EMP2 { get; set; }

        public string U_EMPPG { get; set; }

        public string U_PATS { get; set; }

        public string U_ROL { get; set; }

        public string U_FUNC { get; set; }

        public string U_TDEP { get; set; }

        public string U_ZONA { get; set; }

        public string U_PROYCTE { get; set; }

        public string U_CBCTE { get; set; }

        public string U_LOCCTE { get; set; }

        public string U_DEPCTE { get; set; }

        public string U_CTACTE { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_DBANT { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_VBANT { get; set; }

        public string U_CTAV { get; set; }

        public DateTime? U_FNVC { get; set; }

        public string U_TCTAB { get; set; }

        public string U_SUB { get; set; }

        public DateTime? U_PFE { get; set; }

        public string U_ATI { get; set; }

        public string U_DURPZA { get; set; }

        public string U_PZASUP { get; set; }

        [StringLength(8)]
        public string U_PZA { get; set; }

        public short? U_NTBBON { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_PTJAUM { get; set; }

        public string U_LUGVAL { get; set; }

        public string U_TIPEV { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_SUED { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_IFV { get; set; }

        [StringLength(18)]
        public string U_LIC { get; set; }

        public DateTime? U_FVLIC { get; set; }

        public DateTime? U_FILIC { get; set; }

        public DateTime? U_FR2 { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? U_CALFN { get; set; }

        public string U_CALFA { get; set; }

        public string U_NUMEXT { get; set; }

        public string U_NUMINT { get; set; }

        [StringLength(18)]
        public string U_CLABE { get; set; }

        [StringLength(1024)]
        public string U_COMBAJ { get; set; }

        [StringLength(8)]
        public string U_UNIV { get; set; }

        [StringLength(8)]
        public string U_GRAESC { get; set; }

        [StringLength(8)]
        public string U_PERESC { get; set; }

        [StringLength(8)]
        public string U_SITESC { get; set; }

        [StringLength(8)]
        public string U_INI { get; set; }

        [StringLength(8)]
        public string U_BAN2 { get; set; }

        [StringLength(20)]
        public string U_CTAB2 { get; set; }

        [StringLength(18)]
        public string U_CLABE2 { get; set; }

        [StringLength(8)]
        public string U_PZABANX { get; set; }

        [StringLength(8)]
        public string U_BANRECEP { get; set; }

        [StringLength(1)]
        public string U_STATN { get; set; }

        public DateTime? U_FFIR { get; set; }

        public DateTime? U_FACTDP { get; set; }

        [StringLength(8)]
        public string U_PROF2 { get; set; }

        [StringLength(30)]
        public string U_DIRACTIV { get; set; }

        [StringLength(1)]
        public string U_TIPUSU { get; set; }
    }
}
