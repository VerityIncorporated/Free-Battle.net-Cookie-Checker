using System.Drawing;

namespace FreeChecker.Utils;

public class Log
{
    public enum Type
    {
        Message,
        ValidCheck,
        InvalidCheck,
        Error
    }

    public void SendMessage(string message, Type messageType)
    {
        switch (messageType)
        {
            case Type.Message:
                Colorful.Console.WriteLine($"Message Log: @ {DateTime.Now:HH:mm:ss} | {message}", Color.Aqua);
                break;
            case Type.ValidCheck:
                Colorful.Console.WriteLine($"Valid Log: @ {DateTime.Now:HH:mm:ss} | {message}", Color.DarkGreen);
                break;
            case Type.InvalidCheck:
                Colorful.Console.WriteLine($"Invalid Log: @ {DateTime.Now:HH:mm:ss} | {message}", Color.Red);
                break;
            case Type.Error:
                Colorful.Console.WriteLine($"Error Log: @ {DateTime.Now:HH:mm:ss} | {message}", Color.Red);
                break;
        }
    }
}