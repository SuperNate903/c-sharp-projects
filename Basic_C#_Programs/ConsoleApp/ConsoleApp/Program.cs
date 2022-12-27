using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main()
        {
            // Assignment Part 1
            string[] stringArray = new string[] { "Orange", "Pickle", "Plum", "Pomegranate", "Almond" };
            Console.WriteLine("Write some text.");
            string text = Console.ReadLine();
            // Loops through the array defined above
            for(int i = 0; i < stringArray.Length; i++)
            {
                stringArray[i] += text;
                Console.WriteLine(stringArray[i]);
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            // Assignment Part 2
            bool condition = false;
            int counter = 0;
            // This loops until the counter reaches 10 or higher
            while(!condition)
            {
                counter++;
                Console.WriteLine(counter);
                // This bit of code is used to end the loop. Without it, it would loop forever.
                if(counter >= 10)
                {
                    condition = true;
                }
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            // Assignment Part 3
            int index = 0;
            Console.WriteLine("Write something. All of its letters will be written.");
            string word = Console.ReadLine();
            // Loops through the amount of letters in the input word
            while(index < word.Length)
            {
                Console.WriteLine(word[index]);
                index++;
            }
            int size = 21;
            // Keeps looping until a good enough size is input
            while(!(size <= 20))
            {
                Console.WriteLine("Input a size value.");
                size = Convert.ToInt32(Console.ReadLine());
                if(size < 20)
                {
                    Console.WriteLine("The size is small, but it will do.");
                }
                else if(size == 20)
                {
                    Console.WriteLine("The size is just right.");
                }
                else
                {
                    Console.WriteLine("The size is too big. Input something smaller.");
                }
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            // Assignment Part 4
            List<string> stringList = new List<string>();
            stringList.Add("Cats");
            stringList.Add("Dogs");
            stringList.Add("Birds");
            stringList.Add("Sheep");
            stringList.Add("Cows");
            bool match = false;
            // Loops until one of the 5 categories are input
            while(!match)
            {
                Console.WriteLine("Search from Cats, Dogs, Birds, Sheep, or Cows.");
                string input = Console.ReadLine();
                for(int i = 0; i < stringList.Count; i++)
                {
                    if(input == stringList[i])
                    {
                        Console.WriteLine("The result: " + input + " is on index " + i);
                        match = true;
                    }
                }
                if(!match)
                {
                    Console.WriteLine("That is not on the list.");
                }
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            // Assignment Part 5
            List<string> stringList2 = new List<string>();
            stringList2.Add("Table");
            stringList2.Add("Chair");
            stringList2.Add("Light");
            stringList2.Add("Light");
            stringList2.Add("Window");
            bool inList = false;
            // Loops through the list and writes out the string(s) of your input if it exists
            while (!inList)
            {
                Console.WriteLine("Type Table, Chair, Light, or Window.");
                string input = Console.ReadLine();
                for (int i = 0; i < stringList2.Count; i++)
                {
                    if (input == stringList2[i])
                    {
                        Console.WriteLine(stringList2[i] + " is on index " + i);
                        inList = true;
                    }
                }
                if (!inList)
                {
                    Console.WriteLine("That is not on the list.");
                }
            }
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();

            // Assignment Part 6
            bool sameItem = false;
            List<string> itemList = new List<string>();
            List<string> stringList3 = new List<string>();
            stringList3.Add("Wood");
            stringList3.Add("Tile");
            stringList3.Add("Tile");
            stringList3.Add("Fabric");
            stringList3.Add("Metal");
            // These loops find out if any item is new, or a duplicate of another previous item
            foreach(string item in stringList3)
            {
                for (int i = 0; i < itemList.Count; i++)
                {
                    if(item == itemList[i])
                    {
                        sameItem = true;
                    }
                }
                if (sameItem)
                {
                    Console.WriteLine(item + " is a duplicate.");
                }
                else
                {
                    Console.WriteLine(item + " is new.");
                }
                sameItem = false;
                itemList.Add(item);
            }
            Console.Read();
        }
    }
}
