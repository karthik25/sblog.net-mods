using System;
using System.ComponentModel.DataAnnotations;

namespace sBlog.Net.Mod.Emailer
{
    public class Post
    {
        [Key]
        public int PotID { get; set; }
        public string PostUrl { get; set; }
        public short EntryType { get; set; }
        public DateTime PostAddedDate { get; set; }
    }
}