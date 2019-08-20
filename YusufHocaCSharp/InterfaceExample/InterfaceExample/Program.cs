using System;

namespace InterfaceExample
{
    class Program
    {

        interface IVoice
        {
            string Voice();
        }

        class Animal
        {

        }

        class Cat : Animal, IVoice
        {
            public string Voice()
            {
                return "Meow";
            }
        }

        class Dog : Animal, IVoice
        {
            public string Voice()
            {
                return "Hav";
            }
        }

        class Shark : Animal
        {
            
        }

        static void Main(string[] args)
        {
            Animal[] animalArr = new Animal[3];
            animalArr[0] = new Cat();
            animalArr[1] = new Dog();
            animalArr[2] = new Shark();

            foreach(Animal a in animalArr)
            {
                IVoice voice = a as IVoice;
                if (voice != null)
                {
                    Console.WriteLine(voice.Voice());
                }
                else
                {
                    Console.WriteLine("No Voice");
                }
            }
        }
    }
}
