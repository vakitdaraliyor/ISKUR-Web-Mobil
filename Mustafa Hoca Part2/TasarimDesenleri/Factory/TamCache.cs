using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class TamCache
    {
        Dictionary<string, object> liste = new Dictionary<string, object>();
        public object GetCache(string key)
        {
            KeyValuePair<string, object> cacheItem = liste.Where(c => c.Key == key).SingleOrDefault();
            return cacheItem.Value;
        }

        public void PutCache(string key, object value)
        {
            liste.Add(key, value);
        }

        public void RemoveCache(string key)
        {
            liste.Remove(key);
        }

        public Dictionary<string, object> GetAllCachedItem()
        {
            return liste;
        }

        public void RemoveAllCachedItem()
        {
            liste.Clear();
        }

    }
}
