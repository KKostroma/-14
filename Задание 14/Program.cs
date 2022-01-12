using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat();
            Animal dog = new Dog();
            cat.ShowInfo();
            dog.ShowInfo(); 
            Console.ReadKey();
        }
        abstract class Animal
        {
            public abstract string Name { get; set; }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine($"Название животного: {Name}");
                Say();
            }
        }
        class Cat : Animal
        {
            string name = "Кот";
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Мяу!");
            }
        }
        class Dog : Animal
        {
            string name = "Собака";
            public override string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }
            }
            public override void Say()
            {
                Console.WriteLine("Гав!");
            }
        }
    }
}
