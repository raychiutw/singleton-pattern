namespace SingletonPattern.Application
{
    public sealed class DoubleCheckedLockingSingleton : Foo
    {
        private static readonly object padlock = new object();
        private static DoubleCheckedLockingSingleton _instance = null;

        private DoubleCheckedLockingSingleton()
        {
        }

        //用來LOCK建立instance的程序。
        public static DoubleCheckedLockingSingleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (padlock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckedLockingSingleton();
                        }
                    }
                }

                return _instance;
            }
        }
    }
}