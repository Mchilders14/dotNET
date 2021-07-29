using System;
using System.Collections.Generic;

namespace CharacterCounter
{
    class Program
    {
        static string[] strings = new string[] {
"rznmudAcfQJALZUQZqPJ",
"IrEQRDwFMcYBDahKbzgC",
"HBoZnbqoGSxltFwRXKjH",
"qclXsjxnzGpfAcBDupwV",
"RnixpSVqafaIllIltOyK",
"LbQxiWhKwqtKTOvTkkHl",
"ODgKrkdYsfJPRRxetoIy",
"DNSDcxrdjxlKqccPEzqi",
"WIcoehJKCkSDyGgdBqpY",
"jZxTPoMNgWzsWmcGgHNw",
"pMoHVtQddwynAhiwAbmd",
"DNXwJOWmDkhpugabOwjp",
"LpeMzQpqRIbKozbcXpmv",
"PGizIhwDNJlQYnzkauZm",
"xowohUKXbwzdqCVqSBfv",
"NvPMhbDyIjAGPsBvjAEg",
"UvEnpcXWSwaJpWYkneks",
"YlStgnovpXTnHJZkXDUf",
"VgIZMgJnfIOtRnPRVSSn",
"pIywxqLlTWytOnzymHfg",
"CqzFWHKAfCLLafRkhglE",
"EFogGzYVfFnIkTEyRNjh",
"KjNFeEIHzeEstGyECwFu",
"hICByteiKmlhWFNGszyA",
"HdeOYczkDLymLWckxiBJ",
"TnuIcRGJHZVgHuxnkktO",
"XEUerbXWdgwcGPUhPzLV",
"KmyDJahKIJeGvDczElPu",
"briWqrDSuhDWqlPYuCzq",
"JSZlIcvCNYAdSMfpngYu",
"XgitRfxjkGZQORQGzRcj",
"ppvTnlGVInsioumZAcgD",
"WlAKuBETWiYYZrnplbgu",
"LxLhdzNYaXHQajBbduBI",
"dKCJrdeBjqsOURPfLTea",
"vcuVLuipqDhHqaNKLIej",
"NOeKllZUHOwFHxnZPFne",
"JqhweTQQDUIbmggyOnEd",
"rthqWdSiEmiumcHkOdsF",
"BaZyhhhKDCvkFCuVPYDn",
"kRTbRPYatFeMDnwNUMCx",
"tLTjnCJLgjKEjqBdnvoS",
"ZtHPMSoVDPAMeCKacuQo",
"xTKpzldxxcGipiLFqGXL",
"EJDITqZNmdkjMkBlRiNr",
"qOPVrHuNpmIfcsewZdQM",
"EHeLrExAbqjMQsokZaAE",
"RVVDswZQzSuzDDiARycC",
"DbVwEaMorXtHjnQoZePQ",
"HJEqDrHLFaTmYuODVFGk",
"XnuuRrViRZvVgiHYasrb",
"HOECHnUaYEsZDlmEEoYG",
"ttvVDYrsVhjQJkoazMdy",
"BqikNCEQlYxMuzyRWdRX",
"HWaahxPMOplxuJWtACHf",
"FdImyzofzqCYDJfWGkUJ",
"FHtdnxHHVfvyhqLJaNqn",
"cnxvlHLQwXPOdlHpAcmk",
"oKadLxJbBUKgyoGYzkhJ",
"EkYruLghbXdggJNDVlIy",
"eLjBUPKZDtHycoYyWiAW",
"JgYazmeznFxqBOhadgTc",
"CaQtYCZvjkxasJIcFUGW",
"mnwBvOXbVShRCMjAdlXs",
"zAQDfwYxgRnWFKGlYUSv",
"LnsmkeIfWvqhhmzrEzSZ",
"BsUDfukrUfTUbiRsPzYp",
"kObAeLktYxoqJCIvauhA",
"baYesOdgNXpNooahHZku",
"bZufbRyDSmbbVngLudPc",
"RftuFrzIYFczHytejpHI",
"QFlnZYNKNJARJQSqGBeD",
"gCrgdtFVkKVokComQnWy",
"lskjLAMNcDZhwIwOXXgO",
"erATBNkHvsiOYYfXfSTg",
"ucekVhZSdVjuuGqVJRmC",
"NIMOAHJXkBGLDFQMUCUI",
"GppkxdwnntjtjHChXKJc",
"iSEJefUFBgrgZlbSbckl",
"plOpiCqiZbTIfmTRHBzi",
"HobGeYfblEkbQVnflslr",
"guhwbRCVNXeUIjbyyhzK",
"eCLpDBvjPbReDHBRaQfn",
"ODuwUWBlVQVIQHWGqwEX",
"gkQqtHHZdIjMlFKKdtHv",
"gQdWYUpiZjASmTrmeGlo",
"svyEWezWFTmnrURwgPty",
"poOmzeLXnUTMyRfhwSAB",
"UOLrIgvzsaZmrmHuHYFw",
"qxiBWCDWqAMPqMbrOXxR",
"CaRlZGPGWuKnEQEduoEA",
"QnmoawMCyOJpWhsKKhMs",
"iFuyqrBlQAmxiMrtZdlS",
"BvJpCUIpxbbOGaihbMYp",
"qwFvGUWygPkGFfCLnjLT",
"OPTsxdoDzXBlRxxlsXmb",
"LNdTHLnwWNHMidIcCCTD",
"gekUeUhvvtMhbExngIST",
"pdXVFqucEIprQdhNSnRs",
"MqDUMNbIFnqaQkcKonAW"
        };


        static Dictionary<char, int> StringCount = new Dictionary<char, int>();

        static void Main(string[] args)
        {
            foreach (var str in strings)
            {
                foreach (var ch in str.ToCharArray())
                {
                    var chr = Convert.ToChar(ch.ToString().ToLower());
                    if (StringCount.ContainsKey(chr))
                    {
                        StringCount[chr]++;
                        continue;
                    }
                    StringCount.Add(chr, 1);
                }
            }
        }
    }
}
