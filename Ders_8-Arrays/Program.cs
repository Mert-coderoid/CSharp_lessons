using System;

// ********************* Ders 8 *********************
    // Arrays

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // array declaration

            // try
            // {
            //     string[] names = new string[5];
            //     names[0] = "John";

            //     string[] animals = { "Dog", "Cat", "Bird" };

            //     int[] array;
            //     array = new int[5];

            //     array[3] = 10;

            //     // Console.WriteLine(names[0]);
            //     // Console.WriteLine(animals);
            //     // Console.WriteLine(array[3]);

            //     // loops array 
            //     // dizinin eleman sayısını iste
            //     Console.WriteLine("Please enter the number of elements in the array: ");
            //     int arrayLength = int.Parse(Console.ReadLine());
            //     int[] NumberArray = new int[arrayLength];

            //     for (int i = 0; i < arrayLength; i++)
            //     {
            //         Console.WriteLine("Please enter {0} number", i + 1);
            //         NumberArray[i] = int.Parse(Console.ReadLine());
            //     }

            //     Console.WriteLine("Array elements: ");
            //     int intSum = 0;
            //     foreach (int number in NumberArray)
            //     {
            //         Console.WriteLine(number);
            //         intSum += number;
            //     }

            //     Console.WriteLine("\nSum of all numbers is {0}", intSum);

            // }
            // catch (Exception ex)
            // {
            //     Console.WriteLine(ex.Message);
            // }
            // finally
            // {
            //     Console.WriteLine("Press any key to exit.");
            //     Console.ReadKey();
            // }

            // ********************* Ders 9 *********************
            // Array Class Methods

            try
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                // foreach (var item in array)
                // {
                //     Console.WriteLine(item);
                // }

                // shuffle array
                Random rnd = new Random();
                for (int i = 0; i < array.Length; i++)
                {
                    int randomIndex = rnd.Next(0, array.Length);
                    int temp = array[i];
                    array[i] = array[randomIndex];
                    array[randomIndex] = temp;
                }

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                // sort array
                Array.Sort(array);
                Console.WriteLine("Sorted array: ");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                // reverse array
                Array.Reverse(array);
                Console.WriteLine("Reversed array: ");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                // clear array
                Array.Clear(array, 0, 2);
                Console.WriteLine("Cleared array: ");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                // copy array
                int[] array2 = new int[5];
                Array.Copy(array, array2, 5);
                Console.WriteLine("Copied array: ");
                foreach (var item in array2)
                {
                    Console.WriteLine(item);
                }

                // index of array
                Console.WriteLine("Index of 5 is {0}", Array.IndexOf(array, 5));

                // resize array
                Array.Resize(ref array, 15);
                Console.WriteLine("Resized array: ");
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }

                // binary search
                Console.WriteLine("Binary search of 5 is {0}", Array.BinarySearch(array, 0));
                
                // IndexOf
                Console.WriteLine("Index of 5 is {0}", Array.IndexOf(array, 0));

                // clear 0 from array and resize array only numbers bigger than 0
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == 0)
                    {
                        count++;
                    }
                }

                int[] array3 = new int[array.Length - count];
                // add numbers bigger than 0 to array3
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] != 0)
                    {
                        array3[index] = array[i];
                        index++;
                    }
                }

                foreach (var item in array3)
                {
                    Console.WriteLine(item);
                }

                // get max value
                Console.WriteLine("Max value is {0}", array3.Max());

                // find there is how many max value in array
                int max = array3.Max();
                int maxCount = 0;
                for (int i = 0; i < array3.Length; i++)
                {
                    if (array3[i] == max)
                    {
                        maxCount++;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

        }
    }
}