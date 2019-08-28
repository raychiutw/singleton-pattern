namespace SingletonPattern.Application
{
    public sealed class SimpleThreadSafetySingleton : Foo
    {
        private static readonly object padlock = new object();

        private static SimpleThreadSafetySingleton _instance = null;

        private SimpleThreadSafetySingleton()
        {
        }

        public static SimpleThreadSafetySingleton Instance
        {
            get
            {
                lock (padlock)
                {
                    if (_instance == null)
                    {
                        _instance = new SimpleThreadSafetySingleton();
                    }
                    return _instance;
                }
            }
        }
    }
}