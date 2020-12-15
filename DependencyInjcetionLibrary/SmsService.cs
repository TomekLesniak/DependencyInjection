using System;

namespace DependencyInjcetionLibrary
{
    public class SmsService : IMessageService
    {
        public void SendMessage(string message, string receiver)
        {
            Console.WriteLine($"Sending   `{message}`   to {receiver}");
        }
    }
}