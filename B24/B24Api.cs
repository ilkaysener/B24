using RestSharp;
using System;
using System.Globalization;

namespace B24
{
    public class API
    {
        public string API_URL { get; private set; }

        /// <summary>
        /// Create B24 API Object With Webhooks
        /// </summary>
        /// <param name="WebhookURL">https://mybitrix24.bitrix.com/rest</param>
        /// <param name="UserId">181</param>
        /// <param name="WebhookKey">qwerplffgxthx0qf</param>
        public API(string WebhookURL, int UserId, string WebhookKey)
        {
            API_URL = WebhookURL + "/" + UserId.ToString() + "/" + WebhookKey;
        }
    }
}
