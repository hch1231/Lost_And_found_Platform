using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    class Comment : AbstractItem
    {
        private string userName;
        private string content;
        public void SetName(string userName)
        {
            this.userName = userName;
        }
        public void setContent(string content)
        {
            this.content = content;
        }
        public override void Add(AbstractItem item)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override void Remove(AbstractItem item)
        {
            Console.WriteLine("对不起，不支持该方法！");
        }

        public override AbstractItem GetChild(int i)
        {
            Console.WriteLine("对不起，不支持该方法！");
            return null;
        }
        public override void DisPlay()
        {
            Console.WriteLine("----用户名：{0}", userName);
            Console.WriteLine(content);
        }
    }
}
