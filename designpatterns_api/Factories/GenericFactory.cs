

namespace SharedLib.Factories;

/// <summary>
/// This GenericFactory is an overall factory to create instances of any class in the project to prevent creating an instance of a class in the controllers.
/// </summary>

public static class GenericFactory
{
    public static T Create<T>() where T : class, new()
    {
     
        return new T();

    }
}
