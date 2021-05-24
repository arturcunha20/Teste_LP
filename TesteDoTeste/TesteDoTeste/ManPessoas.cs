using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace TesteDoTeste
{
    class ManPessoas
    {
        protected static Dictionary<string, List<Pessoa>> PessoasTable = new Dictionary<string, List<Pessoa>>();

        public static bool ManPessoas_Add(Pessoa p)
        {
            if (PessoasTable.ContainsKey(p.AnoLectivo) == false)
            {
                PessoasTable.Add(p.AnoLectivo, new List<Pessoa>());

                p.Id = PessoasTable[p.AnoLectivo].Count;

                PessoasTable[p.AnoLectivo].Add(p);
                return true;
            }
            else
            {
                p.Id = PessoasTable[p.AnoLectivo].Count;
                PessoasTable[p.AnoLectivo].Add(p);
                return true;
            }

            return false;
        }

        public static void Find_Pessoa(string anoLetivo)
        {
            if (PessoasTable.ContainsKey(anoLetivo) == true)
            {
                List<Pessoa> pessoasMas = new List<Pessoa>(PessoasTable[anoLetivo]);

                foreach(Pessoa p in pessoasMas)
                {
                    Console.WriteLine(p.AnoLectivo + " " + p.Nome + " " + p.Id);
                }
                /*
                foreach (var s in PessoasTable)
                {
                    if(s.Key == anoLetivo)
                    {
                        foreach (Pessoa p in s.Value)
                        {
                            Console.WriteLine(p.AnoLectivo + " " + p.Nome + " " + p.Id);
                        }
                    }
                }
                */
            }
        }

        public static void listar()
        {
            foreach (var s in PessoasTable)
            {
                foreach (Pessoa p in s.Value)
                {
                    Console.WriteLine(p.AnoLectivo + " " + p.Nome + " " + p.Id);
                }
            }
        }
    }
}
