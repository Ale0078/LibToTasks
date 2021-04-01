using System;
using NLog;

namespace LibToTasks.Validation
{
    public class Validator 
    {
        private  ILogger _logger;

        public Validator() 
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public T CheckValue<T>(Func<T, bool> checking, T valueToChecking, bool withException = true) 
        {
            if (checking.Invoke(valueToChecking)) 
            {
                _logger.Info("Value {0} passed checking", valueToChecking);

                return valueToChecking;
            }            

            _logger.Error("Value {0} didn`t pass checking", valueToChecking);

            if (withException)
            {
                throw new FormatException("Yuor value too small or big");
            }

            return default;
        }
    }
}
