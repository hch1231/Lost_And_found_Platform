using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model.req
{
    //失物招领查询条件
    public class GoodsCon
    {
        //物品
        public string goods { get; set; }
        //描述
        public string describe { get; set; }
        //拾获的开始日期
        public DateTime bdate { get; set; }
        //拾获的结束日期
        public DateTime edate { get; set; }
    }
}
