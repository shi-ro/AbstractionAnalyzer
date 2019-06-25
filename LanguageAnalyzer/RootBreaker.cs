using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageAnalyzer
{
    public static class RootBreaker
    {
        public static List<Root> BreakWord(string word)
        {
            word = word.ToLower();

            List<Root> roots = new List<Root>();
            
            //if (word.Contains("an"))
            //{
            //    roots.Add(Root.AN);
            //}

            //if (word.Contains("ac"))
            //{
            //    roots.Add(Root.AC);
            //}

            //if (word.Contains("ad"))
            //{
            //    roots.Add(Root.AD);
            //}

            if (word.Contains("acro"))
            {
                roots.Add(Root.ACRO);
            }

            if (word.Contains("act"))
            {
                roots.Add(Root.ACT);
            }

            if (word.Contains("aer"))
            {
                roots.Add(Root.AER);
            }

            if (word.Contains("aero"))
            {
                roots.Add(Root.AERO);
            }

            if (word.Contains("agr"))
            {
                roots.Add(Root.AGR);
            }

            if (word.Contains("agri"))
            {
                roots.Add(Root.AGRI);
            }

            if (word.Contains("agro"))
            {
                roots.Add(Root.AGRO);
            }

            if (word.Contains("alg"))
            {
                roots.Add(Root.ALG);
            }

            if (word.Contains("algo"))
            {
                roots.Add(Root.ALGO);
            }

            if (word.Contains("ambi"))
            {
                roots.Add(Root.AMBI);
            }

            if (word.Contains("amphi"))
            {
                roots.Add(Root.AMPHI);
            }

            if (word.Contains("ambul"))
            {
                roots.Add(Root.AMBUL);
            }

            if (word.Contains("ami"))
            {
                roots.Add(Root.AMI);
            }

            if (word.Contains("amio"))
            {
                roots.Add(Root.AMIO);
            }

            if (word.Contains("ana"))
            {
                roots.Add(Root.ANA);
            }

            if (word.Contains("andr"))
            {
                roots.Add(Root.ANDR);
            }

            if (word.Contains("andro"))
            {
                roots.Add(Root.ANDRO);
            }

            if (word.Contains("anim"))
            {
                roots.Add(Root.ANIM);
            }

            if (word.Contains("ann"))
            {
                roots.Add(Root.ANN);
            }

            if (word.Contains("annenn"))
            {
                roots.Add(Root.ANNENN);
            }

            if (word.Contains("ante"))
            {
                roots.Add(Root.ANTE);
            }

            if (word.Contains("anth"))
            {
                roots.Add(Root.ANTH);
            }

            if (word.Contains("antho"))
            {
                roots.Add(Root.ANTHO);
            }

            if (word.Contains("anthrop"))
            {
                roots.Add(Root.ANTHROP);
            }

            if (word.Contains("anthropo"))
            {
                roots.Add(Root.ANTHROPO);
            }

            if (word.Contains("anti"))
            {
                roots.Add(Root.ANTI);
            }

            if (word.Contains("apo"))
            {
                roots.Add(Root.APO);
            }

            if (word.Contains("apho"))
            {
                roots.Add(Root.APHO);
            }

            if (word.Contains("aqu"))
            {
                roots.Add(Root.AQU);
            }

            if (word.Contains("aqua"))
            {
                roots.Add(Root.AQUA);
            }

            if (word.Contains("arbor"))
            {
                roots.Add(Root.ARBOR);
            }

            if (word.Contains("arch"))
            {
                roots.Add(Root.ARCH);
            }

            if (word.Contains("archi"))
            {
                roots.Add(Root.ARCHI);
            }

            if (word.Contains("arch"))
            {
                roots.Add(Root.ARCH);
            }

            if (word.Contains("archa"))
            {
                roots.Add(Root.ARCHA);
            }

            if (word.Contains("archi"))
            {
                roots.Add(Root.ARCHI);
            }

            if (word.Contains("arthr"))
            {
                roots.Add(Root.ARTHR);
            }

            if (word.Contains("arthro"))
            {
                roots.Add(Root.ARTHRO);
            }

            if (word.Contains("art"))
            {
                roots.Add(Root.ART);
            }

            if (word.Contains("astro"))
            {
                roots.Add(Root.ASTRO);
            }

            if (word.Contains("aster"))
            {
                roots.Add(Root.ASTER);
            }

            if (word.Contains("aud"))
            {
                roots.Add(Root.AUD);
            }

            if (word.Contains("audi"))
            {
                roots.Add(Root.AUDI);
            }

            if (word.Contains("audio"))
            {
                roots.Add(Root.AUDIO);
            }

            if (word.Contains("auto"))
            {
                roots.Add(Root.AUTO);
            }

            if (word.Contains("avi"))
            {
                roots.Add(Root.AVI);
            }

            if (word.Contains("avia"))
            {
                roots.Add(Root.AVIA);
            }

            if (word.Contains("bar"))
            {
                roots.Add(Root.BAR);
            }

            if (word.Contains("baro"))
            {
                roots.Add(Root.BARO);
            }

            if (word.Contains("bell"))
            {
                roots.Add(Root.BELL);
            }

            if (word.Contains("belli"))
            {
                roots.Add(Root.BELLI);
            }

            if (word.Contains("bene"))
            {
                roots.Add(Root.BENE);
            }

            //if (word.Contains("bi"))
            //{
            //    roots.Add(Root.BI);
            //}

            if (word.Contains("bin"))
            {
                roots.Add(Root.BIN);
            }

            if (word.Contains("bibli"))
            {
                roots.Add(Root.BIBLI);
            }

            if (word.Contains("biblio"))
            {
                roots.Add(Root.BIBLIO);
            }

            if (word.Contains("bio"))
            {
                roots.Add(Root.BIO);
            }

            if (word.Contains("blast"))
            {
                roots.Add(Root.BLAST);
            }

            if (word.Contains("blasto"))
            {
                roots.Add(Root.BLASTO);
            }

            if (word.Contains("burs"))
            {
                roots.Add(Root.BURS);
            }

            if (word.Contains("calc"))
            {
                roots.Add(Root.CALC);
            }

            if (word.Contains("cand"))
            {
                roots.Add(Root.CAND);
            }

            if (word.Contains("capt"))
            {
                roots.Add(Root.CAPT);
            }

            if (word.Contains("cept"))
            {
                roots.Add(Root.CEPT);
            }

            if (word.Contains("ceive"))
            {
                roots.Add(Root.CEIVE);
            }

            if (word.Contains("cardi"))
            {
                roots.Add(Root.CARDI);
            }

            if (word.Contains("cardio"))
            {
                roots.Add(Root.CARDIO);
            }

            if (word.Contains("carn"))
            {
                roots.Add(Root.CARN);
            }

            if (word.Contains("carni"))
            {
                roots.Add(Root.CARNI);
            }

            if (word.Contains("cata"))
            {
                roots.Add(Root.CATA);
            }

            if (word.Contains("caust"))
            {
                roots.Add(Root.CAUST);
            }

            if (word.Contains("caut"))
            {
                roots.Add(Root.CAUT);
            }

            if (word.Contains("cede"))
            {
                roots.Add(Root.CEDE);
            }

            if (word.Contains("ceed"))
            {
                roots.Add(Root.CEED);
            }

            if (word.Contains("cess"))
            {
                roots.Add(Root.CESS);
            }

            if (word.Contains("celer"))
            {
                roots.Add(Root.CELER);
            }

            if (word.Contains("cent"))
            {
                roots.Add(Root.CENT);
            }

            if (word.Contains("centi"))
            {
                roots.Add(Root.CENTI);
            }

            if (word.Contains("centr"))
            {
                roots.Add(Root.CENTR);
            }

            if (word.Contains("centro"))
            {
                roots.Add(Root.CENTRO);
            }

            if (word.Contains("centri"))
            {
                roots.Add(Root.CENTRI);
            }

            if (word.Contains("cephal"))
            {
                roots.Add(Root.CEPHAL);
            }

            if (word.Contains("cephalo"))
            {
                roots.Add(Root.CEPHALO);
            }

            if (word.Contains("cerebr"))
            {
                roots.Add(Root.CEREBR);
            }

            if (word.Contains("cerebro"))
            {
                roots.Add(Root.CEREBRO);
            }

            if (word.Contains("cert"))
            {
                roots.Add(Root.CERT);
            }

            if (word.Contains("chrom"))
            {
                roots.Add(Root.CHROM);
            }

            if (word.Contains("chromo"))
            {
                roots.Add(Root.CHROMO);
            }

            if (word.Contains("chromat"))
            {
                roots.Add(Root.CHROMAT);
            }

            if (word.Contains("chromato"))
            {
                roots.Add(Root.CHROMATO);
            }

            if (word.Contains("chros"))
            {
                roots.Add(Root.CHROS);
            }

            if (word.Contains("chron"))
            {
                roots.Add(Root.CHRON);
            }

            if (word.Contains("chrono"))
            {
                roots.Add(Root.CHRONO);
            }

            if (word.Contains("chrys"))
            {
                roots.Add(Root.CHRYS);
            }

            if (word.Contains("chryso"))
            {
                roots.Add(Root.CHRYSO);
            }

            if (word.Contains("cide"))
            {
                roots.Add(Root.CIDE);
            }

            if (word.Contains("cise"))
            {
                roots.Add(Root.CISE);
            }

            if (word.Contains("circum"))
            {
                roots.Add(Root.CIRCUM);
            }

            if (word.Contains("circle"))
            {
                roots.Add(Root.CIRCLE);
            }

            if (word.Contains("claim"))
            {
                roots.Add(Root.CLAIM);
            }

            if (word.Contains("clam"))
            {
                roots.Add(Root.CLAM);
            }

            if (word.Contains("clar"))
            {
                roots.Add(Root.CLAR);
            }

            if (word.Contains("clud"))
            {
                roots.Add(Root.CLUD);
            }

            if (word.Contains("clus"))
            {
                roots.Add(Root.CLUS);
            }

            if (word.Contains("cline"))
            {
                roots.Add(Root.CLINE);
            }

            //if (word.Contains("co"))
            //{
            //    roots.Add(Root.CO);
            //}

            if (word.Contains("col"))
            {
                roots.Add(Root.COL);
            }

            if (word.Contains("com"))
            {
                roots.Add(Root.COM);
            }

            if (word.Contains("cogn"))
            {
                roots.Add(Root.COGN);
            }

            if (word.Contains("cogni"))
            {
                roots.Add(Root.COGNI);
            }

            if (word.Contains("con"))
            {
                roots.Add(Root.CON);
            }

            if (word.Contains("contra"))
            {
                roots.Add(Root.CONTRA);
            }

            if (word.Contains("contrao"))
            {
                roots.Add(Root.CONTRAO);
            }

            if (word.Contains("corp"))
            {
                roots.Add(Root.CORP);
            }

            if (word.Contains("corpo"))
            {
                roots.Add(Root.CORPO);
            }

            if (word.Contains("cosm"))
            {
                roots.Add(Root.COSM);
            }

            if (word.Contains("cosmo"))
            {
                roots.Add(Root.COSMO);
            }

            if (word.Contains("counter"))
            {
                roots.Add(Root.COUNTER);
            }

            if (word.Contains("cranio"))
            {
                roots.Add(Root.CRANIO);
            }

            if (word.Contains("cred"))
            {
                roots.Add(Root.CRED);
            }

            if (word.Contains("cruc"))
            {
                roots.Add(Root.CRUC);
            }

            if (word.Contains("crypto"))
            {
                roots.Add(Root.CRYPTO);
            }

            if (word.Contains("cumul"))
            {
                roots.Add(Root.CUMUL);
            }

            if (word.Contains("curr"))
            {
                roots.Add(Root.CURR);
            }

            if (word.Contains("curs"))
            {
                roots.Add(Root.CURS);
            }

            if (word.Contains("cycl"))
            {
                roots.Add(Root.CYCL);
            }

            if (word.Contains("de"))
            {
                roots.Add(Root.DE);
            }

            if (word.Contains("dec"))
            {
                roots.Add(Root.DEC);
            }

            if (word.Contains("deca"))
            {
                roots.Add(Root.DECA);
            }

            if (word.Contains("deka"))
            {
                roots.Add(Root.DEKA);
            }

            if (word.Contains("deci"))
            {
                roots.Add(Root.DECI);
            }

            if (word.Contains("dem"))
            {
                roots.Add(Root.DEM);
            }

            if (word.Contains("demo"))
            {
                roots.Add(Root.DEMO);
            }

            if (word.Contains("demi"))
            {
                roots.Add(Root.DEMI);
            }

            if (word.Contains("dendr"))
            {
                roots.Add(Root.DENDR);
            }

            if (word.Contains("dendro"))
            {
                roots.Add(Root.DENDRO);
            }

            if (word.Contains("dendri"))
            {
                roots.Add(Root.DENDRI);
            }

            if (word.Contains("dent"))
            {
                roots.Add(Root.DENT);
            }

            if (word.Contains("dont"))
            {
                roots.Add(Root.DONT);
            }

            if (word.Contains("derm"))
            {
                roots.Add(Root.DERM);
            }

            if (word.Contains("derma"))
            {
                roots.Add(Root.DERMA);
            }

            if (word.Contains("di"))
            {
                roots.Add(Root.DI);
            }

            if (word.Contains("diplo"))
            {
                roots.Add(Root.DIPLO);
            }

            if (word.Contains("di"))
            {
                roots.Add(Root.DI);
            }

            if (word.Contains("dis"))
            {
                roots.Add(Root.DIS);
            }

            if (word.Contains("dia"))
            {
                roots.Add(Root.DIA);
            }

            if (word.Contains("dict"))
            {
                roots.Add(Root.DICT);
            }

            if (word.Contains("domin"))
            {
                roots.Add(Root.DOMIN);
            }

            if (word.Contains("don"))
            {
                roots.Add(Root.DON);
            }

            if (word.Contains("donat"))
            {
                roots.Add(Root.DONAT);
            }

            if (word.Contains("duc"))
            {
                roots.Add(Root.DUC);
            }

            if (word.Contains("duct"))
            {
                roots.Add(Root.DUCT);
            }

            if (word.Contains("du"))
            {
                roots.Add(Root.DU);
            }

            if (word.Contains("duo"))
            {
                roots.Add(Root.DUO);
            }

            if (word.Contains("dur"))
            {
                roots.Add(Root.DUR);
            }

            if (word.Contains("dyn"))
            {
                roots.Add(Root.DYN);
            }

            if (word.Contains("dyna"))
            {
                roots.Add(Root.DYNA);
            }

            if (word.Contains("dynam"))
            {
                roots.Add(Root.DYNAM);
            }

            if (word.Contains("dys"))
            {
                roots.Add(Root.DYS);
            }

            if (word.Contains("ego"))
            {
                roots.Add(Root.EGO);
            }

            //if (word.Contains("em"))
            //{
            //    roots.Add(Root.EM);
            //}

            //if (word.Contains("en"))
            //{
            //    roots.Add(Root.EN);
            //}

            if (word.Contains("endo"))
            {
                roots.Add(Root.ENDO);
            }

            if (word.Contains("enn"))
            {
                roots.Add(Root.ENN);
            }

            if (word.Contains("enni"))
            {
                roots.Add(Root.ENNI);
            }

            if (word.Contains("anni"))
            {
                roots.Add(Root.ANNI);
            }

            //if (word.Contains("en"))
            //{
            //    roots.Add(Root.EN);
            //}

            //if (word.Contains("in"))
            //{
            //    roots.Add(Root.IN);
            //}

            //if (word.Contains("ep"))
            //{
            //    roots.Add(Root.EP);
            //}

            if (word.Contains("epi"))
            {
                roots.Add(Root.EPI);
            }

            if (word.Contains("equ"))
            {
                roots.Add(Root.EQU);
            }

            if (word.Contains("equi"))
            {
                roots.Add(Root.EQUI);
            }

            if (word.Contains("erg"))
            {
                roots.Add(Root.ERG);
            }

            if (word.Contains("ergo"))
            {
                roots.Add(Root.ERGO);
            }

            if (word.Contains("esth"))
            {
                roots.Add(Root.ESTH);
            }

            if (word.Contains("esthaesth"))
            {
                roots.Add(Root.ESTHAESTH);
            }

            if (word.Contains("ethno"))
            {
                roots.Add(Root.ETHNO);
            }

            //if (word.Contains("eu"))
            //{
            //    roots.Add(Root.EU);
            //}

            //if (word.Contains("ex"))
            //{
            //    roots.Add(Root.EX);
            //}

            if (word.Contains("extra"))
            {
                roots.Add(Root.EXTRA);
            }

            if (word.Contains("extro"))
            {
                roots.Add(Root.EXTRO);
            }

            if (word.Contains("fac"))
            {
                roots.Add(Root.FAC);
            }

            if (word.Contains("fact"))
            {
                roots.Add(Root.FACT);
            }

            if (word.Contains("fer"))
            {
                roots.Add(Root.FER);
            }

            if (word.Contains("fid"))
            {
                roots.Add(Root.FID);
            }

            if (word.Contains("flect"))
            {
                roots.Add(Root.FLECT);
            }

            if (word.Contains("flor"))
            {
                roots.Add(Root.FLOR);
            }

            if (word.Contains("flora"))
            {
                roots.Add(Root.FLORA);
            }

            if (word.Contains("fleur"))
            {
                roots.Add(Root.FLEUR);
            }

            if (word.Contains("for"))
            {
                roots.Add(Root.FOR);
            }

            if (word.Contains("fore"))
            {
                roots.Add(Root.FORE);
            }

            if (word.Contains("form"))
            {
                roots.Add(Root.FORM);
            }

            if (word.Contains("fract"))
            {
                roots.Add(Root.FRACT);
            }

            if (word.Contains("frag"))
            {
                roots.Add(Root.FRAG);
            }

            if (word.Contains("fug"))
            {
                roots.Add(Root.FUG);
            }

            if (word.Contains("funct"))
            {
                roots.Add(Root.FUNCT);
            }

            if (word.Contains("fus"))
            {
                roots.Add(Root.FUS);
            }

            if (word.Contains("gastr"))
            {
                roots.Add(Root.GASTR);
            }

            if (word.Contains("gastro"))
            {
                roots.Add(Root.GASTRO);
            }

            if (word.Contains("gen"))
            {
                roots.Add(Root.GEN);
            }

            if (word.Contains("geno"))
            {
                roots.Add(Root.GENO);
            }

            if (word.Contains("gene"))
            {
                roots.Add(Root.GENE);
            }

            if (word.Contains("gengenesis"))
            {
                roots.Add(Root.GENGENESIS);
            }

            if (word.Contains("geo"))
            {
                roots.Add(Root.GEO);
            }

            if (word.Contains("ger"))
            {
                roots.Add(Root.GER);
            }

            if (word.Contains("giga"))
            {
                roots.Add(Root.GIGA);
            }

            if (word.Contains("gon"))
            {
                roots.Add(Root.GON);
            }

            if (word.Contains("gram"))
            {
                roots.Add(Root.GRAM);
            }

            if (word.Contains("gran"))
            {
                roots.Add(Root.GRAN);
            }

            if (word.Contains("graph"))
            {
                roots.Add(Root.GRAPH);
            }

            if (word.Contains("graphy"))
            {
                roots.Add(Root.GRAPHY);
            }

            if (word.Contains("grat"))
            {
                roots.Add(Root.GRAT);
            }

            if (word.Contains("gyn"))
            {
                roots.Add(Root.GYN);
            }

            if (word.Contains("gyno"))
            {
                roots.Add(Root.GYNO);
            }

            if (word.Contains("gyne"))
            {
                roots.Add(Root.GYNE);
            }

            if (word.Contains("gress"))
            {
                roots.Add(Root.GRESS);
            }

            if (word.Contains("grad"))
            {
                roots.Add(Root.GRAD);
            }

            if (word.Contains("grade"))
            {
                roots.Add(Root.GRADE);
            }

            if (word.Contains("gradi"))
            {
                roots.Add(Root.GRADI);
            }

            if (word.Contains("hect"))
            {
                roots.Add(Root.HECT);
            }

            if (word.Contains("hecto"))
            {
                roots.Add(Root.HECTO);
            }

            if (word.Contains("hecat"))
            {
                roots.Add(Root.HECAT);
            }

            if (word.Contains("helic"))
            {
                roots.Add(Root.HELIC);
            }

            if (word.Contains("helico"))
            {
                roots.Add(Root.HELICO);
            }

            if (word.Contains("heli"))
            {
                roots.Add(Root.HELI);
            }

            if (word.Contains("helio"))
            {
                roots.Add(Root.HELIO);
            }

            if (word.Contains("hemi"))
            {
                roots.Add(Root.HEMI);
            }

            if (word.Contains("hem"))
            {
                roots.Add(Root.HEM);
            }

            if (word.Contains("hemo"))
            {
                roots.Add(Root.HEMO);
            }

            if (word.Contains("hema"))
            {
                roots.Add(Root.HEMA);
            }

            if (word.Contains("hepa"))
            {
                roots.Add(Root.HEPA);
            }

            if (word.Contains("hept"))
            {
                roots.Add(Root.HEPT);
            }

            if (word.Contains("hepta"))
            {
                roots.Add(Root.HEPTA);
            }

            if (word.Contains("herbi"))
            {
                roots.Add(Root.HERBI);
            }

            if (word.Contains("hetero"))
            {
                roots.Add(Root.HETERO);
            }

            if (word.Contains("hex"))
            {
                roots.Add(Root.HEX);
            }

            if (word.Contains("hexa"))
            {
                roots.Add(Root.HEXA);
            }

            if (word.Contains("histo"))
            {
                roots.Add(Root.HISTO);
            }

            if (word.Contains("homo"))
            {
                roots.Add(Root.HOMO);
            }

            if (word.Contains("homeo"))
            {
                roots.Add(Root.HOMEO);
            }

            if (word.Contains("hydr"))
            {
                roots.Add(Root.HYDR);
            }

            if (word.Contains("hydro"))
            {
                roots.Add(Root.HYDRO);
            }

            if (word.Contains("hygr"))
            {
                roots.Add(Root.HYGR);
            }

            if (word.Contains("hygro"))
            {
                roots.Add(Root.HYGRO);
            }

            if (word.Contains("hyper"))
            {
                roots.Add(Root.HYPER);
            }

            if (word.Contains("hyp"))
            {
                roots.Add(Root.HYP);
            }

            if (word.Contains("hypo"))
            {
                roots.Add(Root.HYPO);
            }

            if (word.Contains("iatr"))
            {
                roots.Add(Root.IATR);
            }

            if (word.Contains("iatro"))
            {
                roots.Add(Root.IATRO);
            }

            if (word.Contains("icon"))
            {
                roots.Add(Root.ICON);
            }

            if (word.Contains("icono"))
            {
                roots.Add(Root.ICONO);
            }

            if (word.Contains("idio"))
            {
                roots.Add(Root.IDIO);
            }

            //if (word.Contains("il"))
            //{
            //    roots.Add(Root.IL);
            //}

            //if (word.Contains("in"))
            //{
            //    roots.Add(Root.IN);
            //}

            //if (word.Contains("ig"))
            //{
            //    roots.Add(Root.IG);
            //}

            //if (word.Contains("il"))
            //{
            //    roots.Add(Root.IL);
            //}

            //if (word.Contains("im"))
            //{
            //    roots.Add(Root.IM);
            //}

            //if (word.Contains("in"))
            //{
            //    roots.Add(Root.IN);
            //}

            //if (word.Contains("ir"))
            //{
            //    roots.Add(Root.IR);
            //}

            if (word.Contains("imag"))
            {
                roots.Add(Root.IMAG);
            }

            if (word.Contains("infra"))
            {
                roots.Add(Root.INFRA);
            }

            if (word.Contains("inter"))
            {
                roots.Add(Root.INTER);
            }

            if (word.Contains("intra"))
            {
                roots.Add(Root.INTRA);
            }

            if (word.Contains("intro"))
            {
                roots.Add(Root.INTRO);
            }

            //if (word.Contains("ir"))
            //{
            //    roots.Add(Root.IR);
            //}

            if (word.Contains("iso"))
            {
                roots.Add(Root.ISO);
            }

            if (word.Contains("ject"))
            {
                roots.Add(Root.JECT);
            }

            if (word.Contains("jud"))
            {
                roots.Add(Root.JUD);
            }

            if (word.Contains("junct"))
            {
                roots.Add(Root.JUNCT);
            }

            if (word.Contains("juven"))
            {
                roots.Add(Root.JUVEN);
            }

            if (word.Contains("kilo"))
            {
                roots.Add(Root.KILO);
            }

            if (word.Contains("kine"))
            {
                roots.Add(Root.KINE);
            }

            if (word.Contains("kinet"))
            {
                roots.Add(Root.KINET);
            }

            if (word.Contains("kinemat"))
            {
                roots.Add(Root.KINEMAT);
            }

            if (word.Contains("lab"))
            {
                roots.Add(Root.LAB);
            }

            if (word.Contains("lact"))
            {
                roots.Add(Root.LACT);
            }

            if (word.Contains("lacto"))
            {
                roots.Add(Root.LACTO);
            }

            if (word.Contains("later"))
            {
                roots.Add(Root.LATER);
            }

            if (word.Contains("leuk"))
            {
                roots.Add(Root.LEUK);
            }

            if (word.Contains("leuko"))
            {
                roots.Add(Root.LEUKO);
            }

            if (word.Contains("leuc"))
            {
                roots.Add(Root.LEUC);
            }

            if (word.Contains("leuco"))
            {
                roots.Add(Root.LEUCO);
            }

            if (word.Contains("lex"))
            {
                roots.Add(Root.LEX);
            }

            if (word.Contains("liber"))
            {
                roots.Add(Root.LIBER);
            }

            if (word.Contains("lingu"))
            {
                roots.Add(Root.LINGU);
            }

            if (word.Contains("lip"))
            {
                roots.Add(Root.LIP);
            }

            if (word.Contains("lipo"))
            {
                roots.Add(Root.LIPO);
            }

            if (word.Contains("lite"))
            {
                roots.Add(Root.LITE);
            }

            if (word.Contains("ite"))
            {
                roots.Add(Root.ITE);
            }

            if (word.Contains("lith"))
            {
                roots.Add(Root.LITH);
            }

            if (word.Contains("litho"))
            {
                roots.Add(Root.LITHO);
            }

            if (word.Contains("loc"))
            {
                roots.Add(Root.LOC);
            }

            if (word.Contains("log"))
            {
                roots.Add(Root.LOG);
            }

            if (word.Contains("logo"))
            {
                roots.Add(Root.LOGO);
            }

            if (word.Contains("loqu"))
            {
                roots.Add(Root.LOQU);
            }

            if (word.Contains("locu"))
            {
                roots.Add(Root.LOCU);
            }

            if (word.Contains("luc"))
            {
                roots.Add(Root.LUC);
            }

            if (word.Contains("lud"))
            {
                roots.Add(Root.LUD);
            }

            if (word.Contains("lus"))
            {
                roots.Add(Root.LUS);
            }

            if (word.Contains("lumin"))
            {
                roots.Add(Root.LUMIN);
            }

            if (word.Contains("lun"))
            {
                roots.Add(Root.LUN);
            }

            if (word.Contains("luna"))
            {
                roots.Add(Root.LUNA);
            }

            if (word.Contains("luni"))
            {
                roots.Add(Root.LUNI);
            }

            if (word.Contains("macro"))
            {
                roots.Add(Root.MACRO);
            }

            if (word.Contains("magn"))
            {
                roots.Add(Root.MAGN);
            }

            if (word.Contains("magna"))
            {
                roots.Add(Root.MAGNA);
            }

            if (word.Contains("magni"))
            {
                roots.Add(Root.MAGNI);
            }

            if (word.Contains("mal"))
            {
                roots.Add(Root.MAL);
            }

            if (word.Contains("male"))
            {
                roots.Add(Root.MALE);
            }

            if (word.Contains("man"))
            {
                roots.Add(Root.MAN);
            }

            if (word.Contains("mani"))
            {
                roots.Add(Root.MANI);
            }

            if (word.Contains("manu"))
            {
                roots.Add(Root.MANU);
            }

            if (word.Contains("mand"))
            {
                roots.Add(Root.MAND);
            }

            if (word.Contains("mania"))
            {
                roots.Add(Root.MANIA);
            }

            if (word.Contains("mar"))
            {
                roots.Add(Root.MAR);
            }

            if (word.Contains("mari"))
            {
                roots.Add(Root.MARI);
            }

            if (word.Contains("mater"))
            {
                roots.Add(Root.MATER);
            }

            if (word.Contains("matr"))
            {
                roots.Add(Root.MATR);
            }

            if (word.Contains("matri"))
            {
                roots.Add(Root.MATRI);
            }

            if (word.Contains("max"))
            {
                roots.Add(Root.MAX);
            }

            if (word.Contains("medi"))
            {
                roots.Add(Root.MEDI);
            }

            if (word.Contains("mega"))
            {
                roots.Add(Root.MEGA);
            }

            if (word.Contains("melan"))
            {
                roots.Add(Root.MELAN);
            }

            if (word.Contains("melano"))
            {
                roots.Add(Root.MELANO);
            }

            if (word.Contains("memor"))
            {
                roots.Add(Root.MEMOR);
            }

            if (word.Contains("memori"))
            {
                roots.Add(Root.MEMORI);
            }

            if (word.Contains("merge"))
            {
                roots.Add(Root.MERGE);
            }

            if (word.Contains("mers"))
            {
                roots.Add(Root.MERS);
            }

            if (word.Contains("meso"))
            {
                roots.Add(Root.MESO);
            }

            if (word.Contains("meta"))
            {
                roots.Add(Root.META);
            }

            if (word.Contains("meter"))
            {
                roots.Add(Root.METER);
            }

            if (word.Contains("metr"))
            {
                roots.Add(Root.METR);
            }

            if (word.Contains("metry"))
            {
                roots.Add(Root.METRY);
            }

            if (word.Contains("micro"))
            {
                roots.Add(Root.MICRO);
            }

            if (word.Contains("mid"))
            {
                roots.Add(Root.MID);
            }

            if (word.Contains("migr"))
            {
                roots.Add(Root.MIGR);
            }

            if (word.Contains("milli"))
            {
                roots.Add(Root.MILLI);
            }

            if (word.Contains("min"))
            {
                roots.Add(Root.MIN);
            }

            if (word.Contains("mini"))
            {
                roots.Add(Root.MINI);
            }

            if (word.Contains("mis"))
            {
                roots.Add(Root.MIS);
            }

            if (word.Contains("miso"))
            {
                roots.Add(Root.MISO);
            }

            if (word.Contains("miss"))
            {
                roots.Add(Root.MISS);
            }

            if (word.Contains("mit"))
            {
                roots.Add(Root.MIT);
            }

            if (word.Contains("mob"))
            {
                roots.Add(Root.MOB);
            }

            if (word.Contains("mon"))
            {
                roots.Add(Root.MON);
            }

            if (word.Contains("mono"))
            {
                roots.Add(Root.MONO);
            }

            if (word.Contains("mot"))
            {
                roots.Add(Root.MOT);
            }

            if (word.Contains("mov"))
            {
                roots.Add(Root.MOV);
            }

            if (word.Contains("morph"))
            {
                roots.Add(Root.MORPH);
            }

            if (word.Contains("morpho"))
            {
                roots.Add(Root.MORPHO);
            }

            if (word.Contains("mort"))
            {
                roots.Add(Root.MORT);
            }

            if (word.Contains("multi"))
            {
                roots.Add(Root.MULTI);
            }

            if (word.Contains("mut"))
            {
                roots.Add(Root.MUT);
            }

            //if (word.Contains("my"))
            //{
            //    roots.Add(Root.MY);
            //}

            if (word.Contains("myo"))
            {
                roots.Add(Root.MYO);
            }

            if (word.Contains("narr"))
            {
                roots.Add(Root.NARR);
            }

            if (word.Contains("nat"))
            {
                roots.Add(Root.NAT);
            }

            if (word.Contains("nav"))
            {
                roots.Add(Root.NAV);
            }

            if (word.Contains("necr"))
            {
                roots.Add(Root.NECR);
            }

            if (word.Contains("necro"))
            {
                roots.Add(Root.NECRO);
            }

            if (word.Contains("neg"))
            {
                roots.Add(Root.NEG);
            }

            if (word.Contains("neo"))
            {
                roots.Add(Root.NEO);
            }

            if (word.Contains("nephr"))
            {
                roots.Add(Root.NEPHR);
            }

            if (word.Contains("nephro"))
            {
                roots.Add(Root.NEPHRO);
            }

            if (word.Contains("neur"))
            {
                roots.Add(Root.NEUR);
            }

            if (word.Contains("neuro"))
            {
                roots.Add(Root.NEURO);
            }

            if (word.Contains("nom"))
            {
                roots.Add(Root.NOM);
            }

            if (word.Contains("nomin"))
            {
                roots.Add(Root.NOMIN);
            }

            if (word.Contains("non"))
            {
                roots.Add(Root.NON);
            }

            if (word.Contains("not"))
            {
                roots.Add(Root.NOT);
            }

            if (word.Contains("noun"))
            {
                roots.Add(Root.NOUN);
            }

            if (word.Contains("nunc"))
            {
                roots.Add(Root.NUNC);
            }

            if (word.Contains("nov"))
            {
                roots.Add(Root.NOV);
            }

            if (word.Contains("numer"))
            {
                roots.Add(Root.NUMER);
            }

            //if (word.Contains("ob"))
            //{
            //    roots.Add(Root.OB);
            //}

            //if (word.Contains("op"))
            //{
            //    roots.Add(Root.OP);
            //}

            if (word.Contains("oct"))
            {
                roots.Add(Root.OCT);
            }

            if (word.Contains("octa"))
            {
                roots.Add(Root.OCTA);
            }

            if (word.Contains("octo"))
            {
                roots.Add(Root.OCTO);
            }

            if (word.Contains("ocu"))
            {
                roots.Add(Root.OCU);
            }

            //if (word.Contains("od"))
            //{
            //    roots.Add(Root.OD);
            //}

            if (word.Contains("odor"))
            {
                roots.Add(Root.ODOR);
            }

            if (word.Contains("omni"))
            {
                roots.Add(Root.OMNI);
            }

            //if (word.Contains("op"))
            //{
            //    roots.Add(Root.OP);
            //}

            if (word.Contains("opt"))
            {
                roots.Add(Root.OPT);
            }

            if (word.Contains("ops"))
            {
                roots.Add(Root.OPS);
            }

            if (word.Contains("opt"))
            {
                roots.Add(Root.OPT);
            }

            if (word.Contains("ortho"))
            {
                roots.Add(Root.ORTHO);
            }

            if (word.Contains("osteo"))
            {
                roots.Add(Root.OSTEO);
            }

            if (word.Contains("out"))
            {
                roots.Add(Root.OUT);
            }

            if (word.Contains("over"))
            {
                roots.Add(Root.OVER);
            }

            if (word.Contains("oxi"))
            {
                roots.Add(Root.OXI);
            }

            if (word.Contains("oxioxy"))
            {
                roots.Add(Root.OXIOXY);
            }

            if (word.Contains("pale"))
            {
                roots.Add(Root.PALE);
            }

            if (word.Contains("paleo"))
            {
                roots.Add(Root.PALEO);
            }

            if (word.Contains("pan"))
            {
                roots.Add(Root.PAN);
            }

            if (word.Contains("para"))
            {
                roots.Add(Root.PARA);
            }

            if (word.Contains("para"))
            {
                roots.Add(Root.PARA);
            }

            if (word.Contains("pater"))
            {
                roots.Add(Root.PATER);
            }

            if (word.Contains("patr"))
            {
                roots.Add(Root.PATR);
            }

            if (word.Contains("patri"))
            {
                roots.Add(Root.PATRI);
            }

            if (word.Contains("path"))
            {
                roots.Add(Root.PATH);
            }

            if (word.Contains("ped"))
            {
                roots.Add(Root.PED);
            }

            if (word.Contains("pedi"))
            {
                roots.Add(Root.PEDI);
            }

            if (word.Contains("pede"))
            {
                roots.Add(Root.PEDE);
            }

            if (word.Contains("pel"))
            {
                roots.Add(Root.PEL);
            }

            if (word.Contains("pent"))
            {
                roots.Add(Root.PENT);
            }

            if (word.Contains("penta"))
            {
                roots.Add(Root.PENTA);
            }

            if (word.Contains("pept"))
            {
                roots.Add(Root.PEPT);
            }

            if (word.Contains("peps"))
            {
                roots.Add(Root.PEPS);
            }

            if (word.Contains("per"))
            {
                roots.Add(Root.PER);
            }

            if (word.Contains("peri"))
            {
                roots.Add(Root.PERI);
            }

            if (word.Contains("phag"))
            {
                roots.Add(Root.PHAG);
            }

            if (word.Contains("phage"))
            {
                roots.Add(Root.PHAGE);
            }

            if (word.Contains("phil"))
            {
                roots.Add(Root.PHIL);
            }

            if (word.Contains("philo"))
            {
                roots.Add(Root.PHILO);
            }

            if (word.Contains("phon"))
            {
                roots.Add(Root.PHON);
            }

            if (word.Contains("phono"))
            {
                roots.Add(Root.PHONO);
            }

            if (word.Contains("phone"))
            {
                roots.Add(Root.PHONE);
            }

            if (word.Contains("phony"))
            {
                roots.Add(Root.PHONY);
            }

            if (word.Contains("phot"))
            {
                roots.Add(Root.PHOT);
            }

            if (word.Contains("photo"))
            {
                roots.Add(Root.PHOTO);
            }

            if (word.Contains("phyll"))
            {
                roots.Add(Root.PHYLL);
            }

            if (word.Contains("phyllo"))
            {
                roots.Add(Root.PHYLLO);
            }

            if (word.Contains("phys"))
            {
                roots.Add(Root.PHYS);
            }

            if (word.Contains("phyt"))
            {
                roots.Add(Root.PHYT);
            }

            if (word.Contains("phyto"))
            {
                roots.Add(Root.PHYTO);
            }

            if (word.Contains("phyte"))
            {
                roots.Add(Root.PHYTE);
            }

            if (word.Contains("plas"))
            {
                roots.Add(Root.PLAS);
            }

            if (word.Contains("plast"))
            {
                roots.Add(Root.PLAST);
            }

            if (word.Contains("plasm"))
            {
                roots.Add(Root.PLASM);
            }

            if (word.Contains("plaud"))
            {
                roots.Add(Root.PLAUD);
            }

            if (word.Contains("plod"))
            {
                roots.Add(Root.PLOD);
            }

            if (word.Contains("plaus"))
            {
                roots.Add(Root.PLAUS);
            }

            if (word.Contains("plos"))
            {
                roots.Add(Root.PLOS);
            }

            if (word.Contains("pneum"))
            {
                roots.Add(Root.PNEUM);
            }

            if (word.Contains("pneumo"))
            {
                roots.Add(Root.PNEUMO);
            }

            if (word.Contains("pod"))
            {
                roots.Add(Root.POD);
            }

            if (word.Contains("pode"))
            {
                roots.Add(Root.PODE);
            }

            if (word.Contains("poli"))
            {
                roots.Add(Root.POLI);
            }

            if (word.Contains("poly"))
            {
                roots.Add(Root.POLY);
            }

            if (word.Contains("pon"))
            {
                roots.Add(Root.PON);
            }

            if (word.Contains("pop"))
            {
                roots.Add(Root.POP);
            }

            if (word.Contains("port"))
            {
                roots.Add(Root.PORT);
            }

            if (word.Contains("pos"))
            {
                roots.Add(Root.POS);
            }

            if (word.Contains("post"))
            {
                roots.Add(Root.POST);
            }

            if (word.Contains("pre"))
            {
                roots.Add(Root.PRE);
            }

            if (word.Contains("pro"))
            {
                roots.Add(Root.PRO);
            }

            if (word.Contains("prot"))
            {
                roots.Add(Root.PROT);
            }

            if (word.Contains("proto"))
            {
                roots.Add(Root.PROTO);
            }

            if (word.Contains("pseud"))
            {
                roots.Add(Root.PSEUD);
            }

            if (word.Contains("pseudo"))
            {
                roots.Add(Root.PSEUDO);
            }

            if (word.Contains("psych"))
            {
                roots.Add(Root.PSYCH);
            }

            if (word.Contains("psycho"))
            {
                roots.Add(Root.PSYCHO);
            }

            if (word.Contains("pugn"))
            {
                roots.Add(Root.PUGN);
            }

            if (word.Contains("pugna"))
            {
                roots.Add(Root.PUGNA);
            }

            if (word.Contains("pung"))
            {
                roots.Add(Root.PUNG);
            }
            
            if (word.Contains("pul"))
            {
                roots.Add(Root.PUL);
            }

            if (word.Contains("purg"))
            {
                roots.Add(Root.PURG);
            }

            if (word.Contains("put"))
            {
                roots.Add(Root.PUT);
            }

            if (word.Contains("pyr"))
            {
                roots.Add(Root.PYR);
            }

            if (word.Contains("pyro"))
            {
                roots.Add(Root.PYRO);
            }

            if (word.Contains("quad"))
            {
                roots.Add(Root.QUAD);
            }

            if (word.Contains("quadr"))
            {
                roots.Add(Root.QUADR);
            }

            if (word.Contains("quadri"))
            {
                roots.Add(Root.QUADRI);
            }

            if (word.Contains("quart"))
            {
                roots.Add(Root.QUART);
            }

            if (word.Contains("quin"))
            {
                roots.Add(Root.QUIN);
            }

            if (word.Contains("quint"))
            {
                roots.Add(Root.QUINT);
            }

            if (word.Contains("radic"))
            {
                roots.Add(Root.RADIC);
            }

            if (word.Contains("radix"))
            {
                roots.Add(Root.RADIX);
            }

            if (word.Contains("radio"))
            {
                roots.Add(Root.RADIO);
            }

            if (word.Contains("ram"))
            {
                roots.Add(Root.RAM);
            }

            if (word.Contains("rami"))
            {
                roots.Add(Root.RAMI);
            }

            //if (word.Contains("re"))
            //{
            //    roots.Add(Root.RE);
            //}

            if (word.Contains("reg"))
            {
                roots.Add(Root.REG);
            }

            if (word.Contains("retro"))
            {
                roots.Add(Root.RETRO);
            }

            if (word.Contains("rhin"))
            {
                roots.Add(Root.RHIN);
            }

            if (word.Contains("rhino"))
            {
                roots.Add(Root.RHINO);
            }

            if (word.Contains("rhod"))
            {
                roots.Add(Root.RHOD);
            }

            if (word.Contains("rhodo"))
            {
                roots.Add(Root.RHODO);
            }

            if (word.Contains("rid"))
            {
                roots.Add(Root.RID);
            }

            if (word.Contains("rrh"))
            {
                roots.Add(Root.RRH);
            }

            if (word.Contains("rrhea"))
            {
                roots.Add(Root.RRHEA);
            }

            if (word.Contains("rrhoea"))
            {
                roots.Add(Root.RRHOEA);
            }

            if (word.Contains("rrhag"))
            {
                roots.Add(Root.RRHAG);
            }

            if (word.Contains("rub"))
            {
                roots.Add(Root.RUB);
            }

            if (word.Contains("rupt"))
            {
                roots.Add(Root.RUPT);
            }

            if (word.Contains("san"))
            {
                roots.Add(Root.SAN);
            }

            if (word.Contains("scend"))
            {
                roots.Add(Root.SCEND);
            }

            if (word.Contains("sci"))
            {
                roots.Add(Root.SCI);
            }

            if (word.Contains("scler"))
            {
                roots.Add(Root.SCLER);
            }

            if (word.Contains("sclero"))
            {
                roots.Add(Root.SCLERO);
            }

            if (word.Contains("scop"))
            {
                roots.Add(Root.SCOP);
            }

            if (word.Contains("scope"))
            {
                roots.Add(Root.SCOPE);
            }

            if (word.Contains("scopy"))
            {
                roots.Add(Root.SCOPY);
            }

            if (word.Contains("scrib"))
            {
                roots.Add(Root.SCRIB);
            }

            if (word.Contains("script"))
            {
                roots.Add(Root.SCRIPT);
            }

            //if (word.Contains("se"))
            //{
            //    roots.Add(Root.SE);
            //}

            if (word.Contains("sect"))
            {
                roots.Add(Root.SECT);
            }

            if (word.Contains("sed"))
            {
                roots.Add(Root.SED);
            }

            if (word.Contains("sid"))
            {
                roots.Add(Root.SID);
            }

            if (word.Contains("sess"))
            {
                roots.Add(Root.SESS);
            }

            if (word.Contains("self"))
            {
                roots.Add(Root.SELF);
            }

            if (word.Contains("semi"))
            {
                roots.Add(Root.SEMI);
            }

            if (word.Contains("sept"))
            {
                roots.Add(Root.SEPT);
            }

            if (word.Contains("septi"))
            {
                roots.Add(Root.SEPTI);
            }

            if (word.Contains("serv"))
            {
                roots.Add(Root.SERV);
            }

            if (word.Contains("sex"))
            {
                roots.Add(Root.SEX);
            }

            if (word.Contains("sol"))
            {
                roots.Add(Root.SOL);
            }

            if (word.Contains("sol"))
            {
                roots.Add(Root.SOL);
            }

            if (word.Contains("somn"))
            {
                roots.Add(Root.SOMN);
            }

            if (word.Contains("somni"))
            {
                roots.Add(Root.SOMNI);
            }

            if (word.Contains("son"))
            {
                roots.Add(Root.SON);
            }

            if (word.Contains("soph"))
            {
                roots.Add(Root.SOPH);
            }

            if (word.Contains("spec"))
            {
                roots.Add(Root.SPEC);
            }

            if (word.Contains("spect"))
            {
                roots.Add(Root.SPECT);
            }

            if (word.Contains("spic"))
            {
                roots.Add(Root.SPIC);
            }

            if (word.Contains("sphere"))
            {
                roots.Add(Root.SPHERE);
            }

            if (word.Contains("spir"))
            {
                roots.Add(Root.SPIR);
            }

            if (word.Contains("sta"))
            {
                roots.Add(Root.STA);
            }

            if (word.Contains("stell"))
            {
                roots.Add(Root.STELL);
            }

            if (word.Contains("struct"))
            {
                roots.Add(Root.STRUCT);
            }

            if (word.Contains("sub"))
            {
                roots.Add(Root.SUB);
            }

            if (word.Contains("sum"))
            {
                roots.Add(Root.SUM);
            }

            if (word.Contains("super"))
            {
                roots.Add(Root.SUPER);
            }

            //if (word.Contains("sy"))
            //{
            //    roots.Add(Root.SY);
            //}

            if (word.Contains("sym"))
            {
                roots.Add(Root.SYM);
            }

            if (word.Contains("syn"))
            {
                roots.Add(Root.SYN);
            }

            if (word.Contains("syl"))
            {
                roots.Add(Root.SYL);
            }

            if (word.Contains("sys"))
            {
                roots.Add(Root.SYS);
            }

            if (word.Contains("tact"))
            {
                roots.Add(Root.TACT);
            }

            if (word.Contains("tang"))
            {
                roots.Add(Root.TANG);
            }

            if (word.Contains("tax"))
            {
                roots.Add(Root.TAX);
            }

            if (word.Contains("taxo"))
            {
                roots.Add(Root.TAXO);
            }

            if (word.Contains("techno"))
            {
                roots.Add(Root.TECHNO);
            }

            if (word.Contains("tel"))
            {
                roots.Add(Root.TEL);
            }

            if (word.Contains("tele"))
            {
                roots.Add(Root.TELE);
            }

            if (word.Contains("telo"))
            {
                roots.Add(Root.TELO);
            }

            if (word.Contains("temp"))
            {
                roots.Add(Root.TEMP);
            }

            if (word.Contains("tempor"))
            {
                roots.Add(Root.TEMPOR);
            }

            if (word.Contains("ten"))
            {
                roots.Add(Root.TEN);
            }

            if (word.Contains("tin"))
            {
                roots.Add(Root.TIN);
            }

            if (word.Contains("tent"))
            {
                roots.Add(Root.TENT);
            }

            if (word.Contains("ter"))
            {
                roots.Add(Root.TER);
            }

            if (word.Contains("trit"))
            {
                roots.Add(Root.TRIT);
            }

            if (word.Contains("term"))
            {
                roots.Add(Root.TERM);
            }

            if (word.Contains("termina"))
            {
                roots.Add(Root.TERMINA);
            }

            if (word.Contains("terr"))
            {
                roots.Add(Root.TERR);
            }

            if (word.Contains("terra"))
            {
                roots.Add(Root.TERRA);
            }

            if (word.Contains("terri"))
            {
                roots.Add(Root.TERRI);
            }

            if (word.Contains("tetra"))
            {
                roots.Add(Root.TETRA);
            }

            if (word.Contains("the"))
            {
                roots.Add(Root.THE);
            }

            if (word.Contains("the"))
            {
                roots.Add(Root.THE);
            }

            if (word.Contains("theo"))
            {
                roots.Add(Root.THEO);
            }

            if (word.Contains("therm"))
            {
                roots.Add(Root.THERM);
            }

            if (word.Contains("thermo"))
            {
                roots.Add(Root.THERMO);
            }

            if (word.Contains("tort"))
            {
                roots.Add(Root.TORT);
            }

            if (word.Contains("tox"))
            {
                roots.Add(Root.TOX);
            }

            if (word.Contains("tract"))
            {
                roots.Add(Root.TRACT);
            }

            if (word.Contains("trans"))
            {
                roots.Add(Root.TRANS);
            }

            if (word.Contains("tri"))
            {
                roots.Add(Root.TRI);
            }

            if (word.Contains("ultra"))
            {
                roots.Add(Root.ULTRA);
            }

            //if (word.Contains("un"))
            //{
            //    roots.Add(Root.UN);
            //}

            if (word.Contains("uni"))
            {
                roots.Add(Root.UNI);
            }

            if (word.Contains("urb"))
            {
                roots.Add(Root.URB);
            }

            if (word.Contains("vac"))
            {
                roots.Add(Root.VAC);
            }

            if (word.Contains("ven"))
            {
                roots.Add(Root.VEN);
            }

            if (word.Contains("vent"))
            {
                roots.Add(Root.VENT);
            }

            if (word.Contains("ver"))
            {
                roots.Add(Root.VER);
            }

            if (word.Contains("veri"))
            {
                roots.Add(Root.VERI);
            }

            if (word.Contains("verb"))
            {
                roots.Add(Root.VERB);
            }

            if (word.Contains("vers"))
            {
                roots.Add(Root.VERS);
            }

            if (word.Contains("vert"))
            {
                roots.Add(Root.VERT);
            }

            if (word.Contains("vice"))
            {
                roots.Add(Root.VICE);
            }

            if (word.Contains("vid"))
            {
                roots.Add(Root.VID);
            }

            if (word.Contains("vince"))
            {
                roots.Add(Root.VINCE);
            }

            if (word.Contains("vic"))
            {
                roots.Add(Root.VIC);
            }

            if (word.Contains("vis"))
            {
                roots.Add(Root.VIS);
            }

            if (word.Contains("vid"))
            {
                roots.Add(Root.VID);
            }

            if (word.Contains("viv"))
            {
                roots.Add(Root.VIV);
            }

            if (word.Contains("vivi"))
            {
                roots.Add(Root.VIVI);
            }

            if (word.Contains("vit"))
            {
                roots.Add(Root.VIT);
            }

            if (word.Contains("voc"))
            {
                roots.Add(Root.VOC);
            }

            if (word.Contains("voci"))
            {
                roots.Add(Root.VOCI);
            }

            if (word.Contains("vol"))
            {
                roots.Add(Root.VOL);
            }

            if (word.Contains("voli"))
            {
                roots.Add(Root.VOLI);
            }

            if (word.Contains("volu"))
            {
                roots.Add(Root.VOLU);
            }

            if (word.Contains("vor"))
            {
                roots.Add(Root.VOR);
            }

            if (word.Contains("vour"))
            {
                roots.Add(Root.VOUR);
            }

            if (word.Contains("xanth"))
            {
                roots.Add(Root.XANTH);
            }

            if (word.Contains("xen"))
            {
                roots.Add(Root.XEN);
            }

            if (word.Contains("xeno"))
            {
                roots.Add(Root.XENO);
            }

            if (word.Contains("xer"))
            {
                roots.Add(Root.XER);
            }

            if (word.Contains("xero"))
            {
                roots.Add(Root.XERO);
            }

            if (word.Contains("xeri"))
            {
                roots.Add(Root.XERI);
            }

            if (word.Contains("xyl"))
            {
                roots.Add(Root.XYL);
            }

            //if (word.Contains("zo"))
            //{
            //    roots.Add(Root.ZO);
            //}

            if (word.Contains("zoo"))
            {
                roots.Add(Root.ZOO);
            }

            if (word.Contains("zyg"))
            {
                roots.Add(Root.ZYG);
            }

            if (word.Contains("zygo"))
            {
                roots.Add(Root.ZYGO);
            }

            //train root from C:\Users\usagi\Desktop\Books\Roots\Input.txt C:\Users\usagi\Desktop\Books\Roots\Output.txt
            
            return roots;
        }
    }

    public class WordMeta
    {
        Root FirstRoot = Root.NONE;
    }

    public enum Root
    {
        NONE,
        //AN,
        //AC,
        //AD,
        ACRO,
        ACT,
        AER,
        AERO,
        AGR,
        AGRI,
        AGRO,
        ALG,
        ALGO,
        AMBI,
        AMPHI,
        AMBUL,
        AMI,
        AMIO,
        ANA,
        ANDR,
        ANDRO,
        ANIM,
        ANN,
        ANNENN,
        ANTE,
        ANTH,
        ANTHO,
        ANTHROP,
        ANTHROPO,
        ANTI,
        APO,
        APHO,
        AQU,
        AQUA,
        ARBOR,
        ARCH,
        ARCHI,
        ARCHA,
        ARTHR,
        ARTHRO,
        ART,
        ASTRO,
        ASTER,
        AUD,
        AUDI,
        AUDIO,
        AUTO,
        AVI,
        AVIA,
        BAR,
        BARO,
        BELL,
        BELLI,
        BENE,
        //BI,
        BIN,
        BIBLI,
        BIBLIO,
        BIO,
        BLAST,
        BLASTO,
        BURS,
        CALC,
        CAND,
        CAPT,
        CEPT,
        CEIVE,
        CARDI,
        CARDIO,
        CARN,
        CARNI,
        CATA,
        CAUST,
        CAUT,
        CEDE,
        CEED,
        CESS,
        CELER,
        CENT,
        CENTI,
        CENTR,
        CENTRO,
        CENTRI,
        CEPHAL,
        CEPHALO,
        CEREBR,
        CEREBRO,
        CERT,
        CHROM,
        CHROMO,
        CHROMAT,
        CHROMATO,
        CHROS,
        CHRON,
        CHRONO,
        CHRYS,
        CHRYSO,
        CIDE,
        CISE,
        CIRCUM,
        CIRCLE,
        CLAIM,
        CLAM,
        CLAR,
        CLUD,
        CLUS,
        CLINE,
        //CO,
        COL,
        COM,
        COGN,
        COGNI,
        CON,
        CONTRA,
        CONTRAO,
        CORP,
        CORPO,
        COSM,
        COSMO,
        COUNTER,
        CRANIO,
        CRED,
        CRUC,
        CRYPTO,
        CUMUL,
        CURR,
        CURS,
        CYCL,
        DE,
        DEC,
        DECA,
        DEKA,
        DECI,
        DEM,
        DEMO,
        DEMI,
        DENDR,
        DENDRO,
        DENDRI,
        DENT,
        DONT,
        DERM,
        DERMA,
        DI,
        DIPLO,
        DIS,
        DIA,
        DICT,
        DOMIN,
        DON,
        DONAT,
        DUC,
        DUCT,
        DU,
        DUO,
        DUR,
        DYN,
        DYNA,
        DYNAM,
        DYS,
        EGO,
        //EM,
        //EN,
        ENDO,
        ENN,
        ENNI,
        ANNI,
        //IN,
        //EP,
        EPI,
        EQU,
        EQUI,
        ERG,
        ERGO,
        ESTH,
        ESTHAESTH,
        ETHNO,
        //EU,
        //EX,
        EXTRA,
        EXTRO,
        FAC,
        FACT,
        FER,
        FID,
        FLECT,
        FLOR,
        FLORA,
        FLEUR,
        FOR,
        FORE,
        FORM,
        FRACT,
        FRAG,
        FUG,
        FUNCT,
        FUS,
        GASTR,
        GASTRO,
        GEN,
        GENO,
        GENE,
        GENGENESIS,
        GEO,
        GER,
        GIGA,
        GON,
        GRAM,
        GRAN,
        GRAPH,
        GRAPHY,
        GRAT,
        GYN,
        GYNO,
        GYNE,
        GRESS,
        GRAD,
        GRADE,
        GRADI,
        HECT,
        HECTO,
        HECAT,
        HELIC,
        HELICO,
        HELI,
        HELIO,
        HEMI,
        HEM,
        HEMO,
        HEMA,
        HEPA,
        HEPT,
        HEPTA,
        HERBI,
        HETERO,
        HEX,
        HEXA,
        HISTO,
        HOMO,
        HOMEO,
        HYDR,
        HYDRO,
        HYGR,
        HYGRO,
        HYPER,
        HYP,
        HYPO,
        IATR,
        IATRO,
        ICON,
        ICONO,
        IDIO,
        //IL,
        //IG,
        //IM,
        //IR,
        IMAG,
        INFRA,
        INTER,
        INTRA,
        INTRO,
        ISO,
        JECT,
        JUD,
        JUNCT,
        JUVEN,
        KILO,
        KINE,
        KINET,
        KINEMAT,
        LAB,
        LACT,
        LACTO,
        LATER,
        LEUK,
        LEUKO,
        LEUC,
        LEUCO,
        LEX,
        LIBER,
        LINGU,
        LIP,
        LIPO,
        LITE,
        ITE,
        LITH,
        LITHO,
        LOC,
        LOG,
        LOGO,
        LOQU,
        LOCU,
        LUC,
        LUD,
        LUS,
        LUMIN,
        LUN,
        LUNA,
        LUNI,
        MACRO,
        MAGN,
        MAGNA,
        MAGNI,
        MAL,
        MALE,
        MAN,
        MANI,
        MANU,
        MAND,
        MANIA,
        MAR,
        MARI,
        MATER,
        MATR,
        MATRI,
        MAX,
        MEDI,
        MEGA,
        MELAN,
        MELANO,
        MEMOR,
        MEMORI,
        MERGE,
        MERS,
        MESO,
        META,
        METER,
        METR,
        METRY,
        MICRO,
        MID,
        MIGR,
        MILLI,
        MIN,
        MINI,
        MIS,
        MISO,
        MISS,
        MIT,
        MOB,
        MON,
        MONO,
        MOT,
        MOV,
        MORPH,
        MORPHO,
        MORT,
        MULTI,
        MUT,
        //MY,
        MYO,
        NARR,
        NAT,
        NAV,
        NECR,
        NECRO,
        NEG,
        NEO,
        NEPHR,
        NEPHRO,
        NEUR,
        NEURO,
        NOM,
        NOMIN,
        NON,
        NOT,
        NOUN,
        NUNC,
        NOV,
        NUMER,
        //OB,
        //OP,
        OCT,
        OCTA,
        OCTO,
        OCU,
        //OD,
        ODOR,
        OMNI,
        OPT,
        OPS,
        ORTHO,
        OSTEO,
        OUT,
        OVER,
        OXI,
        OXIOXY,
        PALE,
        PALEO,
        PAN,
        PARA,
        PATER,
        PATR,
        PATRI,
        PATH,
        PED,
        PEDI,
        PEDE,
        PEL,
        PENT,
        PENTA,
        PEPT,
        PEPS,
        PER,
        PERI,
        PHAG,
        PHAGE,
        PHIL,
        PHILO,
        PHON,
        PHONO,
        PHONE,
        PHONY,
        PHOT,
        PHOTO,
        PHYLL,
        PHYLLO,
        PHYS,
        PHYT,
        PHYTO,
        PHYTE,
        PLAS,
        PLAST,
        PLASM,
        PLAUD,
        PLOD,
        PLAUS,
        PLOS,
        PNEUM,
        PNEUMO,
        POD,
        PODE,
        POLI,
        POLY,
        PON,
        POP,
        PORT,
        POS,
        POST,
        PRE,
        PRO,
        PROT,
        PROTO,
        PSEUD,
        PSEUDO,
        PSYCH,
        PSYCHO,
        PUGN,
        PUGNA,
        PUNG,
        PUL,
        PURG,
        PUT,
        PYR,
        PYRO,
        QUAD,
        QUADR,
        QUADRI,
        QUART,
        QUIN,
        QUINT,
        RADIC,
        RADIX,
        RADIO,
        RAM,
        RAMI,
        //RE,
        REG,
        RETRO,
        RHIN,
        RHINO,
        RHOD,
        RHODO,
        RID,
        RRH,
        RRHEA,
        RRHOEA,
        RRHAG,
        RUB,
        RUPT,
        SAN,
        SCEND,
        SCI,
        SCLER,
        SCLERO,
        SCOP,
        SCOPE,
        SCOPY,
        SCRIB,
        SCRIPT,
        //SE,
        SECT,
        SED,
        SID,
        SESS,
        SELF,
        SEMI,
        SEPT,
        SEPTI,
        SERV,
        SEX,
        SOL,
        SOMN,
        SOMNI,
        SON,
        SOPH,
        SPEC,
        SPECT,
        SPIC,
        SPHERE,
        SPIR,
        STA,
        STELL,
        STRUCT,
        SUB,
        SUM,
        SUPER,
        //SY,
        SYM,
        SYN,
        SYL,
        SYS,
        TACT,
        TANG,
        TAX,
        TAXO,
        TECHNO,
        TEL,
        TELE,
        TELO,
        TEMP,
        TEMPOR,
        TEN,
        TIN,
        TENT,
        TER,
        TRIT,
        TERM,
        TERMINA,
        TERR,
        TERRA,
        TERRI,
        TETRA,
        THE,
        THEO,
        THERM,
        THERMO,
        TORT,
        TOX,
        TRACT,
        TRANS,
        TRI,
        ULTRA,
        //UN,
        UNI,
        URB,
        VAC,
        VEN,
        VENT,
        VER,
        VERI,
        VERB,
        VERS,
        VERT,
        VICE,
        VID,
        VINCE,
        VIC,
        VIS,
        VIV,
        VIVI,
        VIT,
        VOC,
        VOCI,
        VOL,
        VOLI,
        VOLU,
        VOR,
        VOUR,
        XANTH,
        XEN,
        XENO,
        XER,
        XERO,
        XERI,
        XYL,
        //ZO,
        ZOO,
        ZYG,
        ZYGO,
    }
}
