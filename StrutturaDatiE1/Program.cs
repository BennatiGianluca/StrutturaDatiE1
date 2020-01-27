using System;
using System.Collections.Generic;
using System.IO;

namespace StrutturaDatiE1
{
    class Program
    {
        private const string file = @"FileDiTesto.txt"; 
        private const string file1 = @"FileDiTesto1";
        static void Main(string[] args)
        {
            List<double> lista = new List<double>();
            using (StreamReader file = new StreamReader("FileDiTesto.txt"))
            {
                string Line;
                while ((Line = file.ReadLine()) != null)
                {
                    lista.Add(double.Parse(Line));
                }
            }
            using (StreamWriter file1 = new StreamWriter("FileDiTesto.txt"))
            {
                for (int i = lista.Count - 1; i >= 0; i--)
                {
                    file1.WriteLine(lista[i]);
                }
            }
        }
    }
}
