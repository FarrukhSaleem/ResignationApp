using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResignationApp
{
    internal class Resignation  //Publisher Class
    {
        public delegate void ResignationEventHandler();
        public event ResignationEventHandler ResignationEvent;
        public void DoResignation()
        {
            Console.WriteLine("Process of resignation done");
            if (ResignationEvent != null)
                ResignationEvent();
        }
    }
}
