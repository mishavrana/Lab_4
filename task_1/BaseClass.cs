using System.Diagnostics;

namespace Lab4;

public class BaseClass
{
    virtual internal void WriteInDebug(string stringParam, int intParam)
    {
        Debug.WriteLine("String parameter: " + stringParam);
        Debug.WriteLine("Int parameter: " + intParam);
    }
}