using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Web;

namespace EntityFrameworkCodeFirrst.Models
{
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string PostDate { get; set; }


        public int BlodId { get; set; }
        public virtual Blog Blog { get; set; }

    }
}