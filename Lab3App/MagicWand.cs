using System;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(string description) : base(description)
        {
        }

        public override void DoAction()
        {
            Console.WriteLine("MagicWand is Used");
        }

        public override void Display()
        {
            Console.WriteLine($"MagicWand {Description} is displayed");
        }
    }
}