namespace A7.Tests;

[TestClass]
public class FormatExceptionTests
{
    #region FormatException

    [TestMethod]
    public void TestNoFormatException()
    {
        ExceptionHandler eh = new ExceptionHandler("3", false);
        eh.FormatExceptionMethod();
        Assert.AreEqual(eh.ErrorMsg, null);
    }

    [TestMethod]
    [ExpectedException(typeof(FormatException))]
    public void TestThrowFormatException()
    {
        ExceptionHandler eh = new ExceptionHandler("123KB", false);
        eh.FormatExceptionMethod();
    }

    [TestMethod]
    public void TestCatchFormatException()
    {
        ExceptionHandler eh = new ExceptionHandler("123KB", false, true);
        eh.FormatExceptionMethod();

        Assert.AreEqual(
            $"Caught exception {typeof(FormatException)}",
            eh.ErrorMsg);
    }
    #endregion

}
