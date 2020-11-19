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
    public class UserController : ControllerBase
    {
        private UserBll userBll = new UserBll();
        
        //登录接口 POST api/User/Login
        [HttpPost("Login")]
        public Res Login([FromBody] User data)
        {
            return userBll.login(data);
        }

        //注册接口 POST api/User/Register
        [HttpPost("Register")]
        public Res Register([FromBody] User data)
        {
            return userBll.register(data);
        }
        //修改密码
        [HttpPost("ModPwd")]
        public Res ModPwd([FromBody]UserPwd data) {
            return userBll.modPwd(data);
        }
    }
}
