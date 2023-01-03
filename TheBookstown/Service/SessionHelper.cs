using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace TheBookstown.Service
{
    // extensions for the session based shoppgin cart
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, string key, object val)
        {
            session.SetString(key, JsonConvert.SerializeObject(val));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var val = session.GetString(key);
            return val == null ? default(T)! : JsonConvert.DeserializeObject<T>(val)!;
        }

    }
}
