
using System;
using System.Runtime.Caching;

namespace Cats_FTW.Classes
{
    public class InMemoryCache
    {
        public T GetOrSet<T>(string cacheKey, Func<T> getItemCallback) where T : class
        {
            //return getItemCallback(); //short-circuit until cache is fully tested
            T item = MemoryCache.Default.Get(cacheKey) as T;
            if (item == null)
            {
                item = getItemCallback();
                MemoryCache.Default.Add(cacheKey, item, DateTime.Today.AddDays(1));
            }
            return item;
        }
    }
}