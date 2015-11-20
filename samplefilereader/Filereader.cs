using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace testfilereader
{
    public class Filereader
    {
       public string reading(string filename)
        {
            string content = System.IO.File.ReadAllText(filename);
            //return content.Replace("Balaji","India");
            return content;

        }
    }
}
