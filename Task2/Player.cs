using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Player : IPlayable, IRecodable
    {
        public void Record()
        {
            Console.WriteLine("Record was started");
        }

        void IRecodable.Pause()
        {
            Console.WriteLine("Record Pause");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Record was stopped");
        }

        public void Play()
        {
            Console.WriteLine("Song is playing");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Song pause");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Playing was stopped");
        }

    }
}
