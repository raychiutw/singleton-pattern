using System;

namespace SingletonPattern.Application
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Foo instance;

            // 非執行緒安全 Singleton

            instance = NotThreadSafeSingleton.Instance;
            Console.WriteLine($"此 Singleton 模式為 : {instance.GetType().ToString()}");

            // 簡單執行緒安全 Singleton
            instance = SimpleThreadSafetySingleton.Instance;
            Console.WriteLine($"此 Singleton 模式為 : {instance.GetType().ToString()}");

            // 使用 Double-checked Locking 確保執行緒安全
            instance = DoubleCheckedLockingSingleton.Instance;
            Console.WriteLine($"此 Singleton 模式為 : {instance.GetType().ToString()}");

            // 不使用 Lock, 確保執行緒安全 (非 Lazy)
            instance = EagerSingleton.Instance;
            Console.WriteLine($"此 Singleton 模式為 : {instance.GetType().ToString()}");

            // 完整 Lazy 實例
            instance = LazySingleton.Instance;
            Console.WriteLine($"此 Singleton 模式為 : {instance.GetType().ToString()}");

            // 使用 .NET 4 的 Lazy\<T>
            instance = DotNet4LazySingleton.Instance;
            Console.WriteLine($"此 Singleton 模式為 : {instance.GetType().ToString()}");
        }
    }
}