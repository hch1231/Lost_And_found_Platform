using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Model
{
    //发布信息表
    public class t_lostgoods
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id { get; set; }
        public string goods { get; set; }
        public string describe { get; set; }
        public DateTime collect_date { get; set; }
        public string collect_addr { get; set; }
        public string contact_man { get; set; }
        public string contact_phone { get; set; }
        public string contact_email { get; set; }
        
        
    }
}
