﻿using System;
using System.Text.RegularExpressions;

namespace sBlog.Net.Mod.Counter
{
    public static class BlogCounterStaticHelpers
    {
         public static bool IsRequestConsideredForCounts(this string url)
         {
             var postRegex = new Regex(@"(\/\d+\/\d+)(\/[a-zA-Z0-9\-]+)(\/\S+[\-]*\S+)*");

             if (postRegex.IsMatch(url))
                 return true;

             return url.IndexOf("page/", StringComparison.Ordinal) > 0;
         }
    }
}