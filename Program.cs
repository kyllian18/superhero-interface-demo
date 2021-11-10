using System;

namespace SuperHeroInterfaceDemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Superman superman = new Superman();

            superman.Fly();
            superman.LookThroughObjects();

            Batman batman = new Batman();

            batman.Fly();
            batman.LookThroughObjects();
        }
    }
}