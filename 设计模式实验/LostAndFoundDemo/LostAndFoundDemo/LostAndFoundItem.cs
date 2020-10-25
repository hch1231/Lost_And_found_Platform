using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    class LostAndFoundItem : AbstractItem
    {
        private string name;
        private string description;
		private List<AbstractItem> commentList = new List<AbstractItem>();
		private List<IObserver> observers = new List<IObserver>();
		// 对同一个订阅号，新增和删除订阅者的操作
		
		public LostAndFoundItem()
		{
		}
		public LostAndFoundItem(string name)
		{
			this.name = name;
		}
		public void Rename(string name)
		{
			this.name = name;
		}
		public void EditDescription(string description)
		{
			this.description = description;
		}

		public override void Add(AbstractItem item)
		{
			commentList.Add(item);
		}

		public override void Remove(AbstractItem item)
		{
			commentList.Remove(item);
		}

		public override AbstractItem GetChild(int i)
		{
			return (AbstractItem)commentList[i];
		}

		public override void DisPlay()
        {
			Console.WriteLine(name);
			Console.WriteLine(description);
			Console.WriteLine("##评论区##");
            foreach (Object obj in commentList)
            {
                ((AbstractItem)obj).DisPlay();
            }
			Console.WriteLine("##########");
        }
		public void AddObserver(IObserver ob)
		{
			observers.Add(ob);
		}
		public void RemoveObserver(IObserver ob)
		{
			observers.Remove(ob);
		}

		public void Update()
		{
			// 遍历订阅者列表进行通知
			foreach (IObserver ob in observers)
			{
				if (ob != null)
				{
					ob.Receive();
				}
			}
		}

	}
}
