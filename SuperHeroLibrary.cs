using System;

namespace SuperHeroInterfaceDemo
{
    public abstract class SuperHero
    { }

    public abstract class Alien : SuperHero
    { }

    public abstract class Human : SuperHero
    { }

    public class Superman : Alien, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            Console.WriteLine("I defy gravity with my special powers");
        }

        public void LookThroughObjects()
        {
            Console.WriteLine("I have X-Ray Vision");
        }
    }

    public class Batman : Human, IFlyable, ISeeThroughThings
    {
        public void Fly()
        {
            Console.WriteLine("I can fly with my wings");
        }

        public void LookThroughObjects()
        {
            Console.WriteLine("I see through things with my gadgets");
        }
    }
}