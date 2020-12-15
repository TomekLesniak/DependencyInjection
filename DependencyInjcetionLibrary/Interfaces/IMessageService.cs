namespace DependencyInjcetionLibrary
{
    public interface IMessageService
    {
        void SendMessage(string message, string receiver);
    }
}