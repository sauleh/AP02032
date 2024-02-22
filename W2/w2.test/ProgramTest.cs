namespace w2.test;
using w2.ocon; 

[TestClass]
public class ProgramTest
{
    [TestMethod]
    public void AddTest()
    {
        int r = Program.add(5, 6);
        Assert.AreEqual(11, r);
    }
}