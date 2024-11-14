using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace fasz
{

    public interface ISzotar<T>
    {
        void Kikerdez();
        void Ujszopar(T key, T value);
        void Torol(T key);
        void Listaz();
        void FajlbaMent(string fajl);
    }

    internal class SajatSzotar : ISzotar<string>
    {
        private Dictionary<string, string> szotar = new Dictionary<string, string>();
        private Random random = new Random();

        public SajatSzotar(string fajl)
        {
            try
            {
                using (StreamReader r = new StreamReader(fajl))
                {
                    string line;
                    while ((line = r.ReadLine()) != null)
                    {
                        string[] parts = line.Split(' ');
                        if (parts.Length == 2)
                        {
                            szotar[parts[0]] = parts[1];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hiba a file megnyitásakor" + ex.Message);
            }
        }

        public void FajlbaMent(string fajl)
        {
            throw new NotImplementedException();
        }

        public void Kikerdez()
        {
            throw new NotImplementedException();
        }

        public void Listaz()
        {
            throw new NotImplementedException();
        }

        public void Torol(string key)
        {
            throw new NotImplementedException();
        }

        public void Ujszopar(string key, string value)
        {
            throw new NotImplementedException();
        }
    }

    public void Kikerdez()
    {
        while (true)
        {
            int index = random.Next(szotar.Count);
        }
    }



    public class Program
    {
        public static void Main()
        {
            SajatSzotar = new SajatSzotar("szotar.txt");
            szotar.Kikerdez();
            szotar.Ujszopar("fa", "tree");
            szotar.Listaz();
            szotar.Torol("madár");
            szotar.Listaz();

            szotar.FajlbaMent("uj_szotar.txt");
        }

    }
}