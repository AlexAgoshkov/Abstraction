using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class View
    {
        public View()
        {
            _abstractHandler = new AbstractHandler[] 
            {new DOCHandler(), 
             new TXTHandler(), 
             new XMLHandler()};
        }

        

        public void DocumentWork(string document)
        {
            string format = document.Substring(document.Length - 3);

            foreach (var item in _abstractHandler)
            {
                if (item.Name == format)
                {
                    item.Create();
                    item.Open();
                    item.Change();
                    item.Save();
                }
            }
        }


        private AbstractHandler[] _abstractHandler;
    }
}
