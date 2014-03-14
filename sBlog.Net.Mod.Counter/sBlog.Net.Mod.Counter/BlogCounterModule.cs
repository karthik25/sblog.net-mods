using System;
using System.Web;

namespace sBlog.Net.Mod.Counter
{
    public class BlogCounterModule : IHttpModule
    {
        private readonly BlogCountsDataContext _blogCountsDataContext;

        public BlogCounterModule()
        {
            _blogCountsDataContext = new BlogCountsDataContext();
        }

        public void Init(HttpApplication context)
        {
            context.BeginRequest += context_BeginRequest;
        }

        void context_BeginRequest(object sender, EventArgs e)
        {
            var context = (HttpApplication) sender;
            var request = new Request
                {
                    RelativeUrl = context.Request.RawUrl,
                    FullUrl = context.Request.Url.AbsoluteUri,
                    ReceivedDate = DateTime.Now
                };
            _blogCountsDataContext.InsertRequest(request);
        }

        public void Dispose()
        {
            _blogCountsDataContext.Dispose();
        }
    }
}