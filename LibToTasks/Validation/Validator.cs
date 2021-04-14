using System;
using NLog;

using LibToTasks.Validation.Interfaces;

namespace LibToTasks.Validation
{
    internal class Validator : IValidator//ToDo: interface
    {
        private  ILogger _logger;

        public Validator() 
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public bool CheckValue<T>(Func<T, bool> checking, T valueToChecking, bool withException = true) 
        {
            if (checking.Invoke(valueToChecking)) 
            {
                _logger.Info("Value {0} passed checking", valueToChecking);

                return true;
            }            

            _logger.Error("Value {0} didn`t pass checking", valueToChecking);

            if (withException)
            {
                throw new FormatException("Yuor value too small or big");
            }

            return false;
        }
    }
}
