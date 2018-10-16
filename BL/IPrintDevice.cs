using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IPrintDevice
    {
        int QueueToPrint { get; }
        void AddToPrint(int count);
        void CancelToPrint(int count);
    }
}
