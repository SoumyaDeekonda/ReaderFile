using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testfilereader;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Filereader x = new Filereader();
            string fileContent = x.reading(@"C:\Data\Root\Code\test.txt");
            Console.WriteLine(fileContent);
            Console.Read();
        }
    }
}
