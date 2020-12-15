using System;
using System.Collections.Generic;
using System.Text;
using DependencyInjcetionLibrary;

namespace DependecyInjcetionApp
{
    public class Application : IApplication
    {
        private readonly IPhone _phone;

        public Application(IPhone phone)
        {
            _phone = phone;
        }

        public void Run() // Simple example usage of program.
        {
            var calculator = _phone.RunCalculator();
            Console.WriteLine($"Add 10 + 20 = {calculator.Add(10,20)}");

            var smsService = _phone.RunMessageService();
            smsService.SendMessage("This is dependency injection in action :)", "Tomek");
        }
    }
}
