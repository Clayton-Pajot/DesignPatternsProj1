using Assi1.Abstracts;
using Assi1.Concretes;
using System;

namespace Assi1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Uncomment sections here as you implement them

            // Create our HeavyObjects (DO NOT MODIFY THESE VALUES)
            HeavyObject lightest = new HeavyObject(10, 10, 1, 1);
            HeavyObject medium = new HeavyObject(7, 7, 2, 5);
            HeavyObject heavyAndSmall = new HeavyObject(5, 5, 5, 50);


            //DEBUG
            Console.Write("Lightest: ");
            lightest.Print();
            Console.WriteLine();

            //Dictionary
            ObjectDictionary<int, HeavyObject> dictionary1 = new ObjectDictionary<int, HeavyObject>();
            ObjectDictionary<int, HeavyObject> dictionary2 = new ObjectDictionary<int, HeavyObject>();
            ObjectDictionary<int, HeavyObject> dictionary3 = new ObjectDictionary<int, HeavyObject>();

            // Create lists of the HeavyObjects and print them for debug purposes
            HeavyObjectList<HeavyObject> listA = new HeavyObjectList<HeavyObject>();
            dictionary1.Add(0,heavyAndSmall);
            dictionary1.Add(1,medium);
            dictionary1.Add(2,lightest);
            Console.WriteLine("ListA:");

            for (IIterator<HeavyObject> i = dictionary1.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                i.CurrentItem().Print();
            }

            Console.WriteLine();



            HeavyObjectList<HeavyObject> listB = new HeavyObjectList<HeavyObject>();
            dictionary2.Add(0, medium);
            dictionary2.Add(1,lightest);
            dictionary2.Add(2,heavyAndSmall);
            Console.WriteLine("ListB:");

            for (IIterator<HeavyObject> i = dictionary2.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                i.CurrentItem().Print();
            }

            Console.WriteLine();


            HeavyObjectList<HeavyObject> listC = new HeavyObjectList<HeavyObject>();
            dictionary3.Add(0, lightest);
            dictionary3.Add(1,medium);
            dictionary3.Add(2,heavyAndSmall);
            Console.WriteLine("ListC:");

            for (IIterator<HeavyObject> i = dictionary3.CreateIterator(); !i.IsCompleted(); i.Next())
            {
                i.CurrentItem().Print();
            }

            Console.WriteLine();


            //Create our Flyweight Factory and create the Flyweights out of it
            FlyweightFactory fw = new FlyweightFactory();
            IStrategy bottomWeight = fw.GetFlyweight("bottomWeight");
            IStrategy pyramid = fw.GetFlyweight("pyramid");
            IStrategy topple = fw.GetFlyweight("topple");



            // Print results
            Console.WriteLine("BottomWeight - ListA: " + bottomWeight.EvaluateStack(dictionary1));
            Console.WriteLine("BottomWeight - ListB: " + bottomWeight.EvaluateStack(dictionary2));
            Console.WriteLine("BottomWeight - ListC: " + bottomWeight.EvaluateStack(dictionary3));
            Console.WriteLine();

            Console.WriteLine("Pyramid - ListA: " + pyramid.EvaluateStack(dictionary1));
            Console.WriteLine("Pyramid - ListB: " + pyramid.EvaluateStack(dictionary2));
            Console.WriteLine("Pyramid - ListC: " + pyramid.EvaluateStack(dictionary3));
            Console.WriteLine();

            Console.WriteLine("Topple - ListA: " + topple.EvaluateStack(dictionary1));
            Console.WriteLine("Topple - ListB: " + topple.EvaluateStack(dictionary2));
            Console.WriteLine("Topple - ListC: " + topple.EvaluateStack(dictionary3));
            Console.WriteLine();

            /*          Console.WriteLine("BottomWeight - ListA: " + bottomWeight.EvaluateStack(listA));
                        Console.WriteLine("BottomWeight - ListB: " + bottomWeight.EvaluateStack(listB));
                        Console.WriteLine("BottomWeight - ListC: " + bottomWeight.EvaluateStack(listC));

                        Console.WriteLine("Pyramid - ListA: " + pyramid.EvaluateStack(listA));
                        Console.WriteLine("Pyramid - ListB: " + pyramid.EvaluateStack(listB));
                        Console.WriteLine("Pyramid - ListC: " + pyramid.EvaluateStack(listC));

                        Console.WriteLine("Topple - ListA: " + topple.EvaluateStack(listA));
                        Console.WriteLine("Topple - ListB: " + topple.EvaluateStack(listB));
                        Console.WriteLine("Topple - ListC: " + topple.EvaluateStack(listC));*/

        }
    }
}
