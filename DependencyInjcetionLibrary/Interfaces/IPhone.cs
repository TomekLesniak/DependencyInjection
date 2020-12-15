namespace DependencyInjcetionLibrary
{
    public interface IPhone
    {
        ICalculator RunCalculator();
        IMessageService RunMessageService();
        
        //... More logic
    }
}