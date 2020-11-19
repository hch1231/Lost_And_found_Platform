using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model.req
{
    //发布信息对象
    public class Goods
    {
        public string goods { get; set; }
        public string describe { get; set; }
        public DateTime collect_date { get; set; }
        public string collect_addr { get; set; }
        public string contact_man { get; set; }
        public string contact_phone { get; set; }
        public string contact_email { get; set; }
    }
}
