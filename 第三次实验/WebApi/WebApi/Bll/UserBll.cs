using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Dal;
using WebApi.Model;
using WebApi.Model.req;
using WebApi.Model.res;

namespace WebApi.Bll
{
    public class UserBll
    {
        private UserDal userDal = new UserDal();
        //注册
        public Res register(User data)
        {
            Res res = new Res();
            //判断请求的数据是否合法
            if (string.IsNullOrEmpty(data.name) || string.IsNullOrEmpty(data.pwd))
            {
                res.code = -1;
                res.msg = "账号密码不能为空";
            }
            else
            {
                //检查账号是否在用户表里面，在的话就是被注册了
                t_user check = userDal.getUser(data.name);
                if (check != null)
                {
                    res.code = -1;
                    res.msg = "账号已经被注册了，请使用其他账号";
                }
                else
                {
                    //从接口请求过来的数据赋值给数据库的表对象
                    t_user user = new t_user();
                    user.name = data.name;
                    user.nikename = data.nikename;
                    //用md5加密密码
                    user.pwd = Md5Help.UserMd5(data.pwd);
                    res = userDal.register(user);
                }
            }
            return res;
        }
        //修改昵称
        public Res modNikeName(User data) {
            Res res = new Res();
            //判断请求的数据是否合法
            if (string.IsNullOrEmpty(data.name))
            {
                res.code = -1;
                res.msg = "账号不能为空";
            }
            else {
                //检查账号是否在用户表里面，在的话就是被注册了
                t_user user = userDal.getUser(data.name);
                if (user == null)
                {
                    res.code = -1;
                    res.msg = "无此账号";
                }
                else {
                    //修改到数据库
                    user.nikename = data.nikename;
                    res = userDal.modUser(user);
                }

            }
            return res;
        }
        //修改密码
        public Res modPwd(UserPwd data)
        {
            Res res = new Res();
            //判断请求的数据是否合法
            if (string.IsNullOrEmpty(data.name) || string.IsNullOrEmpty(data.oldpwd) || string.IsNullOrEmpty(data.newpwd))
            {
                res.code = -1;
                res.msg = "账号、旧密码、新密码不能为空";
            }
            else
            {
                //检查账号是否在用户表里面，在的话就是被注册了
                t_user user = userDal.getUser(data.name);
                if (user == null)
                {
                    res.code = -1;
                    res.msg = "无此账号";
                }
                else
                {
                    //比对密码是否正确
                    if (user.pwd.Equals(Md5Help.UserMd5(data.oldpwd)))
                    {
                        //输入的旧密码跟数据库密码一致，修改到数据库
                        user.pwd = Md5Help.UserMd5(data.newpwd);
                        res = userDal.modUser(user);
                    }
                    else {
                        //输入的旧密码跟数据库密码不一致，提示
                        res.code = -1;
                        res.msg = "输入的旧密码不正确";
                    }

                }

            }
            return res;
        }
        //登录
        public Res login(User data) {
            Res res = new Res();
            //判断请求的数据是否合法
            if (string.IsNullOrEmpty(data.name) || string.IsNullOrEmpty(data.pwd))
            {
                res.code = -1;
                res.msg = "账号密码不能为空";
            }
            else {
                //检查账号是否在用户表里面，在的话就是被注册了
                t_user user = userDal.getUser(data.name);
                if (user == null)
                {
                    res.code = -1;
                    res.msg = "无此账号";
                }
                else {
                    //比对密码是否正确
                    if (user.pwd.Equals(Md5Help.UserMd5(data.pwd)))
                    {
                        //输入的旧密码跟数据库密码一致
                        res.code = 1;
                        res.msg = "登录成功";
                    }
                    else {
                        res.code = -1;
                        res.msg = "登录失败，账户密码有误";
                    }
                }
            }
            return res;
        }
    }
}
