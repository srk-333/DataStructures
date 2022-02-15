using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures.UnorderedList;
using DataStructures.OrderedList;

namespace DataStructures
{
    public class Program
    {
        /// <summary>
        /// invoke the all classes
        /// </summary>
        public static void InvokeClass()
        {
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Enter your choice");
                Console.WriteLine("1: Unordered List");
                Console.WriteLine("2: Ordered List");
                Console.WriteLine("0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LinkedList<string> linkedList = new LinkedList<string>();
                        string filePath = @"E:\RfaBatch\DataStructures\DataStructures\UnorderedList\UnorderedData.txt";
                        string text = File.ReadAllText(filePath);
                        string[] textArray = text.Split();
                        for (int i = 0; i < textArray.Length; i++)
                        {
                            linkedList.AddLast(textArray[i]);
                        }
                        Console.WriteLine("Enter the word to be searched");
                        string word = Console.ReadLine();
                        int key = linkedList.Search(word);
                        if (key == 1)
                            linkedList.RemoveElement(word);
                        else
                            linkedList.AddLast(word);
                        Console.WriteLine("List of words in the file");
                        string modifiedText = linkedList.Display();
                        File.WriteAllText(filePath, modifiedText);
                        Console.WriteLine("List of words after modification");
                        Console.WriteLine(modifiedText);
                        break;
                    case 2:                  
                        OrderedList<string> ordered = new OrderedList<string>();
                        string filePath1 = @"E:\RfaBatch\DataStructures\DataStructures\OrderedList\OrderedData.txt";
                        string text1 = File.ReadAllText(filePath1);
                        string[] textArray1 = text1.Split();
                        for (int i = 0; i < textArray1.Length; i++)
                        {
                            ordered.Add(textArray1[i]);
                        }
                        Console.WriteLine("Enter the number to be searched");
                        string num = Console.ReadLine();
                        bool rs = ordered.Search(num);
                        if (rs == true)
                            ordered.Pop(num);
                        else
                            ordered.Add(num);
                        string newList = ordered.Display();
                        File.WriteAllText(filePath1, newList);
                        Console.WriteLine("List of numbers after modification");
                        Console.WriteLine(newList);
                        break;                    
                    case 0:
                        CONTINUE = false;
                        break;
                    default:
                        break;
                }
            }
        }
        //Main Method
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to DataStructures Program");
            InvokeClass();
            Console.ReadKey();
        }
    }
}