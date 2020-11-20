using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;
using WebApi.Model.req;
using WebApi.Model.res;

namespace WebApi.Dal
{
    //访问用户信息的增删改实现类
    public class UserDal
    {
        private FoundContext dbcontext = new FoundContext();
        //注册
        public Res register(t_user data) {
            Res res = new Res();
            //新增一行数据
            dbcontext.Add(data);
            //保存到数据库
            int row = dbcontext.SaveChanges();

            if (row > 0)
            {
                res.code = 1;
                res.msg = "注册成功";
            }
            else {
                res.code = -1;
                res.msg = "注册失败";
            }
            return res;
        }
        //根据用户名查询用户信息
        public t_user getUser(string name)
        {
            //数据库查询姓名=输入值的用户信息
            t_user user = dbcontext.t_user.FirstOrDefault(t => t.name.Equals(name));
            return user;
        }
        //修改用户
        public Res modUser(t_user data) {
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
        //删除用户
        public Res delUser(t_user data)
        {
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
        //获取所有用户信息
        public List<t_user> get() {
            //数据库查询整个用户表信息
            List<t_user> users =  dbcontext.t_user.ToList();
            return users;
        }
    }
}
