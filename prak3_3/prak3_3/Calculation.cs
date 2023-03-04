using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak3_3
{
    internal class Calculation
    {
        public string calculationLine  { get; set; }

        public void SetCalculationLin() 
        {
            calculationLine = Console.ReadLine();
        }

        public void SetLastSymbolCalculationLine()
        {
            string? b= Console.ReadLine();
            calculationLine += b;
        }
        public void GetCalculationLin()
        {
            Console.WriteLine(calculationLine);
        }
        public void GetLastSymbo() 
        { 
            Console.WriteLine(calculationLine.Substring(calculationLine.Length - 1));
        }

        public void DeleteLastSymbol() 
        {
            calculationLine = calculationLine[..^1];
        }
    }
   
}
