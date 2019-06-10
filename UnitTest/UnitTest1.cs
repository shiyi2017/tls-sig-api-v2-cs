using Microsoft.VisualStudio.TestTools.UnitTesting;
using tecentyun;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            TLSSigAPI api = new TLSSigAPI(1400000000, "5bd2850fff3ecb11d7c805251c51ee463a25727bddc2385f3fa8bfee1bb93b5e");
            string sig = api.GenSig("xiaojun");
            System.Console.WriteLine(sig);
        }
        [TestMethod]
        public void TestMethod2()
        {
            TLSSigAPI api = new TLSSigAPI(1400000000, "5bd2850fff3ecb11d7c805251c51ee463a25727bddc2385f3fa8bfee1bb93b5e");
            for (int i = 0; i < 100; i++)
            {
                string sig = api.GenSig("xiaojun");
                System.Console.WriteLine(sig);
            }
        }
    }
}
