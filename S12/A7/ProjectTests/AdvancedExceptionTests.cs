namespace A7.Tests;
[TestClass]
public class AdvancedExceptionTests
{
    #region Finally

    [TestMethod]
    public void TestFinallyBlockNoExceptionNoReturn()
    {
        ExceptionHandler eh = new ExceptionHandler(
            "1", false, false);

        string keyword = "beautiful";
        eh.FinallyBlockMethod(keyword);
        Assert.AreEqual(
            $"InTryBlock:beautiful:9:DoneWriting:InFinallyBlock:EndOfMethod",
            eh.FinallyBlockStringOut);
    }

    [TestMethod]
    public void TestFinallyBlockNoExceptionWithReturn()
    {
        ExceptionHandler eh = new ExceptionHandler(
            "1", false, false);

        string keyword = "ugly";
        eh.FinallyBlockMethod(keyword);
        Assert.AreEqual(
            $"InTryBlock::InFinallyBlock",
            eh.FinallyBlockStringOut);

    }


    [TestMethod]
    public void TestFinallyBlockException()
    {
        ExceptionHandler eh = new ExceptionHandler(
            "1", false, true);

        eh.FinallyBlockMethod(null);
        Assert.AreEqual(
            "InTryBlock::Object reference not set to an instance of an object.:InFinallyBlock:EndOfMethod",
            eh.FinallyBlockStringOut);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void TestFinallyBlockExceptionNoCatch()
    {
        ExceptionHandler eh = new ExceptionHandler(
            "1", false, false);

        try
        {
            eh.FinallyBlockMethod(null);
            Assert.Fail("Method Did not throw");
        }
        catch
        {
            Assert.AreEqual(
                "InTryBlock::Object reference not set to an instance of an object.:InFinallyBlock",
                eh.FinallyBlockStringOut);
            throw;
        }
    }

    #endregion

    #region Nested
    [ExpectedException(typeof(NotImplementedException))]
    [TestMethod]
    public void NestedExceptionTest()
    {
        string[] expectedCallStack = new string[]
        {
                "MethodD()", "MethodC()", "MethodB()", "MethodA()",
                "NestedMethods()", "NestedExceptionTest()"
        };

        try
        {
            ExceptionHandler.NestedMethods();
            Assert.Fail("NestedExceptionTest did not throw exception.");
        }
        catch (NotImplementedException e)
        {
            string[] methods = GetMethods(e.StackTrace);
            CollectionAssert.AreEqual(expectedCallStack, methods);
            throw;
        }
    }
    #endregion

    #region HelperMethods
    private string[] GetMethods(string stackTrace)
    {
        List<string> result = new List<string>();
        foreach (var line in stackTrace.Split(new char[] { '\n', '\r' },
            StringSplitOptions.RemoveEmptyEntries))
        {
            var toks = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            result.Add(RemoveNameSpace(toks[1]));
        }
        return result.ToArray();
    }

    private string RemoveNameSpace(string v)
    {
        var toks = v.Split('.');
        return toks[toks.Length - 1];
    }
    #endregion
}
