using System;

namespace LibToTasks.Validation.Interfaces
{
    public interface IValidator
    {
        bool CheckValue<T>(Func<T, bool> checking, T valueToChecking, bool withException = true);
    }
}
