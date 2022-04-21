using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResignationApp
{
    internal class Finance
    {
        private readonly Resignation resignation;

        public Finance(Resignation resignation) {
            this.resignation = resignation;
            this.resignation.ResignationEvent += ResignationFormalities;
        }
        public void ResignationFormalities()
        {
            Console.WriteLine("Finance is performing some formalities for resignation");
        }
    }
}
