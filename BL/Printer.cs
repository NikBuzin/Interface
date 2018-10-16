using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public abstract class Printer : IPrintDevice
    {
        protected int _count;
        public int QueueToPrint { get { return _count; } }
        public string Name { get; set; }
        public int Power { get; set; }
        public abstract void AddToPrint(int count);
        public abstract void CancelToPrint(int count);
        public abstract void SetName(string name);
        public abstract void SetPower(int power);
    }
}
