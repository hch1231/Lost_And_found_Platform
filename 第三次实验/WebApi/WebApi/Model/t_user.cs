using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    //用户表
    public class t_user
    {
        [Key]
        public string name { get; set; }
        public string nikename { get; set; }
        
        public string pwd { get; set; }
        
    }
}
