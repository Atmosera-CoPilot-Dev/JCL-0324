namespace DemoApp
{
    public class Util
    {
        public static string GetWelcomeMessage()
        {
            return WelcomeMessageGenerator.GetRandomWelcomeMessage();
        }
    }


    
    internal static class WelcomeMessageGenerator
    {
        public static string GetRandomWelcomeMessage()
        {
            string[] messages = new string[]
            {
                "Hello, World!",
                "Welcome to the world of C#!",
                "C# is a powerful language!",
                "C# is a great language for beginners!",
                "C# is a great language for experts!",
                "C# is a great language for everyone!"
            };
            return messages[new Random().Next(0, messages.Length)];
        }
    }
}
