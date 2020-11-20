using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApi.Bll;
using WebApi.Model.req;
using WebApi.Model.res;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoodsController : ControllerBase
    {
        private LostGoodsBll lostGoodsBll = new LostGoodsBll();

        //发布招领信息 POST api/Goods/Release
        [HttpPost("Release")]
        public ResData<Release> Release([FromBody] Goods data)
        {
            return lostGoodsBll.releaseGoods(data);
        }

        //删除招领信息 POST api/Goods/Del
        [HttpPost("Del")]
        public Res Del([FromBody]Id data)
        {
            return lostGoodsBll.delGoods(data.id);
        }

        //修改招领信息 POST api/Goods/Mod
        [HttpPost("Mod")]
        public Res Mod([FromBody] GoodsId data)
        {
            return lostGoodsBll.modGoods(data);
        }
        //获取招领信息 Get api/Goods/Get
        [HttpGet("Get")]
        public ResData<List<GoodsId>> Get(string goods,string describe,string bdate,string edate) {
           
            return lostGoodsBll.get(goods,describe,bdate,edate);
        }
    }
}
