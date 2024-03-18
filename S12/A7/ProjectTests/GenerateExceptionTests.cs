namespace A7.Tests;

[TestClass]
public class GenerateExceptionTests
{
    [ExpectedException(typeof(InvalidDataException))]
    [TestMethod]
    public void ThrowNewExceptionTest()
    {
        ExceptionHandler.ThrowIfOdd(5);
    }

    [TestMethod]
    public void DoNotThrowNewExceptionTest()
    {
        ExceptionHandler.ThrowIfOdd(6);
    }
}
