using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0731712
{
    class Program
    {
        static void Main(string[] args)
        {
            linkedlist a = new linkedlist();
            a.run();
            a.walkoverthelist();
        }
    }

    class dog
    {
        public static int numberofdogs = 0;
        public dog()
        {
            dog.numberofdogs++;
        }
        public string dogname;
        public string dogbreed;
        public dog nextdog;
    }

    class linkedlist
    {
        public dog current;
        public dog head;
        public dog peanut = new dog();
        public dog fifi = new dog();
        public dog jordan = new dog();
        public dog fido = new dog();
        public dog roy = new dog();
        public dog coco = new dog();

        public void run()
        {
            head = peanut;
            peanut.dogname = "peanut";
            peanut.dogbreed = "bichon";
            peanut.nextdog = fifi;

            fifi.dogname = "fifi";
            fifi.dogbreed = "poodle";
            fifi.nextdog = jordan;

            jordan.dogname = "jordan";
            jordan.dogbreed = "german sheppard";
            jordan.nextdog = fido;

            fido.dogname = "fido";
            fido.dogbreed = "beagle";
            fido.nextdog = roy;

            roy.dogname = "Roy";
            roy.dogbreed = "Spaniel";
            roy.nextdog = coco;

            coco.dogname = "Coco";
            coco.dogbreed = "beagle";
            coco.nextdog = null;
        }

        public void walkoverthelist()
        {
            current = head;
            while (current != null)
            {
                Console.WriteLine(current.dogname);
                current = current.nextdog;
            }
        }
    }
}