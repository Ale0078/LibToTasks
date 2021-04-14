using LibToTasks.Builders.Interfaces;
using LibToTasks.Validation;
using LibToTasks.Validation.Interfaces;

namespace LibToTasks.Builders
{
    public class DefaultValidatorBuilder : IValidatorBuilder
    {
        public IValidator Create() 
        {
            return new Validator();
        }
    }
}
