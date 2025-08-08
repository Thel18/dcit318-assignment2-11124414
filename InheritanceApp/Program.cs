﻿using System;

namespace InheritanceApp
{
    class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic sound");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Bark");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal generic = new Animal();
            Animal dog = new Dog();
            Animal cat = new Cat();

            generic.MakeSound(); 
            dog.MakeSound();      
            cat.MakeSound();      
        }
    }
}

