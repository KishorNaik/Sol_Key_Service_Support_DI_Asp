namespace Sol_Demo.Core;

public enum CacheDemoEnum
{
    Big,
    Small
}

public interface ICacheDemo
{
    object Get(string key);
}

public class BigCache : ICacheDemo
{
    public object Get(string key) => $"Resolving {key} from big cache.";
}

public class SmallCache : ICacheDemo
{
    public object Get(string key) => $"Resolving {key} from small cache.";
}