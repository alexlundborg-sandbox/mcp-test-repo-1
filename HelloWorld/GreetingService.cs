namespace HelloWorld;

/// <summary>
/// Service that provides greeting functionality.
/// </summary>
public class GreetingService : IGreetingService
{
    /// <summary>
    /// Returns a standard "Hello, World!" greeting.
    /// </summary>
    /// <returns>A greeting string.</returns>
    public string GetGreeting()
    {
        return "Hello, World!";
    }

    /// <summary>
    /// Returns a personalized greeting for the specified name.
    /// </summary>
    /// <param name="name">The name to greet.</param>
    /// <returns>A personalized greeting string.</returns>
    public string GetGreeting(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            return GetGreeting();
        }
        
        return $"Hello, {name}!";
    }
}
