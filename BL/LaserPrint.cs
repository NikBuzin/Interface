using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class LaserPrint : Printer
    {
        public bool IsQueue { get; set; }
        public LaserPrint(string name, int power, int count)
        {
            Name = name;
            Power = power;
            _count = count;
        }
        public override void AddToPrint(int count)
        {
            _count += count;
        }
        public override void CancelToPrint(int count)
        {
            if (count <= _count)
            {
                IsQueue = true;
                _count -= count;
            }
            else IsQueue = false;
        }
        public override void SetName(string name)
        {
            Name = name;
        }
        public override void SetPower(int power)
        {
            Power = power;
        }
        public string Result(List<LaserPrint> Printers)
        {
            string result = "";
            for(int i = 0; i < Printers.Count; i++)
            {
                result += Printers[i].Name + ' ' + Printers[i].Power + ' ' + Printers[i].QueueToPrint + Environment.NewLine;
            }
            return result;
        }
    }
}
