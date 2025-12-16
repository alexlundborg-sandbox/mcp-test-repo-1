namespace HelloWorld;

/// <summary>
/// Interface for greeting service functionality.
/// </summary>
public interface IGreetingService
{
    /// <summary>
    /// Returns a standard greeting.
    /// </summary>
    /// <returns>A greeting string.</returns>
    string GetGreeting();

    /// <summary>
    /// Returns a personalized greeting for the specified name.
    /// </summary>
    /// <param name="name">The name to greet.</param>
    /// <returns>A personalized greeting string.</returns>
    string GetGreeting(string name);
}
