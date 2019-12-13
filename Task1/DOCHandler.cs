using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DOCHandler : AbstractHandler
    {
        public DOCHandler()
        {
            Name = "doc";
        }

        public override void Change()
        {
            Console.WriteLine("DOC Document was changed");
        }

        public override void Create()
        {
            Console.WriteLine("DOC Document was created");
        }

        public override void Open()
        {
            Console.WriteLine("DOC Document was opened");
        }

        public override void Save()
        {
            Console.WriteLine("DOC Document was saved");
        }
    }
}
