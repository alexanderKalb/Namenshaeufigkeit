using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namensliste
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> namensAnzahl = new Dictionary<string, int>();
            List<string> eingegebeneNamen = new List<string>();

            Console.WriteLine("Namen eingeben!");
            while(true)
            {
                string temp = Console.ReadLine();
                if (temp == "")
                {
                    break;
                }
                eingegebeneNamen.Add(temp);
            }

            foreach(string name in eingegebeneNamen) 
            {
                if (namensAnzahl.ContainsKey(name))
                {
                    namensAnzahl[name] += 1;
                } 
                else
                {
                    namensAnzahl.Add(name, 1);
                }
            }

            List<string> BossName = new List<string>();
            int max = 0;
            foreach (KeyValuePair<string, int> nameZ in namensAnzahl)
            {
                int anzahl = nameZ.Value;

                if (anzahl > max)
                {
                    max = anzahl;
                    BossName.Clear();
                    BossName.Add(nameZ.Key);
                }
                else if (anzahl == max)
                {
                    BossName.Add(nameZ.Key);
                }
            }

            foreach(string maxName in BossName)
            {
                Console.WriteLine("{0} Vorkommen: {1}", namensAnzahl[maxName], maxName);
            }
            Console.ReadKey();
        }
    }
}
