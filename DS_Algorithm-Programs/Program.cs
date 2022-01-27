using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DS_Algorithm_Programs
{
    class Program
    {
        static void Main(string[] args)
        {
            string flag = "Y";
            while (flag == "Y" || flag == "y")
            {
                Console.WriteLine("--------------------------------------------------------------------------");
                Console.WriteLine("-----------------Data Sructures Algorithm Programs-------------------------");
                Console.WriteLine("----------------------------------------------------------------------------\n");
                Console.WriteLine("1.Permutation Using Recursion\n2.BinarySearch\n3.InsertionSort\n4.BubbleSort\n5.MergeSort\n6.Anagram\n7.PrimeNumbers");
                Console.WriteLine("8.Prime NUmber Is Anagram Or Palindrome\n9.FindNumber");
                Console.WriteLine("Enter Your Option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 1:
                        Console.WriteLine("Enter String to find Permutation ");
                        string str = Console.ReadLine();
                        int n = str.Length;
                        Permutation.Permutate(str, 0, n - 1);
                        break;
                    case 2:
                        string Wordpath = File.ReadAllText(@"D:\VisualStudio\repos\DS_Algorithm-Programs\DS_Algorithm-Programs\binsearch.txt");
                        List<string> words = new List<string>(Wordpath.Split());
                        words.Sort();
                        BinarySearch.SearchWord(words);
                        break;

                    case 3:
                        InsertionSort insertionSort = new InsertionSort();
                        insertionSort.Insertion_Sort();
                        break;
                    case 4:
                        BubbleSort sort = new BubbleSort();
                        sort.Bubble_Sort();
                       break;

                    case 5:
                        MergeSort mergeSort= new MergeSort();
                        mergeSort.Merge_sort();
                        break;
                    case 6:
                        Anagram anagram = new Anagram();
                        anagram.Detect_Anagram();
                        break;
                    case 7:
                        PrimeNumbers prime = new PrimeNumbers();
                        prime.Check_Prime();
                        break;
                    case 8:
                        AnagramOrPalindrome anagram1 = new AnagramOrPalindrome();
                        anagram1.CheckPrime();
                        break;
                        
                      

                    case 9:
                        FindNumber findNumber = new FindNumber();
                        findNumber.Find();

                        findNumber.Question(12, 23);
                        break;


                    default:
                        Console.WriteLine("-------Enter the valid option---");
                        break;
                }
                Console.WriteLine("\nDo you want to continue");
                flag=Console.ReadLine();
            }
            Console.ReadKey();
        }
    }

}