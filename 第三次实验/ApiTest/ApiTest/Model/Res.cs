using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApiTest.Model
{
    //统一的返回信息
    public class Res
    {
        //1  表示请求成功   -1表示请求失败
        public int code { get; set; }

        //请求成功失败的信息
        public string msg { get; set; }



    }
}
