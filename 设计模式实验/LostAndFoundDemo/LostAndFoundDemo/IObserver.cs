using System;
using System.Collections.Generic;
using System.Text;

namespace LostAndFoundDemo
{
    abstract class IObserver
    {
        public abstract void Receive();
    }
}
