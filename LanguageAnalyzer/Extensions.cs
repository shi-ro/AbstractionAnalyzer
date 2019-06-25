using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LanguageAnalyzer
{
    public static class Extensions
    {
        public static string RemovePunctuation(this string s)
        {
            string pat = @"[\.,\?!;:\(\)""']";
            Regex r = new Regex(pat);
            return r.Replace(s, "");
        }

        public static bool Contains(this string s ,string [] ev)
        {
            for(int i = 0; i < ev.Length; i++)
            {
                if(!s.Contains(ev[i]))
                {
                    return false;
                }
            }
            return true;
        }

        public static WordClassification ComputeAbstraction(this string w)
        {
            return GlobalNetworks.GetRootsNetwork().Compute(RootBreaker.BreakWord(w).SignificantRoots(2).GetVals())[0]>0.5?WordClassification.Abstract:WordClassification.Physical;
        }

        public static double GetVal(this Root root)
        {
            //if (root == Root.AN)
            //{
            //    return 1;
            //}

            //if (root == Root.AC || root == Root.AD)
            //{
            //    return 4;
            //}

            if (root == Root.ACRO)
            {
                return 5; 
            }

            if (root == Root.ACT)
            {
                return 6;
            }

            if (root == Root.AER || root == Root.AERO)
            {
                return 7;
            }

            if (root == Root.AGR || root == Root.AGRI || root == Root.AGRO)
            {
                return 8;
            }

            if (root == Root.ALG || root == Root.ALGO)
            {
                return 9;
            }

            if (root == Root.AMBI || root == Root.AMPHI)
            {
                return 10;
            }

            if (root == Root.AMBUL)
            {
                return 11;
            }

            if (root == Root.AMI || root == Root.AMIO)
            {
                return 12;
            }

            if (root == Root.ANA)
            {
                return 13;
            }

            if (root == Root.ANDR || root == Root.ANDRO)
            {
                return 14;
            }

            if (root == Root.ANIM)
            {
                return 15;
            }

            if (root == Root.ANN || root == Root.ANNENN)
            {
                return 16;
            }

            if (root == Root.ANTE)
            {
                return 17;
            }

            if (root == Root.ANTH || root == Root.ANTHO)
            {
                return 18;
            }

            if (root == Root.ANTHROP || root == Root.ANTHROPO)
            {
                return 19;
            }

            if (root == Root.ANTI)
            {
                return 20;
            }

            if (root == Root.APO || root == Root.APHO)
            {
                return 21;
            }

            if (root == Root.AQU || root == Root.AQUA)
            {
                return 22;
            }

            if (root == Root.ARBOR)
            {
                return 23;
            }

            if (root == Root.ARCH || root == Root.ARCHI)
            {
                return 24;
            }

            if (root == Root.ARCH || root == Root.ARCHA || root == Root.ARCHI)
            {
                return 25;
            }

            if (root == Root.ARTHR || root == Root.ARTHRO)
            {
                return 26;
            }

            if (root == Root.ART)
            {
                return 27;
            }

            if (root == Root.ASTRO || root == Root.ASTER)
            {
                return 28;
            }

            if (root == Root.AUD || root == Root.AUDI || root == Root.AUDIO)
            {
                return 29;
            }

            if (root == Root.AUTO)
            {
                return 30;
            }

            if (root == Root.AVI || root == Root.AVIA)
            {
                return 31;
            }

            if (root == Root.BAR || root == Root.BARO)
            {
                return 32;
            }

            if (root == Root.BELL || root == Root.BELLI)
            {
                return 33;
            }

            if (root == Root.BENE)
            {
                return 34;
            }

            if (root == Root.BIN) // || root == Root.BI)
            {
                return 35;
            }

            if (root == Root.BIBLI || root == Root.BIBLIO)
            {
                return 36;
            }

            if (root == Root.BIO)
            {
                return 37;
            }

            if (root == Root.BLAST || root == Root.BLASTO)
            {
                return 38;
            }

            if (root == Root.BURS)
            {
                return 39;
            }

            if (root == Root.CALC)
            {
                return 40;
            }

            if (root == Root.CAND)
            {
                return 41;
            }

            if (root == Root.CAPT || root == Root.CEPT || root == Root.CEIVE)
            {
                return 42;
            }

            if (root == Root.CARDI || root == Root.CARDIO)
            {
                return 43;
            }

            if (root == Root.CARN || root == Root.CARNI)
            {
                return 44;
            }

            if (root == Root.CATA)
            {
                return 45;
            }

            if (root == Root.CAUST || root == Root.CAUT)
            {
                return 46;
            }

            if (root == Root.CEDE || root == Root.CEED || root == Root.CESS)
            {
                return 47;
            }

            if (root == Root.CELER)
            {
                return 48;
            }

            if (root == Root.CENT || root == Root.CENTI)
            {
                return 49;
            }

            if (root == Root.CENTR || root == Root.CENTRO || root == Root.CENTRI)
            {
                return 50;
            }

            if (root == Root.CEPHAL || root == Root.CEPHALO)
            {
                return 51;
            }

            if (root == Root.CEREBR || root == Root.CEREBRO)
            {
                return 52;
            }

            if (root == Root.CERT)
            {
                return 53;
            }

            if (root == Root.CHROM || root == Root.CHROMO || root == Root.CHROMAT || root == Root.CHROMATO || root == Root.CHROS)
            {
                return 54;
            }

            if (root == Root.CHRON || root == Root.CHRONO)
            {
                return 55;
            }

            if (root == Root.CHRYS || root == Root.CHRYSO)
            {
                return 56;
            }

            if (root == Root.CIDE || root == Root.CISE)
            {
                return 57;
            }

            if (root == Root.CIRCUM || root == Root.CIRCLE)
            {
                return 58;
            }

            if (root == Root.CLAIM || root == Root.CLAM)
            {
                return 59;
            }

            if (root == Root.CLAR)
            {
                return 60;
            }

            if (root == Root.CLUD || root == Root.CLUS)
            {
                return 61;
            }

            if (root == Root.CLINE)
            {
                return 62;
            }

            //if (root == Root.CO)
            //{
            //    return 63;
            //}

            if (root == Root.COL)
            {
                return 64;
            }

            if (root == Root.COM)
            {
                return 65;
            }

            if (root == Root.COGN || root == Root.COGNI)
            {
                return 66;
            }

            if (root == Root.CON)
            {
                return 67;
            }

            if (root == Root.CONTRA || root == Root.CONTRAO)
            {
                return 68;
            }

            if (root == Root.CORP || root == Root.CORPO)
            {
                return 69;
            }

            if (root == Root.COSM || root == Root.COSMO)
            {
                return 70;
            }

            if (root == Root.COUNTER)
            {
                return 71;
            }

            if (root == Root.CRANIO)
            {
                return 72;
            }

            if (root == Root.CRED)
            {
                return 73;
            }

            if (root == Root.CRUC)
            {
                return 74;
            }

            if (root == Root.CRYPTO)
            {
                return 75;
            }

            if (root == Root.CUMUL)
            {
                return 76;
            }

            if (root == Root.CURR || root == Root.CURS)
            {
                return 77;
            }

            if (root == Root.CYCL)
            {
                return 78;
            }

            if (root == Root.DE)
            {
                return 79;
            }

            if (root == Root.DEC || root == Root.DECA || root == Root.DEKA)
            {
                return 80;
            }

            if (root == Root.DECI)
            {
                return 81;
            }

            if (root == Root.DEM || root == Root.DEMO)
            {
                return 82;
            }

            if (root == Root.DEMI)
            {
                return 83;
            }

            if (root == Root.DENDR || root == Root.DENDRO || root == Root.DENDRI)
            {
                return 84;
            }

            if (root == Root.DENT || root == Root.DONT)
            {
                return 85;
            }

            if (root == Root.DERM || root == Root.DERMA)
            {
                return 86;
            }

            if (root == Root.DI || root == Root.DIPLO)
            {
                return 87;
            }

            if (root == Root.DI || root == Root.DIS)
            {
                return 88;
            }

            if (root == Root.DIA)
            {
                return 89;
            }

            if (root == Root.DICT)
            {
                return 90;
            }

            if (root == Root.DOMIN)
            {
                return 91;
            }

            if (root == Root.DON || root == Root.DONAT)
            {
                return 92;
            }

            if (root == Root.DUC || root == Root.DUCT)
            {
                return 93;
            }

            if (root == Root.DU || root == Root.DUO)
            {
                return 94;
            }

            if (root == Root.DUR)
            {
                return 95;
            }

            if (root == Root.DYN || root == Root.DYNA || root == Root.DYNAM)
            {
                return 96;
            }

            if (root == Root.DYS)
            {
                return 97;
            }

            if (root == Root.EGO)
            {
                return 99;
            }

            //if (root == Root.EM || root == Root.EN)
            //{
            //    return 100;
            //}

            if (root == Root.ENDO)
            {
                return 101;
            }

            if (root == Root.ENN || root == Root.ENNI || root == Root.ANNI)
            {
                return 102;
            }

            //if (root == Root.EN || root == Root.IN)
            //{
            //    return 103;
            //}

            if (root == Root.EPI) // || root == Root.EP )
            {
                return 104;
            }

            if (root == Root.EQU || root == Root.EQUI)
            {
                return 105;
            }

            if (root == Root.ERG || root == Root.ERGO)
            {
                return 106;
            }

            if (root == Root.ESTH || root == Root.ESTHAESTH)
            {
                return 107;
            }

            if (root == Root.ETHNO)
            {
                return 108;
            }

            //if (root == Root.EU)
            //{
            //    return 109;
            //}

            //if (root == Root.EX)
            //{
            //    return 110;
            //}

            if (root == Root.EXTRA || root == Root.EXTRO)
            {
                return 111;
            }

            if (root == Root.FAC || root == Root.FACT)
            {
                return 112;
            }

            if (root == Root.FER)
            {
                return 113;
            }

            if (root == Root.FID)
            {
                return 114;
            }

            if (root == Root.FLECT)
            {
                return 115;
            }

            if (root == Root.FLOR || root == Root.FLORA || root == Root.FLEUR)
            {
                return 116;
            }

            if (root == Root.FOR)
            {
                return 117;
            }

            if (root == Root.FORE)
            {
                return 118;
            }

            if (root == Root.FORM)
            {
                return 119;
            }

            if (root == Root.FRACT || root == Root.FRAG)
            {
                return 120;
            }

            if (root == Root.FUG)
            {
                return 121;
            }

            if (root == Root.FUNCT)
            {
                return 122;
            }

            if (root == Root.FUS)
            {
                return 123;
            }

            if (root == Root.GASTR || root == Root.GASTRO)
            {
                return 124;
            }

            if (root == Root.GEN || root == Root.GENO || root == Root.GENE || root == Root.GENGENESIS)
            {
                return 125;
            }

            if (root == Root.GEO)
            {
                return 126;
            }

            if (root == Root.GER)
            {
                return 127;
            }

            if (root == Root.GIGA)
            {
                return 128;
            }

            if (root == Root.GON)
            {
                return 129;
            }

            if (root == Root.GRAM)
            {
                return 130;
            }

            if (root == Root.GRAN)
            {
                return 131;
            }

            if (root == Root.GRAPH || root == Root.GRAPHY)
            {
                return 132;
            }

            if (root == Root.GRAT)
            {
                return 133;
            }

            if (root == Root.GYN || root == Root.GYNO || root == Root.GYNE)
            {
                return 134;
            }

            if (root == Root.GRESS || root == Root.GRAD || root == Root.GRADE || root == Root.GRADI)
            {
                return 135;
            }

            if (root == Root.HECT || root == Root.HECTO || root == Root.HECAT)
            {
                return 136;
            }

            if (root == Root.HELIC || root == Root.HELICO)
            {
                return 137;
            }

            if (root == Root.HELI || root == Root.HELIO)
            {
                return 138;
            }

            if (root == Root.HEMI)
            {
                return 139;
            }

            if (root == Root.HEM || root == Root.HEMO || root == Root.HEMA)
            {
                return 140;
            }

            if (root == Root.HEPA)
            {
                return 141;
            }

            if (root == Root.HEPT || root == Root.HEPTA)
            {
                return 142;
            }

            if (root == Root.HERBI)
            {
                return 143;
            }

            if (root == Root.HETERO)
            {
                return 144;
            }

            if (root == Root.HEX || root == Root.HEXA)
            {
                return 145;
            }

            if (root == Root.HISTO)
            {
                return 146;
            }

            if (root == Root.HOMO || root == Root.HOMEO)
            {
                return 147;
            }

            if (root == Root.HYDR || root == Root.HYDRO)
            {
                return 148;
            }

            if (root == Root.HYGR || root == Root.HYGRO)
            {
                return 149;
            }

            if (root == Root.HYPER)
            {
                return 150;
            }

            if (root == Root.HYP || root == Root.HYPO)
            {
                return 151;
            }

            if (root == Root.IATR || root == Root.IATRO)
            {
                return 152;
            }

            if (root == Root.ICON || root == Root.ICONO)
            {
                return 153;
            }

            if (root == Root.IDIO)
            {
                return 154;
            }

            //if (root == Root.IL || root == Root.IN)
            //{
            //    return 155;
            //}

            //if (root == Root.IG || root == Root.IL || root == Root.IM || root == Root.IN || root == Root.IR)
            //{
            //    return 156;
            //}

            if (root == Root.IMAG)
            {
                return 157;
            }

            if (root == Root.INFRA)
            {
                return 158;
            }

            if (root == Root.INTER)
            {
                return 159;
            }

            if (root == Root.INTRA || root == Root.INTRO)
            {
                return 160;
            }

            //if (root == Root.IR)
            //{
            //    return 161;
            //}

            if (root == Root.ISO)
            {
                return 162;
            }

            if (root == Root.JECT)
            {
                return 163;
            }

            if (root == Root.JUD)
            {
                return 164;
            }

            if (root == Root.JUNCT)
            {
                return 165;
            }

            if (root == Root.JUVEN)
            {
                return 166;
            }

            if (root == Root.KILO)
            {
                return 167;
            }

            if (root == Root.KINE || root == Root.KINET || root == Root.KINEMAT)
            {
                return 168;
            }

            if (root == Root.LAB)
            {
                return 169;
            }

            if (root == Root.LACT || root == Root.LACTO)
            {
                return 170;
            }

            if (root == Root.LATER)
            {
                return 171;
            }

            if (root == Root.LEUK || root == Root.LEUKO || root == Root.LEUC || root == Root.LEUCO)
            {
                return 172;
            }

            if (root == Root.LEX)
            {
                return 173;
            }

            if (root == Root.LIBER)
            {
                return 174;
            }

            if (root == Root.LINGU)
            {
                return 175;
            }

            if (root == Root.LIP || root == Root.LIPO)
            {
                return 176;
            }

            if (root == Root.LITE || root == Root.ITE || root == Root.LITH || root == Root.LITHO)
            {
                return 177;
            }

            if (root == Root.LOC)
            {
                return 178;
            }

            if (root == Root.LOG || root == Root.LOGO)
            {
                return 179;
            }

            if (root == Root.LOQU || root == Root.LOCU)
            {
                return 180;
            }

            if (root == Root.LUC)
            {
                return 181;
            }

            if (root == Root.LUD || root == Root.LUS)
            {
                return 182;
            }

            if (root == Root.LUMIN)
            {
                return 183;
            }

            if (root == Root.LUN || root == Root.LUNA || root == Root.LUNI)
            {
                return 184;
            }

            if (root == Root.MACRO)
            {
                return 185;
            }

            if (root == Root.MAGN || root == Root.MAGNA || root == Root.MAGNI)
            {
                return 186;
            }

            if (root == Root.MAL || root == Root.MALE)
            {
                return 187;
            }

            if (root == Root.MAN || root == Root.MANI || root == Root.MANU)
            {
                return 188;
            }

            if (root == Root.MAND)
            {
                return 189;
            }

            if (root == Root.MANIA)
            {
                return 190;
            }

            if (root == Root.MAR || root == Root.MARI)
            {
                return 191;
            }

            if (root == Root.MATER || root == Root.MATR || root == Root.MATRI)
            {
                return 192;
            }

            if (root == Root.MAX)
            {
                return 193;
            }

            if (root == Root.MEDI)
            {
                return 194;
            }

            if (root == Root.MEGA)
            {
                return 195;
            }

            if (root == Root.MELAN || root == Root.MELANO)
            {
                return 196;
            }

            if (root == Root.MEMOR || root == Root.MEMORI)
            {
                return 197;
            }

            if (root == Root.MERGE || root == Root.MERS)
            {
                return 198;
            }

            if (root == Root.MESO)
            {
                return 199;
            }

            if (root == Root.META)
            {
                return 200;
            }

            if (root == Root.METER || root == Root.METR || root == Root.METRY)
            {
                return 201;
            }

            if (root == Root.MICRO)
            {
                return 202;
            }

            if (root == Root.MID)
            {
                return 203;
            }

            if (root == Root.MIGR)
            {
                return 204;
            }

            if (root == Root.MILLI)
            {
                return 205;
            }

            if (root == Root.MIN || root == Root.MINI)
            {
                return 206;
            }

            if (root == Root.MIS || root == Root.MISO)
            {
                return 207;
            }

            if (root == Root.MISS || root == Root.MIT)
            {
                return 208;
            }

            if (root == Root.MOB)
            {
                return 209;
            }

            if (root == Root.MON || root == Root.MONO)
            {
                return 210;
            }

            if (root == Root.MOT || root == Root.MOV)
            {
                return 211;
            }

            if (root == Root.MORPH || root == Root.MORPHO)
            {
                return 212;
            }

            if (root == Root.MORT)
            {
                return 213;
            }

            if (root == Root.MULTI)
            {
                return 214;
            }

            if (root == Root.MUT)
            {
                return 215;
            }

            if (root == Root.MYO) // || root == Root.MY )
            {
                return 216;
            }

            if (root == Root.NARR)
            {
                return 217;
            }

            if (root == Root.NAT)
            {
                return 218;
            }

            if (root == Root.NAV)
            {
                return 219;
            }

            if (root == Root.NECR || root == Root.NECRO)
            {
                return 220;
            }

            if (root == Root.NEG)
            {
                return 221;
            }

            if (root == Root.NEO)
            {
                return 222;
            }

            if (root == Root.NEPHR || root == Root.NEPHRO)
            {
                return 223;
            }

            if (root == Root.NEUR || root == Root.NEURO)
            {
                return 224;
            }

            if (root == Root.NOM || root == Root.NOMIN)
            {
                return 225;
            }

            if (root == Root.NON)
            {
                return 226;
            }

            if (root == Root.NOT)
            {
                return 227;
            }

            if (root == Root.NOUN || root == Root.NUNC)
            {
                return 228;
            }

            if (root == Root.NOV)
            {
                return 229;
            }

            if (root == Root.NUMER)
            {
                return 230;
            }

            //if (root == Root.OB || root == Root.OP)
            //{
            //    return 231;
            //}

            if (root == Root.OCT || root == Root.OCTA || root == Root.OCTO)
            {
                return 232;
            }

            if (root == Root.OCU)
            {
                return 233;
            }

            //if (root == Root.OD)
            //{
            //    return 234;
            //}

            if (root == Root.ODOR)
{
                return 235;
            }

            if (root == Root.OMNI)
            {
                return 236;
            }

            if ( root == Root.OPT || root == Root.OPS) // || root == Root.OP )
            {
                return 237;
            }

            if (root == Root.OPT)
            {
                return 238;
            }

            if (root == Root.ORTHO)
            {
                return 239;
            }

            if (root == Root.OSTEO)
            {
                return 240;
            }

            if (root == Root.OUT)
            {
                return 241;
            }

            if (root == Root.OVER)
            {
                return 242;
            }

            if (root == Root.OXI || root == Root.OXIOXY)
            {
                return 243;
            }

            if (root == Root.PALE || root == Root.PALEO)
            {
                return 244;
            }

            if (root == Root.PAN)
            {
                return 245;
            }

            if (root == Root.PARA)
            {
                return 246;
            }

            if (root == Root.PARA)
            {
                return 247;
            }

            if (root == Root.PATER || root == Root.PATR || root == Root.PATRI)
            {
                return 248;
            }

            if (root == Root.PATH)
            {
                return 249;
            }

            if (root == Root.PED || root == Root.PEDI || root == Root.PEDE)
            {
                return 250;
            }

            if (root == Root.PEL)
            {
                return 251;
            }

            if (root == Root.PENT || root == Root.PENTA)
            {
                return 252;
            }

            if (root == Root.PEPT || root == Root.PEPS)
            {
                return 253;
            }

            if (root == Root.PER)
            {
                return 254;
            }

            if (root == Root.PERI)
            {
                return 255;
            }

            if (root == Root.PHAG || root == Root.PHAGE)
            {
                return 256;
            }

            if (root == Root.PHIL || root == Root.PHILO)
            {
                return 257;
            }

            if (root == Root.PHON || root == Root.PHONO || root == Root.PHONE || root == Root.PHONY)
            {
                return 258;
            }

            if (root == Root.PHOT || root == Root.PHOTO)
            {
                return 259;
            }

            if (root == Root.PHYLL || root == Root.PHYLLO)
            {
                return 260;
            }

            if (root == Root.PHYS)
            {
                return 261;
            }

            if (root == Root.PHYT || root == Root.PHYTO || root == Root.PHYTE)
            {
                return 262;
            }

            if (root == Root.PLAS || root == Root.PLAST || root == Root.PLASM)
            {
                return 263;
            }

            if (root == Root.PLAUD || root == Root.PLOD || root == Root.PLAUS || root == Root.PLOS)
            {
                return 264;
            }

            if (root == Root.PNEUM || root == Root.PNEUMO)
            {
                return 265;
            }

            if (root == Root.POD || root == Root.PODE)
            {
                return 266;
            }

            if (root == Root.POLI)
            {
                return 267;
            }

            if (root == Root.POLY)
            {
                return 268;
            }

            if (root == Root.PON)
            {
                return 269;
            }

            if (root == Root.POP)
            {
                return 270;
            }

            if (root == Root.PORT)
            {
                return 271;
            }

            if (root == Root.POS)
            {
                return 272;
            }

            if (root == Root.POST)
            {
                return 273;
            }

            if (root == Root.PRE)
            {
                return 274;
            }

            if (root == Root.PRO)
            {
                return 275;
            }

            if (root == Root.PROT || root == Root.PROTO)
            {
                return 276;
            }

            if (root == Root.PSEUD || root == Root.PSEUDO)
            {
                return 277;
            }

            if (root == Root.PSYCH || root == Root.PSYCHO)
            {
                return 278;
            }

            if (root == Root.PUGN || root == Root.PUGNA || root == Root.PUNG)
            {
                return 279;
            }

            if (root == Root.PUL)
            {
                return 280;
            }

            if (root == Root.PURG)
            {
                return 281;
            }

            if (root == Root.PUT)
            {
                return 282;
            }

            if (root == Root.PYR || root == Root.PYRO)
            {
                return 283;
            }

            if (root == Root.QUAD || root == Root.QUADR || root == Root.QUADRI)
            {
                return 284;
            }

            if (root == Root.QUART)
            {
                return 285;
            }

            if (root == Root.QUIN || root == Root.QUINT)
            {
                return 286;
            }

            if (root == Root.RADIC || root == Root.RADIX)
            {
                return 287;
            }

            if (root == Root.RADIO)
            {
                return 288;
            }

            if (root == Root.RAM || root == Root.RAMI)
            {
                return 289;
            }

            //if (root == Root.RE)
            //{
            //    return 290;
            //}

            if (root == Root.REG)
            {
                return 291;
            }

            if (root == Root.RETRO)
            {
                return 292;
            }

            if (root == Root.RHIN || root == Root.RHINO)
            {
                return 293;
            }

            if (root == Root.RHOD || root == Root.RHODO)
            {
                return 294;
            }

            if (root == Root.RID)
            {
                return 295;
            }

            if (root == Root.RRH || root == Root.RRHEA || root == Root.RRHOEA || root == Root.RRHAG)
            {
                return 296;
            }

            if (root == Root.RUB)
            {
                return 297;
            }

            if (root == Root.RUPT)
            {
                return 298;
            }

            if (root == Root.SAN)
            {
                return 299;
            }

            if (root == Root.SCEND)
            {
                return 300;
            }

            if (root == Root.SCI)
            {
                return 301;
            }

            if (root == Root.SCLER || root == Root.SCLERO)
            {
                return 302;
            }

            if (root == Root.SCOP || root == Root.SCOPE || root == Root.SCOPY)
            {
                return 303;
            }

            if (root == Root.SCRIB || root == Root.SCRIPT)
            {
                return 304;
            }

            //if (root == Root.SE)
            //{
            //    return 305;
            //}

            if (root == Root.SECT)
            {
                return 306;
            }

            if (root == Root.SED || root == Root.SID || root == Root.SESS)
            {
                return 307;
            }

            if (root == Root.SELF)
            {
                return 308;
            }

            if (root == Root.SEMI)
            {
                return 309;
            }

            if (root == Root.SEPT || root == Root.SEPTI)
            {
                return 310;
            }

            if (root == Root.SERV)
            {
                return 311;
            }

            if (root == Root.SEX)
            {
                return 312;
            }

            if (root == Root.SOL)
            {
                return 313;
            }

            if (root == Root.SOL)
            {
                return 314;
            }

            if (root == Root.SOMN || root == Root.SOMNI)
            {
                return 315;
            }

            if (root == Root.SON)
            {
                return 316;
            }

            if (root == Root.SOPH)
            {
                return 317;
            }

            if (root == Root.SPEC || root == Root.SPECT || root == Root.SPIC)
            {
                return 318;
            }

            if (root == Root.SPHERE)
            {
                return 319;
            }

            if (root == Root.SPIR)
            {
                return 320;
            }

            if (root == Root.STA)
            {
                return 321;
            }

            if (root == Root.STELL)
            {
                return 322;
            }

            if (root == Root.STRUCT)
            {
                return 323;
            }

            if (root == Root.SUB)
            {
                return 324;
            }

            if (root == Root.SUM)
            {
                return 325;
            }

            if (root == Root.SUPER)
            {
                return 326;
            }

            if (root == Root.SYM || root == Root.SYN || root == Root.SYL || root == Root.SYS) // root == Root.SY )
            {
                return 327;
            }

            if (root == Root.TACT || root == Root.TANG)
            {
                return 328;
            }

            if (root == Root.TAX || root == Root.TAXO)
            {
                return 329;
            }

            if (root == Root.TECHNO)
            {
                return 330;
            }

            if (root == Root.TEL || root == Root.TELE || root == Root.TELO)
            {
                return 331;
            }

            if (root == Root.TEMP || root == Root.TEMPOR)
            {
                return 332;
            }

            if (root == Root.TEN || root == Root.TIN || root == Root.TENT)
            {
                return 333;
            }

            if (root == Root.TER || root == Root.TRIT)
            {
                return 334;
            }

            if (root == Root.TERM || root == Root.TERMINA)
            {
                return 335;
            }

            if (root == Root.TERR || root == Root.TERRA || root == Root.TERRI)
            {
                return 336;
            }

            if (root == Root.TETRA)
            {
                return 337;
            }

            if (root == Root.THE)
            {
                return 338;
            }

            if (root == Root.THE || root == Root.THEO)
            {
                return 339;
            }

            if (root == Root.THERM || root == Root.THERMO)
            {
                return 340;
            }

            if (root == Root.TORT)
            {
                return 341;
            }

            if (root == Root.TOX)
            {
                return 342;
            }

            if (root == Root.TRACT)
            {
                return 343;
            }

            if (root == Root.TRANS)
            {
                return 344;
            }

            if (root == Root.TRI)
            {
                return 345;
            }

            if (root == Root.ULTRA)
            {
                return 346;
            }

            //if (root == Root.UN)
            //{
            //    return 347;
            //}

            if (root == Root.UNI)
            {
                return 348;
            }

            if (root == Root.URB)
            {
                return 349;
            }

            if (root == Root.VAC)
            {
                return 350;
            }

            if (root == Root.VEN || root == Root.VENT)
            {
                return 351;
            }

            if (root == Root.VER || root == Root.VERI)
            {
                return 352;
            }

            if (root == Root.VERB)
            {
                return 353;
            }

            if (root == Root.VERS || root == Root.VERT)
            {
                return 354;
            }

            if (root == Root.VICE)
            {
                return 355;
            }

            if (root == Root.VID)
            {
                return 356;
            }

            if (root == Root.VINCE || root == Root.VIC)
            {
                return 357;
            }

            if (root == Root.VIS || root == Root.VID)
            {
                return 358;
            }

            if (root == Root.VIV || root == Root.VIVI || root == Root.VIT)
            {
                return 359;
            }

            if (root == Root.VOC || root == Root.VOCI)
            {
                return 360;
            }

            if (root == Root.VOL || root == Root.VOLI || root == Root.VOLU)
            {
                return 361;
            }

            if (root == Root.VOR || root == Root.VOUR)
            {
                return 362;
            }

            if (root == Root.XANTH)
            {
                return 363;
            }

            if (root == Root.XEN || root == Root.XENO)
            {
                return 364;
            }

            if (root == Root.XER || root == Root.XERO || root == Root.XERI)
            {
                return 365;
            }

            if (root == Root.XYL)
            {
                return 366;
            }

            if ( root == Root.ZOO) // || root == Root.ZO )
            {
                return 367;
            }

            if (root == Root.ZYG || root == Root.ZYGO)
            {
                return 368;
            }

            return 0;
        }

        public static double[] GetVals(this Root[] roots)
        {
            double[] ret = new double[roots.Length];
            for( int i = 0; i < ret.Length; i++)
            {
                ret[i] = roots[i].GetVal();
            }
            return ret;
        }

        public static Root[] SignificantRoots(this List<Root> roots, int amt)
        {
            Root[] op = new Root[roots.Count];
            for (int i = 0; i < roots.Count; i++)
            {
                op[i] = roots[i];
            }
            Root[] ret = new Root[amt];
            for (int i = 0; i < amt; i++)
            {
                ret[i] = Root.NONE;
            }

            int N = roots.Count;

            for (int i = 1; i < N; i++)
            {
                int j = i - 1;
                Root temp = roots[i];

                while (j >= 0 && $"{temp}".Length < $"{roots[j]}".Length)
                {
                    roots[j + 1] = roots[j];
                    j--;
                }

                roots[j + 1] = temp;
            }

            roots.Reverse();

            for (int i = 0; i < amt && i < roots.Count; i++)
            {
                ret[i] = roots[i];
            }

            return ret;
        }
    }
}
