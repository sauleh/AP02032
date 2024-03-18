namespace A7.Tests;

[TestClass]
public class ConstructorTests
{
    #region Constructor Tests
    [TestMethod]
    public void TestNoConstructorException()
    {
        ExceptionHandler eh = new ExceptionHandler(string.Empty, false);
        Assert.AreEqual(eh.ErrorMsg, null);
    }

    [TestMethod]
    [ExpectedException(typeof(NullReferenceException))]
    public void TestThrowConstructorException()
    {
        ExceptionHandler eh = new ExceptionHandler(string.Empty, true);
    }

    [TestMethod]
    public void TestCatchConstructorException()
    {
        ExceptionHandler eh = new ExceptionHandler(string.Empty, true, true);
        Assert.AreEqual(
            "Caught exception in constructor",
            eh.ErrorMsg);
    }

    #endregion

}
