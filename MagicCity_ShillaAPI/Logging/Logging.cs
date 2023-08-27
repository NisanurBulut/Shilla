namespace MagicCity_ShillaAPI.Logging
{
    public class Logging : ILogging
    {
        void ILogging.Log(string message, string type)
        {
            if(message == "error")
            {
                Console.WriteLine("ERROR - {message}", message);
            }
            else
            {
                Console.WriteLine(message);
            }
        }
    }
}
