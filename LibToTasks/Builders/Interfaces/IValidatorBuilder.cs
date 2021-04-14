using LibToTasks.Validation.Interfaces;

namespace LibToTasks.Builders.Abstracts
{
    public interface IValidatorBuilder
    {
        IValidator Create();
    }
}
