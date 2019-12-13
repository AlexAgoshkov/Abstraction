using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler()
        {
            Name = "xml";
        }

        public override void Change()
        {
            Console.WriteLine("XML Document was changed");
        }

        public override void Create()
        {
            Console.WriteLine("XML Document was created");
        }

        public override void Open()
        {
            Console.WriteLine("XML Document was opened");
        }

        public override void Save()
        {
            Console.WriteLine("XML Document was saved");
        }
    }
}
