using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiTest.Model
{
    //用户修改密码对象
    public class UserPwd
    {
        //账号
        public string name { get; set; }
        //旧密码
        public string oldpwd { get; set; }
        //新密码
        public string newpwd { get; set; }
    }
}
