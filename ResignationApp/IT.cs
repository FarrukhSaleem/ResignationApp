using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResignationApp
{
    internal class IT
    {
        private readonly Resignation resignation;

        public IT(Resignation resignation) {
            this.resignation = resignation;
            this.resignation.ResignationEvent += ResignationFormalities;
        }
        public void ResignationFormalities() {
            Console.WriteLine("IT is performing some formalities for resignation");
        }
    }
}
