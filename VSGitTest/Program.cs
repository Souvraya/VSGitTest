using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSGitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Program crier = new Program();
            crier.Say("Hello, World");
            Console.ReadLine();
        }
        void Say(string message)
        {
            Console.WriteLine(message);
        }
    }
}
