

namespace designpatterns_api.Factories;


/// <summary>
/// This GenericFactory is an overall factory to 
/// create instances of any class in the project to prevent creating an instance of a class in the controllers.
/// With this factory we can prevent to repeat our selfs to many times DRY and it does also just have the one responibility.
/// So we are fullfilling the principle of SRP.
/// </summary>

public static class GenericFactory
{
    public static T Create<T>() where T : class, new()
    {
     
        return new T();

    }
}
