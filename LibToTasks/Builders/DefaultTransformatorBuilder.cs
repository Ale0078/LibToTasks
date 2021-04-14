using LibToTasks.Builders.Interfaces;
using LibToTasks.Validation;
using LibToTasks.Validation.Interfaces;

namespace LibToTasks.Builders
{
    public class DefaultTransformatorBuilder : ITransformatorBuilder
    {
        public ITransformator Create() 
        {
            return new Transformator();
        }
    }
}
