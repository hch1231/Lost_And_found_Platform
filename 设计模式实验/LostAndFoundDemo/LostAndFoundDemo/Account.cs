using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    class Account : IObserver
    {
        private string UserName
        {
            get;
            set;
        }
        public void Rename(string name)
        {
            this.UserName = name;
        }
        override public void Receive()
        {
            Console.WriteLine("用户 {0} 收到了物品状态更新", UserName);
        }
    }
}
