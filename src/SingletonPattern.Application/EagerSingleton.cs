namespace SingletonPattern.Application
{
    public sealed class EagerSingleton : Foo
    {
        private EagerSingleton()
        {
        }

        public static EagerSingleton Instance { get; } = new EagerSingleton();
    }
}