using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class Helper
    {
        public static bool CheckBlogTitle(this string title)
        {
            if (title.Length > 5)
            {
                return true;
            }
            return false;
        }

        public static bool CheckBlogDescription(this string description)
        {
            if(description.Length > 8)
            {
                return true;
            }
            return false;
        }
    }
}