using System;

namespace SingletonPattern.Application
{
    public sealed class DotNet4LazySingleton : Foo
    {
        private static Lazy<DotNet4LazySingleton> lazy = new Lazy<DotNet4LazySingleton>(() => new DotNet4LazySingleton());

        private DotNet4LazySingleton()
        {
        }

        public static DotNet4LazySingleton Instance { get { return lazy.Value; } }
    }
}