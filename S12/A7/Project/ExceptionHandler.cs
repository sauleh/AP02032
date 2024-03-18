using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace A7;

public class ExceptionHandler
{
    public string ErrorMsg { get; set; }
    public readonly bool DoNotThrow;
    private string _Input;

    public string Input
    {
        get
        {
            try
            {
                if (_Input.Length < 50)
                    return _Input;
            }
            catch
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = "Caught exception in GetMethod";
            }
            return null;
        }
        set
        {
            try
            {
                if (value.Length < 50)
                    _Input = value;
            }
            catch
            {
                if (!DoNotThrow)
                    throw;
                ErrorMsg = "Caught exception in SetMethod";
            }
        }
    }


    public ExceptionHandler(
        string input,
        bool causeExceptionInConstructor,
        bool doNotThrow=false)
    {
        DoNotThrow = doNotThrow;
        this._Input = input;
        try
        {
            if (causeExceptionInConstructor)
            {
                string test = null;
                if (test.Length > 0)
                    Console.WriteLine("test");
            }
        }
        catch
        {
            if (!DoNotThrow)
                throw;
            ErrorMsg = "Caught exception in constructor";
        }
    }

    public void OverflowExceptionMethod()
    {
        #region TODO
        #endregion
    }

    public void FormatExceptionMethod()
    {
        try
        {
            int i = int.Parse(Input);
        }
        catch(FormatException e)
        {
            if (!DoNotThrow)
                throw;
            ErrorMsg = $"Caught exception {e.GetType()}";
        }
    }

    public void FileNotFoundExceptionMethod()
    {
        #region TODO
        #endregion
    }

    public void IndexOutOfRangeExceptionMethod()
    {
        #region TODO
        #endregion
    }

    public void OutOfMemoryExceptionMethod()
    {
        #region TODO
        #endregion
    }

    public void MultiExceptionMethod()
    {
        #region TODO
        #endregion
    }

    public static void ThrowIfOdd(int n)
    {
        #region TODO
        #endregion
    }

    public string FinallyBlockStringOut;

    public void FinallyBlockMethod(string s)
    {
        StringBuilder sb = new StringBuilder();
        StringWriter swr = new StringWriter(sb);
        try
        {
            #region TODO
            #endregion
        }
        catch (NullReferenceException nre)
        {
            #region TODO
            #endregion
        }
        finally
        {
            swr.Write(":InFinallyBlock");
            swr.Dispose();
            FinallyBlockStringOut = sb.ToString();
        }
        FinallyBlockStringOut += ":EndOfMethod";
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void NestedMethods()
    {
        #region TODO
        #endregion
    }

    #region TODO
    #endregion
}
