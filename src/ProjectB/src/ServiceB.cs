using ProjectA;

namespace ProjectB;

public sealed class ServiceB
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