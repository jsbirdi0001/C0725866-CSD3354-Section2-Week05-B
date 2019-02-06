using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0725866
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList a = new LinkedList();
        }

    }

    class Dog
    {
        public static int NumberofDogs = 0;
        public Dog()
        {

        }
        String DogName;
        String DogBreed;
         
    }
    class LinkedList
    {
        public Dog Head;
        Dog Peanut = new Dog();
        public void run()
        {
            Head = Peanut;
            Peanut.DogName = "Yoo";
        }
    }

    public void WalkOverTheList()
    {
        Current = Head;
        while (Current != null)
        {
            Console.WriteLine(Current.DogName);
        }
    }
}

