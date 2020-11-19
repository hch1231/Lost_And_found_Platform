using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiTest.Model
{
    public class GoodsId : Goods
    {
        public long id { get; set; }
        public GoodsId()
        {
        }
        public GoodsId(long id, string goods, string describe, DateTime collect_date, string collect_addr, string contact_man, string contact_phone, string contact_email)
        {
            this.id = id;
            this.goods = goods;
            this.describe = describe;
            this.collect_date = collect_date;
            this.collect_addr = collect_addr;
            this.contact_man = contact_man;
            this.contact_phone = contact_phone;
            this.contact_email = contact_email;
        }
    }
}
