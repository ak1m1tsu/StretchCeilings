namespace StretchCeilings.Repositories
{
    public abstract class NotNull
    {
        protected static bool IsNull<T>(T source) => source == null;
    }
}
