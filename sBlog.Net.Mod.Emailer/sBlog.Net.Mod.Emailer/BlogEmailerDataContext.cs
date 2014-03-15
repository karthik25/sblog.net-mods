using System;
using System.Data.Entity;

namespace sBlog.Net.Mod.Emailer
{
    public class BlogEmailerDataContext : DbContext
    {
        private IDbSet<Post> _posts; 

        public BlogEmailerDataContext()
            : base("server=localhost;Database=sblog;user id=msuser1;password=msuser1;")
        {
            
        }

        public string GetUrlForPost()
        {
            throw new NotImplementedException();
        }

        public string GetUrlForPage()
        {
            throw new NotImplementedException();
        }
    }
}