using System.ComponentModel.DataAnnotations;

namespace sBlog.Net.Mod.Counter
{
    public class Post
    {
        [Key]
        public int PotID { get; set; }
        public string PostUrl { get; set; }
        public short EntryType { get; set; }
    }
}