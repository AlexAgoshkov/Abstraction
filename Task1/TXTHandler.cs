using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class TXTHandler : AbstractHandler
    {
        public TXTHandler()
        {
            Name = "txt";
        }

        public override void Change()
        {
            Console.WriteLine("TXT Document was changed");
        }

        public override void Create()
        {
            Console.WriteLine("TXT Document was created");
        }

        public override void Open()
        {
            Console.WriteLine("TXT Document was opened");
        }

        public override void Save()
        {
            Console.WriteLine("TXT Document was saved");
        }
    }
}
