using System;
using System.ComponentModel.DataAnnotations;

namespace sBlog.Net.Mod.Counter
{
    public class Request
    {
        [Key]
        public int Id { get; set; }
        public string FullUrl { get; set; }
        public string RelativeUrl { get; set; }
        public DateTime ReceivedDate { get; set; }
    }
}