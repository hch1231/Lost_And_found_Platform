using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model.res
{
    //统一的返回信息（含返回的各种数据）
    public class ResData<T> : Res
        where T : new()
        
    {
        //返回的数据信息
        public T data { get; set; }

    }
}
