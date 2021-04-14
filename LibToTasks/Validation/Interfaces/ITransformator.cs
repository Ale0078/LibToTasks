namespace LibToTasks.Validation.Interfaces
{
    public interface ITransformator
    {
        TResult ConfirmConversion<TResult, TValue>(TValue valueToConverting);
    }
}
