using System;

namespace print.Config
{
    public interface IConfig<T>
    {
        String Create(T data);
        String Get();
        T Initial();
        T GetConfig();
    }
}