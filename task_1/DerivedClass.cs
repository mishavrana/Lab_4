using System.Security.Cryptography;

namespace Lab4;

public class DerivedClass: BaseClass
{
    internal override void WriteInDebug(string stringParam, int intParam)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Param of type " + stringParam.GetType());
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Param of type " + intParam.GetType());
    }
}