using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPlayable playable = new Player();
            IRecodable recodable = new Player();

            playable.Play();
            playable.Pause();
            playable.Stop();

            Console.WriteLine();

            recodable.Record();
            recodable.Pause();
            recodable.Stop();


            Console.ReadKey();
        }
    }
}
