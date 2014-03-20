using System.Data.Entity;
using System.Linq;

namespace sBlog.Net.Mod.Emailer
{
    public class BlogEmailerDataContext : DbContext
    {
        private IDbSet<Post> _posts; 

        public BlogEmailerDataContext()
            : base("server=localhost;Database=sblog;user id=msuser1;password=msuser1;")
        {
            
        }

        public string GetUrlForPost(string authority, string url)
        {
            var post = _posts.ToList().SingleOrDefault(p => p.PostUrl == url && p.EntryType == 1);
            if (post != null)
            {
                return string.Format(@"http://{0}/{1}/{2}/{3}", authority, 
                                                                post.PostAddedDate.Year, 
                                                                post.PostAddedDate.Month.ToString("00"), 
                                                                post.PostUrl);
            }
            return null;
        }

        public string GetUrlForPage(string authority, string url)
        {
            var page = _posts.ToList().SingleOrDefault(p => p.PostUrl == url && p.EntryType == 2);
            return page != null ? string.Format("http://{0}/page/{1}", authority, url) : null;
        }
    }
}