using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BreakfastItemsClassLibrary;

namespace BreakfestSyncClassLibrary
{
    public class MainClass
    {
        public void MainMethod()
        {
            Task.Delay(2000).Wait();

            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            Egg eggs = FryEggs(2);
            Console.WriteLine("eggs are ready");

            Bacon bacon = FryBacon(3);
            Console.WriteLine("bacon is ready");

            Toast toast = ToastBread(2);
            ApplyButter(toast);
            ApplyJam(toast);
            Console.WriteLine("toast is ready");

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        #region Methods

        private static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            Task.Delay(1000).Wait();
            return new Coffee();
        }

        private static Egg FryEggs(int howMany)
        {
            Console.WriteLine("Prepare eggs and pan");
            Task.Delay(1000).Wait();
            Console.WriteLine("Warming the egg pan...");
            Task.Delay(5000).Wait();
            Console.WriteLine($"cracking {howMany} eggs");
            for (int i = 0; i < howMany; i++)
            {
                Task.Delay(500).Wait();
            }
            Console.WriteLine("cooking the eggs ...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Put eggs on plate");
            Task.Delay(1000).Wait();

            return new Egg();
        }

        private static Bacon FryBacon(int slices)
        {
            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            for (int i = 0; i < slices; i++)
            {
                Task.Delay(500).Wait();
            }
            Console.WriteLine("cooking first side of bacon...");
            Task.Delay(5000).Wait();
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
                Task.Delay(500).Wait();
            }
            Console.WriteLine("cooking the second side of bacon...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Put bacon on plate");
            Task.Delay(1000).Wait();

            return new Bacon();
        }

        private static Toast ToastBread(int slices)
        {
            Console.WriteLine("Putting a slice of bread in the toaster");
            for (int slice = 0; slice < slices; slice++)
            {
                Task.Delay(1000).Wait();
            }
            Console.WriteLine("Toasts toasting...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Remove toast from toaster");
            Task.Delay(1000).Wait();

            return new Toast();
        }

        private static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            Task.Delay(1000).Wait();
            return new Juice();
        }

        private static void ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");
            Task.Delay(1000).Wait();
        }
        
        private static void ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
            Task.Delay(1000).Wait();
        }

        #endregion
    }
}
