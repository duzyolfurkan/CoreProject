using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrate
{
    public class Blog
    {
        public int BlogID { get; set; }
        public string BlogTittle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbNailImage { get; set; }
        public string BlogImage { get; set; }
        public string BlogCreateDate { get; set; }
        public bool BlogStatus { get; set; }
    }
}
