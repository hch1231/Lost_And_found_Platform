using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dal;
using WebApi.Model;
using WebApi.Model.req;
using WebApi.Model.res;

namespace WebApi.Bll
{
    public class LostGoodsBll
    {
        private LostGoodsDal lostGoodsDal = new LostGoodsDal();
        //发布招领信息
        public ResData<Release> releaseGoods(Goods data)
        {
            ResData<Release> res = new ResData<Release>();
            //判断请求的数据是否合法
            if (string.IsNullOrEmpty(data.goods)
                || string.IsNullOrEmpty(data.describe)
                || string.IsNullOrEmpty(data.contact_man))
            {
                res.code = -1;
                res.msg = "物品名称、物品描述、联系人不能为空";
            }
            else if (string.IsNullOrEmpty(data.contact_phone) && string.IsNullOrEmpty(data.contact_email))
            {
                res.code = -1;
                res.msg = "必须输入一种联系方式（手机号码/EMAIL）";
            }
            else
            {

                //从接口请求过来的数据赋值给数据库的表对象
                t_lostgoods lostgoods = new t_lostgoods();
                lostgoods.id = long.Parse(DateTime.Now.ToString("yyyyMMddhhmmss"));
                lostgoods.goods = data.goods;
                lostgoods.describe = data.describe;
                lostgoods.collect_date = data.collect_date;
                lostgoods.collect_addr = data.collect_addr;
                lostgoods.contact_man = data.contact_man;
                lostgoods.contact_phone = data.contact_phone;
                lostgoods.contact_email = data.contact_email;
                res = lostGoodsDal.releaseGoods(lostgoods);
            }
            return res;
        }
        //修改招领信息
        public Res modGoods(GoodsId data)
        {
            Res res = new Res();
            //判断请求的数据是否合法
            if (data.id <= 0)
            {
                res.code = -1;
                res.msg = "ID不能为空";
            }
            else if (string.IsNullOrEmpty(data.goods)
                || string.IsNullOrEmpty(data.describe)
                || string.IsNullOrEmpty(data.contact_man))
            {
                res.code = -1;
                res.msg = "物品名称、物品描述、联系人不能为空";
            }
            else if (string.IsNullOrEmpty(data.contact_phone) && string.IsNullOrEmpty(data.contact_email))
            {
                res.code = -1;
                res.msg = "必须输入一种联系方式（手机号码/EMAIL）";
            }
            else
            {
                t_lostgoods lostgoods = lostGoodsDal.getGoods(data.id);
                if (lostgoods == null)
                {
                    res.code = -1;
                    res.msg = "无此招领信息";
                }
                else
                {
                    //从接口请求过来的数据赋值给数据库的表对象
                    lostgoods.contact_man = data.contact_man;
                    lostgoods.contact_email = data.contact_email;
                    lostgoods.contact_phone = data.contact_phone;
                    lostgoods.describe = data.describe;
                    lostgoods.goods = data.goods;
                    lostgoods.collect_addr = data.collect_addr;
                    lostgoods.collect_date = data.collect_date;
                    //修改到数据
                    res = lostGoodsDal.modGoods(lostgoods);
                }
            }
            return res;
        }
        //删除招领信息
        public Res delGoods(long data)
        {
            Res res = new Res();
            //判断请求的数据是否合法
            if (data <= 0)
            {
                res.code = -1;
                res.msg = "ID不能为空";
            }
            else
            {
                t_lostgoods lostgoods = lostGoodsDal.getGoods(data);
                if (lostgoods == null)
                {
                    res.code = -1;
                    res.msg = "无此招领信息";
                }
                else
                {
                    res = lostGoodsDal.delGoods(lostgoods);
                }
            }
            return res;
        }
        //根据查询条件展示招领信息
        public ResData<List<GoodsId>> get(string goods, string describe, string bdate, string edate)
        {
            ResData<List<GoodsId>> res = new ResData<List<GoodsId>>();
            res.code = 1;
            GoodsCon data = new GoodsCon();
            //赋值查询条件
            if (string.IsNullOrEmpty(goods))
            {
                data.goods = null;
            }
            else {
                data.goods = goods;
            }
            if (string.IsNullOrEmpty(describe))
            {
                data.describe = null;
            }
            else
            {
                data.describe = describe;
            }
            if (string.IsNullOrEmpty(bdate))
            {
                data.bdate = DateTime.MinValue;
            }
            else {
                try
                {
                    data.bdate = DateTime.Parse(bdate);
                }
                catch (Exception e) {
                    res.code = -1;
                    res.msg = "开始日期不是有效的日期格式";
                }
            }
            if (string.IsNullOrEmpty(edate))
            {
                data.edate = DateTime.Now;
            }
            else
            {
                try
                {
                    data.edate = DateTime.Parse(edate);
                }
                catch (Exception e)
                {
                    res.code = -1;
                    res.msg = "结束日期不是有效的日期格式";
                }
            }
            //如果查询条件有误，则返回提示
            if (res.code == -1) {
                return res;
            }
            //显示查询结果
            res =  lostGoodsDal.get(data);
            return res;
        }
    }
}
