using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testfilereader
{
    [TestClass]
   public class testingreader
    {
        [TestMethod]
        public void testreader()
        {
            Filereader filereader = new Filereader();
            string reader = filereader.reading(@"C:\soumya\ReadFile\read.txt");
            Assert.AreEqual("I love India", reader);

        }
    }
}
