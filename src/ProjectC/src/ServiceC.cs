using ProjectA;

namespace ProjectC;

public class ClassC
    : IService
{
    public void DoSomething(string param)
    {
    }

    public void DoSomething(string stringParam, int intParam)
    {
        throw new NotImplementedException();
    }
}