using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model.res;
using WebApi.Model.req;
using WebApi.Model;

namespace WebApi.Dal
{
    //访问信息发布的增删改实现类
    public class LostGoodsDal
    {
        private FoundContext dbcontext = new FoundContext();
        //发布招领信息
        public ResData<Release> releaseGoods(t_lostgoods data) {
            ResData<Release> res = new ResData<Release>();
            try
            {
                //增加一行记录
                dbcontext.Add(data);
                //保存到数据库
                int row = dbcontext.SaveChanges();

                if (row > 0)
                {
                    res.code = 1;
                    res.msg = "发布成功";
                    Release release = new Release();
                    release.id = data.id;
                    res.data = release;
                }
                else
                {
                    res.code = -1;
                    res.msg = "发布失败";
                }
            }
            catch (Exception ex) {
                res.code = -1;
                res.msg = "发布失败："+ ex.Message;
            }
            return res;
        }
        //获取某一条招领信息
        public t_lostgoods getGoods(long id) {
            //数据库查询id=输入值的招领信息
            t_lostgoods lostgoods = dbcontext.t_lostgoods.FirstOrDefault(t => t.id==(id));
            return lostgoods;
        }
        //删除招领信息
        public Res delGoods(t_lostgoods data) {
            Res res = new Res();
            //设置删除记录
            dbcontext.Remove(data);
            //保存到数据库
            int row = dbcontext.SaveChanges();
            if (row > 0)
            {
                res.code = 1;
                res.msg = "删除成功";
            }
            else
            {
                res.code = -1;
                res.msg = "删除失败";
            }
            return res;
        }
        //修改招领信息
        public Res modGoods(t_lostgoods data) {
            Res res = new Res();
            //设置修改记录
            dbcontext.Update(data);
            //保存到数据库
            int row = dbcontext.SaveChanges();
            if (row > 0)
            {
                res.code = 1;
                res.msg = "修改成功";
            }
            else
            {
                res.code = -1;
                res.msg = "修改失败";
            }
            return res;
        }

        //根据查询条件展示招领信息
        public ResData<List<GoodsId>> get(GoodsCon data) {
            ResData<List<GoodsId>> res = new ResData<List<GoodsId>>();
            List<GoodsId> goods = dbcontext.t_lostgoods
                //查询条件
                .Where(t => (t.goods.Contains(data.goods) || data.goods==null) && (t.describe.Contains(data.describe) || data.describe==null) && t.collect_date>=data.bdate && t.collect_date<=data.edate)
                //查询结果  t_lostgoods==>GoodsId
                .Select(t => new GoodsId(t.id,t.goods,t.describe,t.collect_date,t.collect_addr,t.contact_man,t.contact_phone,t.contact_email))
                //转换结果
                .ToList();
            res.code = 1;
            res.msg = "查询成功";
            res.data = goods;
            return res;
        }
    }
}
