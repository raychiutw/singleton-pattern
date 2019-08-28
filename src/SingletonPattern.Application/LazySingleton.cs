namespace SingletonPattern.Application
{
    public sealed class LazySingleton : Foo
    {
        private LazySingleton()
        {
        }

        public static LazySingleton Instance
        {
            get
            {
                return InnerClass.Instance;
            }
        }

        private class InnerClass
        {
            internal static readonly LazySingleton Instance = new LazySingleton();

            static InnerClass()
            {
            }
        }
    }
}