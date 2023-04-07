using System;

namespace ImprimirDatas {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Digite a data no formato DD/MM/AAAA: ");
            string data = Console.ReadLine();
           

            DateTime dataObj = DateTime.ParseExact(data, "dd/MM/yyyy", null);

            string dataAAAAMMDD = dataObj.ToString("yyyy/MM/dd");
            Console.WriteLine($"Data no formato AAAA/MM/DD: {dataAAAAMMDD}");

            string dataAAMMDD = dataObj.ToString("yy/MM/dd");
            Console.WriteLine($"Data no formato AA/MM/DD: {dataAAMMDD}");
        }
    }
}