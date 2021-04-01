using System;
using NLog;

namespace LibToTasks.Validation
{
    public class Transformator
    {
        private ILogger _logger;

        public Transformator() 
        {
            _logger = LogManager.GetCurrentClassLogger();
        }

        public TResult ConfirmConversion<TResult, TValue>(TValue valueToConverting)
        {
            if (valueToConverting == null)
            {
                _logger.Error("Value {0} cannot be converted to {1}", valueToConverting, typeof(TResult));
                throw new FormatException($"We cannot convert this value to {typeof(TResult)}");
            }

            try
            {
                TResult result = (TResult)Convert.ChangeType(valueToConverting, typeof(TResult));
                _logger.Info("Value {0} can be converted to {1}", valueToConverting, typeof(TResult));

                return result;
            }
            catch
            {
                _logger.Error("Value {0} cannot be converted to {1}", valueToConverting, typeof(TResult));
            }

            throw new FormatException($"We cannot convert this value to {typeof(TResult)}");
        }
    }
}
