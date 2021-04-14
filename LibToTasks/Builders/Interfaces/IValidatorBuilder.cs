using LibToTasks.Validation.Interfaces;

namespace LibToTasks.Builders.Interfaces
{
    public interface IValidatorBuilder
    {
        IValidator Create();
    }
}
