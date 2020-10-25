using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace LostAndFoundDemo
{
    class Campus : AbstractItem
    {
		private List<AbstractItem> categoryList = new List<AbstractItem>();
		private string name;
		public Campus()
		{
		}

		public Campus(string name)
		{
			this.name = name;
		}
		public void Rename(string name)
        {
			this.name = name;
        }
		public override void Add(AbstractItem item)
		{
			categoryList.Add(item);
		}

		public override void Remove(AbstractItem item)
		{
			categoryList.Remove(item);
		}

		public override AbstractItem GetChild(int i)
		{
			return (AbstractItem)categoryList[i];
		}

		public override void DisPlay()
		{
			Console.WriteLine("*******{0}校区失物招领信息：*******", name);
			Console.WriteLine("*******************************************");
			foreach (Object obj in categoryList)
			{
				((AbstractItem)obj).DisPlay();
			}
			Console.WriteLine("*******************************************");
		}
	}
}
