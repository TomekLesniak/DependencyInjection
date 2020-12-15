namespace DependencyInjcetionLibrary
{
    public class Phone : IPhone
    {
        private readonly ICalculator _calculator;
        private readonly IMessageService _messageService;

        public Phone(ICalculator calculator, IMessageService messageService)
        {
            _calculator = calculator; //injected
            _messageService = messageService; //injected
        }

        public ICalculator RunCalculator() => _calculator;

        public IMessageService RunMessageService() => _messageService;
    }
}
