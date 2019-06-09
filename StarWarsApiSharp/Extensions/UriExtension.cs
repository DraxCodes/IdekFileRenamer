using System;
using System.Net;
using Newtonsoft.Json;

namespace StarWarsApiSharp.Extensions
{
    public static class UriExtension
    {
        public static T ToJson<T>(this Uri websiteUri)
        {
            return Deserialize<T>(websiteUri);
        }

        private static T Deserialize<T>(Uri uri)
        {
            using (var client = new WebClient())
            {
                try
                {
                    var downloadedString = client.DownloadString(uri.AbsoluteUri);
                    return JsonConvert.DeserializeObject<T>(downloadedString);
                }
                catch (WebException)
                {
                    throw new WebException(nameof(uri));
                }
            }
        }
    }
}
