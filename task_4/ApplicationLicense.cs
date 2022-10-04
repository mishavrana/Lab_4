namespace task_4;

public class ApplicationLicense
{
    virtual public void AllowTrial()
    {
        Console.WriteLine("Триальниий режиим");
    }

    virtual public void AllowCommon()
    {
        Console.WriteLine("Безкоштовна версія");
    }

    virtual public void AllowPro()
    {
        Console.WriteLine("Платна версія");
    }
}