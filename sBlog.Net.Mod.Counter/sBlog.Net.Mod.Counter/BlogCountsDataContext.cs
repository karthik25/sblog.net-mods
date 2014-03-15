using System.Data.Entity;

namespace sBlog.Net.Mod.Counter
{
    public class BlogCountsDataContext : DbContext
    {
        private IDbSet<Post> _posts;
        public IDbSet<Request> Requests { get; set; } 

        public BlogCountsDataContext()
            : base("server=localhost;Database=sblog;user id=msuser1;password=msuser1;")
        {
            
        }

        public void InsertRequest(Request request)
        {
            Requests.Add(request);
            SaveChanges();
        }
    }
}