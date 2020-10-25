using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    class Category : AbstractItem
    {
		private List<AbstractItem> itemList = new List<AbstractItem>();
		private string name;
		public Category()
		{
		}
		public Category(string name)
		{
			this.name = name;
		}

		public override void Add(AbstractItem item)
		{
			itemList.Add(item);
		}

		public override void Remove(AbstractItem item)
		{
			itemList.Remove(item);
		}
		public void Rename(string name)
		{
			this.name = name;
		}
		public override AbstractItem GetChild(int i)
		{
			return itemList[i];
		}



		public override void DisPlay()
		{
			Console.WriteLine("  -------{0}类失物招领信息：-------", name);
			Console.WriteLine("----------------------------------------");
			foreach (Object obj in itemList)
			{
				((AbstractItem)obj).DisPlay();
			}
			Console.WriteLine("----------------------------------------");
		}
	}
}
