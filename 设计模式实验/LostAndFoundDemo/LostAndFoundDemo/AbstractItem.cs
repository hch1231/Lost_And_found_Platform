using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    abstract class AbstractItem
    {
        public abstract void Add(AbstractItem file);
        public abstract void Remove(AbstractItem file);
        public abstract AbstractItem GetChild(int i);
        public abstract void DisPlay();
    }
}

