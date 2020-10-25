using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    class ItemFactory
    {
        public static AbstractItem GetItem(string type)
        {
			AbstractItem item = null;
			if (type.Equals("Campus"))
			{
				item = new Campus();
			}
			else if (type.Equals("Category"))
			{
				item = new Category();
			}
			else if (type.Equals("Comment"))
			{
				item = new Comment();
			}
			else if (type.Equals("LostItem"))
			{
				item = new LostAndFoundItem();
			}
			return item;
		}
    }
}
