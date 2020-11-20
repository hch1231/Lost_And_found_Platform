using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model.req
{
    //用户对象
    public class User
    {
        //账号
        public string name { get; set; }
        //昵称
        public string nikename { get; set; }
        //密码
        public string pwd { get; set; }
    }
}
