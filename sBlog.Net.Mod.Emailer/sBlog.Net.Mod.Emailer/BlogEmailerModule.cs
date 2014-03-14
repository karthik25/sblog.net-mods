using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sBlog.Net.Mod.Emailer
{
    public class BlogEmailerModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            var context = (HttpApplication) sender;
            var url = context.Request.Url.ToString();
            if (url.IndexOf("newlyAdded", StringComparison.Ordinal) > 0)
            {
                FindUrlAndSendAnEmail(url);
            }
        }

        private static void FindUrlAndSendAnEmail(string url)
        {
            var keyValues = url.Substring(url.IndexOf("?", StringComparison.Ordinal) + 1);
            var dictionary = GetDictionary(keyValues);
            var postId = dictionary["postID"];

            // get the url

            // get the email settings

            // send it
        }

        private static Dictionary<string, string> GetDictionary(string keyValues)
        {
            var dictionary = new Dictionary<string, string>();
            keyValues.Split("&".ToCharArray()).ToList().ForEach(k =>
                {
                    var split = k.Split("=".ToCharArray()).ToArray();
                    dictionary.Add(split[0], split[1]);
                });
            return dictionary;
        }

        public void Dispose()
        {
            
        }
    }
}